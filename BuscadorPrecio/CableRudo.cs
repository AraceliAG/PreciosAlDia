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
    public partial class CableRudo : Form
    {
        public CableRudo()
        {
            InitializeComponent();
        }

        private void btBuscarPrecio_Click(object sender, EventArgs e)
        {

            string marca = cbMarca.Text;
            string calibre = cbCalibre.Text;

            if (marca == "Todos")
            {
                // Consulta SQL para obtener el precio más bajo de cada marca
                string query = $@"
                SELECT c.proveedor, c.marca, c.precio, STR_TO_DATE(c.fecha, '%d/%m/%Y') AS fecha_
                FROM cables c
                WHERE calibre = '{calibre}'
                  AND STR_TO_DATE (c.fecha, '%d/%m/%Y') = (
                SELECT MAX(STR_TO_DATE(c2.fecha, '%d/%m/%Y'))
                FROM cables c2
                WHERE c2.proveedor = c.proveedor
                  AND c2.nombre = c.nombre
                  AND c2.calibre = c.calibre
                  AND c2.color = c.color
              )
            ORDER BY fecha_ DESC, c.precio ASC";

                // Ejecutar la consulta utilizando DbUtils
                DataTable resultados = DbUtils.ExecuteQuery(query);

                // Mostrar los resultados en el DataGridView
                //dataGridView1.DataSource = resultados;
                // Crear una nueva columna para el precio formateado
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
        FROM cables c
        WHERE marca = '{marca}'
          AND calibre = '{calibre}'
           AND c.fecha = (
            SELECT MAX(c2.fecha)
            FROM cables c2
            WHERE c2.proveedor = c.proveedor
              AND c2.nombre = c.nombre
              AND c2.calibre = c.calibre
              AND c2.color = c.color
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
            btnCancelar.Visible = false;

        }
        private void limpiar()
        {
            cbProveedorGlobal.Text = ""; ;
            txtPrecioGlobal.Text = "";
            cbMarca.Text = " ";
            cbCalibre.Text = "";


        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            // Verificar si algún campo está vacío
            if (string.IsNullOrWhiteSpace(cbCalibre.Text) ||
                string.IsNullOrWhiteSpace(cbMarca.Text) ||
                string.IsNullOrWhiteSpace(txtPrecioGlobal.Text) ||
                string.IsNullOrWhiteSpace(cbProveedorGlobal.Text))
            {
                MessageBox.Show("Todos los campos deben estar llenos para realizar el registro.");
            }
            else
            {
                string query = $@"INSERT INTO cables  
                     VALUES (idcables,'Cable de uso rudo THHW', 
                    '{cbCalibre.Text}', 'AWG', '600V', '{cbMarca.Text}', 'Suministro y colocación.',
                    'm', '{txtPrecioGlobal.Text}', '{cbProveedorGlobal.Text}', 
                    '{dtpFechaGlobal.Value.ToString("dd/MM/yyyy")}')";


                DataTable resultados = DbUtils.ExecuteQuery(query);

                MessageBox.Show("SE HA AGREGADO CORRECTAMENTE");
                desaparecer();
                limpiar();
            }

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
            cbCalibre.Text = "";
            bynAgregarGlobal.Visible = false;
            btnCancelar.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            desaparecer();
            limpiar();

        }
    }
}
