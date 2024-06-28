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
    SELECT proveedor, MIN(precio) AS precio_minimo, fecha
    FROM cables
    WHERE nombre LIKE 'Cable Cu. THHW%'
      AND calibre = '{calibre}'
      AND color = '{color}'
      AND fecha = (SELECT MAX(fecha) FROM cables)
    GROUP BY proveedor, fecha
";

                // Ejecutar la consulta utilizando DbUtils
                DataTable resultados = DbUtils.ExecuteQuery(query);

                // Mostrar los resultados en el DataGridView
                dataGridView1.DataSource = resultados;

                


            }
            else
            {
                // Construir la consulta SQL dinámica
                string query = $@"
        SELECT precio, proveedor, fecha
        FROM cables
        WHERE nombre LIKE 'Cable Cu. THHW%'
          AND calibre = '{calibre}'
          AND color = '{color}'
          AND marca = '{marca}'
          AND fecha = (SELECT MAX(fecha) FROM cables)
          AND precio = (SELECT MIN(precio) FROM cables WHERE fecha = (SELECT MAX(fecha) FROM cables))
    ";

                // Ejecutar la consulta utilizando DbUtils
                DataTable resultados = DbUtils.ExecuteQuery(query);

                // Mostrar los resultados en el DataGridView
                dataGridView1.DataSource = resultados;
            }


        }



    }
}
