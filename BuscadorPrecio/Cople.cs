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
    public partial class Cople : Form
    {
        public Cople()
        {
            InitializeComponent();
        }


        private void milimetros(string medida)
        {

            string consulta = $@"SELECT medida2
            from cople WHERE medida1 = '{medida}'";

            DataTable resultados = DbUtils.ExecuteQuery(consulta);


            if (resultados.Rows.Count > 0)
            {
                // Extraer el primer resultado
                lblMm.Visible = true;
                DataRow fila = resultados.Rows[0];

                // Asignar los valores a los Labels
                //lblCapacidad.Text = fila["capacidad_a"].ToString();
                lblMm.Text = (fila["medida2"].ToString());


            }

        }
        private void cbTipoITM_SelectedIndexChanged(object sender, EventArgs e)
        {

            cbMedida.Items.Clear();
            cbMarca.Items.Clear();
            if (cbTipoCople.Text == "Cople FoGa P/Delgada")
            {
                cbMedida.Items.AddRange(new object[]
                {
                    "1/2",
                    "3/4",
                    "1",
                    "1 1/4",
                    "1 1/2",
                    "2"

                });
                cbMarca.Items.AddRange(new object[] {
                "TODOS",
                "Crouse Hinds"});



            }
            else if (cbTipoCople.Text == "Cople p/Tubo conduit PVC pesado")
            {
                cbMedida.Items.AddRange(new object[] {
                
                "1/2",
                "3/4",
                "1 1/4",
                 "2"

                });
                cbMarca.Items.AddRange(new object[] {
                "TODOS"});

            }
        }

        private void cbMedida_SelectedIndexChanged(object sender, EventArgs e)
        {
            milimetros(cbMedida.Text);
        }

        private void btBuscarPrecio_Click(object sender, EventArgs e)
        {
            string marca = cbMarca.Text;
            string nombre = cbTipoCople.Text;
            string medida = cbMedida.Text;
            if (marca == "TODOS")
            {
                // Consulta SQL para obtener el precio más bajo de cada marca
                string query = $@"
                SELECT c.proveedor, c.marca, c.precio, STR_TO_DATE(c.fecha, '%d/%m/%Y') AS fecha_
                FROM cople c
                WHERE nombre = '{nombre}'             
                 AND medida1 = '{medida}'
                  AND STR_TO_DATE (c.fecha, '%d/%m/%Y') = (
                SELECT MAX(STR_TO_DATE(c2.fecha, '%d/%m/%Y'))
                FROM cople c2
                WHERE c2.proveedor = c.proveedor
                  AND c2.nombre = c.nombre
                  AND c2.medida1 = c.medida1
                                  
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
        FROM cople c
        WHERE marca = '{marca}'
          AND medida1 = '{medida}'
          AND nombre = '{nombre}'
           AND STR_TO_DATE(c.fecha, '%d/%m/%Y') = (
            SELECT MAX(STR_TO_DATE(c2.fecha, '%d/%m/%Y'))
            FROM cople c2
            WHERE c2.proveedor = c.proveedor
              AND c2.nombre = c.nombre
              AND c2.medida1 = c.medida1
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
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewCell cell in dataGridView1.Rows[0].Cells)
                {
                    cell.Style.BackColor = Color.LightGreen;
                }
            }
        
        }
    }
}
