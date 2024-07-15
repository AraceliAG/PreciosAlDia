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
    public partial class Tuercas : Form
    {
        public Tuercas()
        {
            InitializeComponent();
        }

        private void cbCalibre_SelectedIndexChanged(object sender, EventArgs e)
        {

            //DEPENDIENDO EL TIPO DE TUERCA SE DESPLEGA LAS MEDIDAS CORREPONDIENTES
            cbMedida.Items.Clear();
            cbMedida.Text = " ";

            if (cbTipo.Text == "Tuerca p/unicanal con resorte")
            {
                cbMedida.Items.AddRange(new object[]{
                    " 1/4",
                    " 3/8"
                });
            }
            else if (cbTipo.Text == "Tuerca COPLE")
            {
                cbMedida.Items.AddRange(new object[]{
                    " 1/4",
                    " 3/8",
                    " 1/2"
                });

            }
            else if (cbTipo.Text == "Tuerca hexagonal, inoxidable")
            {
                cbMedida.Items.AddRange(new object[]{
                    " 3/8"

                });

            }
            else if (cbTipo.Text == "Tuerca hexagonal, galvanizada")
            {
                cbMedida.Items.AddRange(new object[]{
                    " 1/4",
                    " 3/8",
                    " 1/2"

                });

            }
            else if (cbTipo.Text == "Tuerca inserto de nylon, inoxidable")
            {
                cbMedida.Items.AddRange(new object[]{
                    " 3/8 , 16"

                });

            }
        }

        private void btBuscarPrecio_Click(object sender, EventArgs e)
        {
            string tipo = cbTipo.Text;
            string medida = cbMedida.Text;
            string marca = cbMarca.Text;


            if (marca == "Todos")
            {
                // Consulta SQL para obtener el precio más bajo de cada marca
                string query = $@"
                SELECT c.proveedor, c.marca, c.precio, STR_TO_DATE(c.fecha, '%d/%m/%Y') AS fecha_
                FROM tuercas c
                WHERE nombre = '{tipo}'
                  AND medida = '{medida}'
                  AND STR_TO_DATE (c.fecha, '%d/%m/%Y') = (
                SELECT MAX(STR_TO_DATE(c2.fecha, '%d/%m/%Y'))
                FROM tuercas c2
                WHERE c2.proveedor = c.proveedor
                  AND c2.nombre = c.nombre
                  AND c2.medida = c.medida
                  
              )
            ORDER BY fecha_ DESC, c.precio ASC";

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
        SELECT c.proveedor, c.precio, STR_TO_DATE(c.fecha, '%d/%m/%Y') AS fecha_
        FROM tuercas c
        WHERE marca = '{marca}'
          AND medida = '{medida}'
          AND nombre = '{tipo}'
           AND STR_TO_DATE(c.fecha, '%d/%m/%Y') = (
            SELECT MAX(STR_TO_DATE(c2.fecha, '%d/%m/%Y'))
            FROM tuercas c2
            WHERE c2.proveedor = c.proveedor
              AND c2.nombre = c.nombre
              AND c2.medida = medida
              AND c2.marca = c.marca
          )
        ORDER BY fecha_ DESC, c.precio ASC
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
    }
}
