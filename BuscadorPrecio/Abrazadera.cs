﻿using System;
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
    public partial class Abrazadera : Form
    {
        public Abrazadera()
        {
            InitializeComponent();
        }
        //private void limpieza()
        //{
        //    string calibre = "";
        //    string medida = "";
        //    string marca = "";
        //    cbMarca.Text = marca;
        //    cbMedidaMili.Text = medida;
        //    cbCalibre.Text = calibre;

        //}
        private void BuscadorGlobal(string calibre, string medida, string marca, string nombre)
        {
            if (marca == "Todos")
            {
                // Consulta SQL para obtener el precio más bajo de cada marca
                string query = $@"
                SELECT c.proveedor, c.marca, c.precio, STR_TO_DATE(c.fecha, '%d/%m/%Y') AS fecha_
                FROM abrazaderas c
                JOIN (
                SELECT proveedor, MAX(STR_TO_DATE(fecha, '%d/%m/%Y')) AS max_fecha
                FROM abrazaderas
                  WHERE tipo_medida = '{medida}'
                  AND calibre = '{calibre}'
                  AND nombre like  '{nombre}%'
                GROUP BY proveedor
            ) sub ON STR_TO_DATE(c.fecha, '%d/%m/%Y') = sub.max_fecha
                WHERE c.proveedor = sub.proveedor
              AND c.tipo_medida = '{medida}'
              AND c.calibre = '{calibre}'
                AND nombre like '{nombre}%'
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
        SELECT c.proveedor, c.marca, c.precio, STR_TO_DATE(c.fecha, '%d/%m/%Y') AS fecha_
        FROM abrazaderas c
        WHERE c.marca = '{marca}'
          AND c.tipo_medida = '{medida}'
          AND c.calibre = '{calibre}'
            AND nombre like '{nombre}%'
          AND STR_TO_DATE(c.fecha, '%d/%m/%Y') = (
            SELECT MAX(STR_TO_DATE(c2.fecha, '%d/%m/%Y'))
            FROM abrazaderas c2
            WHERE c2.marca = '{marca}'
              AND c2.tipo_medida = '{medida}'
              AND c2.calibre = '{calibre}'
               AND nombre like '{nombre}%'
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
        private void btBuscarPrecio_Click(object sender, EventArgs e)
        {
            string calibre = cbCalibre.Text;
            string medida = cbMedidaMili.Text;
            string marca = cbMarca.Text;
            string nombre = "Abrazadera unicanal";

            BuscadorGlobal(calibre, medida, marca, nombre);


            //limpieza();

        }

        private void Ocultar1()
        {
            lblCalibre.Visible = false;
            lblMarca.Visible = false;
            lblMedida.Visible = false;
            btBuscarPrecio.Visible = false;

            cbCalibre.Visible = false;
            cbMarca.Visible = false;
            cbMedidaMili.Visible = false;

            lblCalibreP.Visible = false;
            lblMarcaP.Visible = false;
            lblMedidaP.Visible = false;
            btnBuscarP.Visible = false;

            cbCalibrePera.Visible = false;
            cbMarcaPera.Visible = false;
            cbMedidaPera.Visible = false;



            /*LIMPIAR CAMPOS*/
            cbCalibre.Text = "";
            cbMarca.Text = "";
            cbMedidaMili.Text = "";


            cbCalibrePera.Text = "";
            cbMarcaPera.Text = "";
            cbMedidaPera.Text = "";

        }

        private void Ocultar2()
        {
            lblCalibreP.Visible = false;
            lblMarcaP.Visible = false;
            lblMedidaP.Visible = false;
            btnBuscarP.Visible = false;

            cbCalibrePera.Visible = false;
            cbMarcaPera.Visible = false;
            cbMedidaPera.Visible = false;


            lblCalibreO.Visible = false;
            lblMarcaO.Visible = false;
            lblMedidaO.Visible = false;
            btnBucarO.Visible = false;

            cbCalibreOmega.Visible = false;
            cbMarcaOmega.Visible = false;
            cbMedidaOmega.Visible = false;



            /*LIMPIAR CAMPOS*/
            cbCalibrePera.Text = "";
            cbMarcaPera.Text = "";
            cbMedidaPera.Text = "";

            cbCalibreOmega.Text = "";
            cbMarcaOmega.Text = "";
            cbMedidaOmega.Text = "";



        }

        private void Ocultar3()
        {
            lblCalibreO.Visible = false;
            lblMarcaO.Visible = false;
            lblMedidaO.Visible = false;
            btnBucarO.Visible = false;

            cbCalibreOmega.Visible = false;
            cbMarcaOmega.Visible = false;
            cbMedidaOmega.Visible = false;

            lblCalibre.Visible = false;
            lblMarca.Visible = false;
            lblMedida.Visible = false;
            btBuscarPrecio.Visible = false;

            cbCalibre.Visible = false;
            cbMarca.Visible = false;
            cbMedidaMili.Visible = false;

            /*LIMPIAR CAMPOS*/

            cbCalibreOmega.Text = "";
            cbMarcaOmega.Text = "";
            cbMedidaOmega.Text = "";

            cbCalibre.Text = "";
            cbMarca.Text = "";
            cbMedidaMili.Text = "";


        }


        private void btAbrzaderdaUnical_Click(object sender, EventArgs e)
        {

            lblCalibre.Visible = true;
            lblMarca.Visible = true;
            lblMedida.Visible = true;
            btBuscarPrecio.Visible = true;

            cbCalibre.Visible = true;
            cbMarca.Visible = true;
            cbMedidaMili.Visible = true;


            /*AQUI*/
            Ocultar2();

        }

        private void btnAbrazaderaOmega_Click(object sender, EventArgs e)
        {
            lblCalibreO.Visible = true;
            lblMarcaO.Visible = true;
            lblMedidaO.Visible = true;
            btnBucarO.Visible = true;

            cbCalibreOmega.Visible = true;
            cbMarcaOmega.Visible = true;
            cbMedidaOmega.Visible = true;

            //OCULTAR COMPONENTES DE LOS OTROS TIPOS DE ABRAZADERAS
            Ocultar1();

        }



        private void btnAbrazaderaPera_Click(object sender, EventArgs e)
        {
            lblCalibreP.Visible = true;
            lblMarcaP.Visible = true;
            lblMedidaP.Visible = true;
            btnBuscarP.Visible = true;

            cbCalibrePera.Visible = true;
            cbMarcaPera.Visible = true;
            cbMedidaPera.Visible = true;
            Ocultar3();

        }

        private void btnBucarO_Click(object sender, EventArgs e)
        {
            string calibreO = cbCalibreOmega.Text;
            string medidaO = cbMedidaOmega.Text;
            string marcaO = cbMarcaOmega.Text;
            string nombreO = "Abrazadera Omega";

            BuscadorGlobal(calibreO, medidaO, marcaO, nombreO);

        }
        private void btnBuscarP_Click(object sender, EventArgs e)
        {

            string calibreP = cbCalibrePera.Text;
            string medidaP = cbMedidaPera.Text;
            string marcaP = cbMarcaPera.Text;
            string nombreP = "Abrazadera tipo";


            BuscadorGlobal(calibreP, medidaP, marcaP, nombreP);


        }

        private void btnAgregarGlobal_Click(object sender, EventArgs e)
        {
            lblMarca.Visible = false;
            lblFecha.Visible = true;
            lblProveedor.Visible = true;
            cbProveedorGlobal.Visible = true;
            txtPrecioGlobal.Visible = true;
            dtpFechaGlobal.Visible = true;
            btnFinalizar.Visible = true;
            lblPrecio.Visible = true;

            //OCULTAR CARACTERISTICAS


            //BUSCAR PRECIOS
            btBuscarPrecio.Visible = false;
            btnBucarO.Visible = false;
            btnBuscarP.Visible = false;

            //MEDIDAS
            cbMedidaMili.Text = "";
            cbMedidaOmega.Text = " ";
            cbMedidaPera.Text = " ";

            //MARCAS
            cbMarcaOmega.Text = " ";
            cbMarcaPera.Text = " ";
            cbMarca.Text = " ";
            //CALIBRES
            cbCalibreOmega.Text = "";
            cbCalibre.Text = "";
            cbCalibrePera.Text = "";

            dataGridView1.DataSource = null;
            btnAgregarGlobal.Visible = false;
        }
    }
}
