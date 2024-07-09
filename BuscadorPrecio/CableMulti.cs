using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscadorPrecio
{
    public partial class CableMulti : Form
    {
        public CableMulti()
        {
            InitializeComponent();
        }


        private void btBuscarPrecio_Click(object sender, EventArgs e)
        {
            string color = cbCaracyteristica.Text;
            string marca = cbMarca.Text;
            string calibre = cbCalibre.Text;

            if (marca == "Todos")
            {
                // Consulta SQL para obtener el precio más bajo de cada marca
                string query = $@"
                SELECT c.proveedor, c.marca, c.precio, c.fecha
                FROM cables c
                WHERE calibre = '{calibre}'
                  AND color = '{color}'
                  AND STR_TO_DATE (c.fecha, '%d/%m/%Y') = (
                SELECT MAX(STR_TO_DATE(c2.fecha, '%d/%m/%Y'))
                FROM cables c2
                WHERE c2.proveedor = c.proveedor
                  AND c2.nombre = c.nombre
                  AND c2.calibre = c.calibre
                  AND c2.color = c.color
              )
            ORDER BY c.proveedor, c.nombre, c.calibre, c.color, c.marca";

                // Ejecutar la consulta utilizando DbUtils
                DataTable resultados = DbUtils.ExecuteQuery(query);

                // Mostrar los resultados en el DataGridView
                resultados.Columns.Add("precio_formateado", typeof(string));

                foreach (DataRow row in resultados.Rows)
                {
                    decimal precio = Convert.ToDecimal(row["precio"]);
                    row["precio_formateado"] = precio.ToString("C2", new System.Globalization.CultureInfo("es-MX"));
                }

                // Mostrar los resultados en el DataGridView
                dataGridView1.DataSource = resultados;

                // Ocultar la columna original de precio
                dataGridView1.Columns["precio"].Visible = false;

                // Mostrar la columna formateada
                dataGridView1.Columns["precio_formateado"].HeaderText = "Precio";

            }
            else
            {
                // Construir la consulta SQL dinámica
                string query = $@"
        SELECT c.proveedor, c.precio, c.fecha
        FROM cables c
        WHERE marca = '{marca}'
          AND calibre = '{calibre}'
          AND color = '{color}'
           AND c.fecha = (
            SELECT MAX(c2.fecha)
            FROM cables c2
            WHERE c2.proveedor = c.proveedor
              AND c2.nombre = c.nombre
              AND c2.calibre = c.calibre
              AND c2.color = c.color
              AND c2.marca = c.marca
          )
        ORDER BY MAX(c.fecha) asc
        LIMIT 1";

                // Ejecutar la consulta utilizando DbUtils
                DataTable resultados = DbUtils.ExecuteQuery(query);

                // Mostrar los resultados en el DataGridView
                resultados.Columns.Add("precio_formateado", typeof(string));

                foreach (DataRow row in resultados.Rows)
                {
                    if (row["precio"] != DBNull.Value && !string.IsNullOrEmpty(row["precio"].ToString()))
                    {
                        decimal precio = Convert.ToDecimal(row["precio"]);
                        row["precio_formateado"] = precio.ToString("C2", new System.Globalization.CultureInfo("es-MX"));
                    }
                    else
                    {
                        row["precio_formateado"] = "$0.00"; // o cualquier valor predeterminado que desees mostrar
                    }
                }

                // Mostrar los resultados en el DataGridView
                dataGridView1.DataSource = resultados;

                // Ocultar la columna original de precio
                dataGridView1.Columns["precio"].Visible = false;

                // Mostrar la columna formateada
                dataGridView1.Columns["precio_formateado"].HeaderText = "Precio";
            }



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cbCaracyteristica_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cbCalibre_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lblMarca_Click(object sender, EventArgs e)
        {
        }

        private void lblCaracteristica_Click(object sender, EventArgs e)
        {
        }

        private void lblCalibre_Click(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void desaparecer()
        {

            lblFecha.Visible = false;
            lblProveedor.Visible = false;
            cbProveedorGlobal.Visible = false;
            txtPrecioGlobal.Visible = false;
            dtpFechaGlobal.Visible = false;
            btnFinalizar.Visible = false;
            lblPrecio.Visible = false;
            btBuscarPrecio.Visible = true;
            bynAgregarGlobal.Visible = true;

        }
        private void limpiar()
        {
            cbProveedorGlobal.Text = ""; ;
            txtPrecioGlobal.Text = "";
            cbMarca.Text = " ";
            cbCaracyteristica.Text = "";
            cbCalibre.Text = "";
            

        }

        private void bynAgregarGlobal_Click(object sender, EventArgs e)
        {
            lblMarca.Visible = true;
            lblFecha.Visible = true;
            lblProveedor.Visible = true;
            cbProveedorGlobal.Visible = true;
            txtPrecioGlobal.Visible = true;
            dtpFechaGlobal.Visible = true;
            btnFinalizar.Visible = true;
            lblPrecio.Visible = true;
            btBuscarPrecio.Visible = false;
            dataGridView1.DataSource = null;
            cbMarca.Text = " ";
            cbCaracyteristica.Text = "";
            cbCalibre.Text = "";
            bynAgregarGlobal.Visible = false;



        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            desaparecer();
            limpiar();
        }
    }
}
