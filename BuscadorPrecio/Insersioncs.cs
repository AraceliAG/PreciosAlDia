using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using MySqlConnector;


namespace BuscadorPrecio
{
    public partial class Insercion : Form
    {
        public Insercion()
        {
            InitializeComponent();
        }


        private void limpieza()
        {
            string nombre = "";
            string calibre = "";
            string tipo_medida = "";
            string color = "";
            string marca = "";
            string servicio = "";
            string unidad = "";
            string precio1 = "";
            string proveedor = "";
            string fecha1 = "";

            cbCalibre.Text = calibre;
            cbColor.Text = color;
            cbMarca.Text = marca;
            txtPrecio.Text = precio1;
            txtProveedor.Text = proveedor;
            txtFecha.Text = fecha1;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = "Cable Cu. THHW-LS, 90°C, 600V, Cal.";
            string calibre = cbCalibre.Text;
            string tipo_medida = "AWG";
            string color = cbColor.Text;
            string marca = cbMarca.Text;
            string servicio = "Suministro y colocación.";
            string unidad = "m";
            string precio1 = txtPrecio.Text;
            string proveedor = txtProveedor.Text;
            string fecha1 = txtFecha.Text;

            string precio = precio1.Replace("$", "").Trim();

            

            DateTime fecha2 = DateTime.ParseExact(fecha1, "M/d/yyyy", null);

            // Formatear la fecha en el formato deseado
            string fecha = fecha2.ToString("dd-MM-yyyy");

            string query = $@"insert into cables values(idcables, '{nombre}', '{calibre}',
            '{tipo_medida}', '{color}', '{marca}', '{servicio}', '{unidad}',
            '{precio}', '{proveedor}', '{fecha}' )";

            // Ejecutar la consulta utilizando DbUtils


            try
            {
                // Ejecutar la consulta utilizando DbUtils.ExecuteNonQuery
                int rowsAffected = DbUtils.ExecuteNonQuery(query);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Los datos se insertaron correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpieza();
                }
                else
                {
                    MessageBox.Show("No se insertaron datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al insertar datos en la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
    
}
