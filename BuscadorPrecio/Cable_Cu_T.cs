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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btBuscarPrecio_Click(object sender, EventArgs e)
        {
            string color = cbColor.Text;
            string marca = cbMarca.Text;
            string calibre = cbCalibre.Text;

            if (marca == "Todos")
            {
                // Consulta SQL para obtener el precio más bajo de cada marca
                string query = $@"
                SELECT c.proveedor, c.precio, c.fecha
                FROM cables c
                WHERE calibre = '{calibre}'
                  AND color = '{color}'
                  AND c.fecha = (
                SELECT MAX(c2.fecha)
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
                dataGridView1.DataSource = resultados;

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
        ORDER BY c.fecha asc
        LIMIT 1";

                // Ejecutar la consulta utilizando DbUtils
                DataTable resultados = DbUtils.ExecuteQuery(query);

                // Mostrar los resultados en el DataGridView
                dataGridView1.DataSource = resultados;
            }


        }



    }
}
