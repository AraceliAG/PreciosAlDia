using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscadorPrecio
{
    public partial class Conectores : Form
    {
        public Conectores()
        {
            InitializeComponent();
        }

        private void cbMedida_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoConector.Text == "Conector FoGa P/Delgada" ||
                cbTipoConector.Text == "Conector recto p/Tubo licuatite")
            {
                milimetros(cbMedida.Text);
            }
            else
            {
                milimetros2(cbMedida.Text);
            }


        }

        private void visible()
        {
            cbMedida.Visible = true;
            lblMedida.Visible = true;

            lblmm.Visible = true;

            cbCarac.Visible = true;
            lblCarac.Visible = true;

            cbMarca.Visible = true;
            lblMarca.Visible = true;
            btBuscarPrecio.Visible = true;

        }

        private void milimetros(string medida)
        {
            if (medida == "1/2")
            {
                lblmm.Text = "16 mm";
            }
            else if (medida == "3/4")
            {
                lblmm.Text = "21 mm";

            }
            else if (medida == "1")
            {
                lblmm.Text = "27 mm";
            }
            else if (medida == "2")
            {
                lblmm.Text = "53 mm";
            }
            else if (medida == "1 1/4")
            {
                lblmm.Text = "35 mm";
            }
        }
        private void milimetros2(string medida)
        {
            if (medida == "1/2")
            {
                lblmm.Text = "13 mm";
            }
            else if (medida == "3/4")
            {
                lblmm.Text = "19 mm";

            }
            else if (medida == "1")
            {
                lblmm.Text = "";
            }
        }
        private void limpieza1()
        {
            cbMedida.Items.Clear();
            cbMarca.Items.Clear();
            cbCarac.Items.Clear();
            cbModelo.Items.Clear();
            cbModelo.Text = " ";
            lblmm.Text = " ";
            lblCalibre.Text = " ";
            cbMedida.Text = " ";
            cbMarca.Text = " ";
            cbCarac.Text = " ";


        }

        private void cbTipoTapa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoConector.Text == "Conector FoGa P/Delgada")
            {
                limpieza1();

                cbMedida.Items.AddRange(new object[]
                {
                    "1/2",
                    "3/4",
                    "1"


                });
                cbMarca.Items.AddRange(new object[]
                {
                    "TODOS",
                    "Crouse Hinds"

                });
                cbCarac.Items.AddRange(new object[]
                {
                    "EMT"
                });

                visible();
                cbModelo.Visible = false;
                lblModelo.Visible = false;


            }

            else if (cbTipoConector.Text == "Conector bipartido, de cobre")
            {
                limpieza1();

                cbMarca.Items.AddRange(new object[]
                {
                    "TODOS",
                    "BURNDY"

                });
                cbModelo.Items.AddRange(new object[]
                {
                    "KS-15",
                    "KS-17",
                    "KS-20",
                    "KS-22",
                    "KS-25"
                });

                visible();
                cbMedida.Visible = false;
                lblMedida.Visible = false;
                cbModelo.Visible = true;
                lblModelo.Visible = true;
                cbCarac.Visible = false;
                lblCarac.Visible = false;
                lblmm.Visible = false;
                lblCalibre.Visible = true;


            }
            else if (cbTipoConector.Text == "Conector recto Zapa, p/tubo flexible")
            {
                limpieza1();
                cbModelo.Visible = true;
                lblModelo.Visible = true;
                cbMedida.Visible = true;
                lblMedida.Visible = true;
                cbMarca.Visible = true;
                lblMarca.Visible = true;

                cbModelo.Items.AddRange(new object[]
                {
                    "FXR-38",
                    "FXR-39",
                    "FXR-12"
                });
                cbMarca.Items.AddRange(new object[]
                {
                    "TODOS",
                    "ANCLO"

                });
                cbMedida.Items.AddRange(new object[]
                {
                    "1/2",
                    "3/8"
                });


            }
            else if (cbTipoConector.Text == "Conector recto p/Tubo licuatite")
            {
                limpieza1();

                cbMedida.Items.AddRange(new object[]
                {
                    "1/2",
                    "3/4",
                    "1",
                    "1 1/4",
                    "2"


                });
                cbMarca.Items.AddRange(new object[]
                {
                    "TODOS",
                    "ANCLO"

                });


                visible();
                cbModelo.Visible = false;
                lblModelo.Visible = false;
                cbCarac.Visible = false;
                lblCarac.Visible = false;


            }

            else if (cbTipoConector.Text == "Conector glándula con contratuerca")
            {
                limpieza1();

                cbMedida.Items.AddRange(new object[]
                {
                    "1/2",
                    "3/4",
                    "1",
                    "1 1/4"


                });
                cbMarca.Items.AddRange(new object[]
                {
                    "TODOS",
                    "ANCLO",
                    "DROF",
                    "ARGOS"

                });
                cbCarac.Items.AddRange(new object[]
                {
                    "Nylon NPT"
                });

                visible();
                cbModelo.Visible = false;
                lblModelo.Visible = false;

            }
        }

        private void cbCarac_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbModelo.Text == "KS-15")
            {
                lblCalibre.Text = "Cal. 14 tre -8 tre, AWG";

            }
            else if (cbModelo.Text == "KS-17")
            {
                lblCalibre.Text = "Cal. 8 tre-6 sol, AWG";
            }
            else if (cbModelo.Text == "KS-20")
            {
                lblCalibre.Text = "Cal. 8 tre - 4 sol, AWG";
            }
            else if (cbModelo.Text == "KS-22")
            {
                lblCalibre.Text = "Cal. 6-2, AWG";
            }
            else if (cbModelo.Text == "KS-25")
            {
                lblCalibre.Text = "Cal. 4-1/0, AWG";
            }
        }


        private void consultaGeneral(string nombre, string modelo, string medida, string caracteristica, string marca)
        {
            if (marca == "TODOS")
            {
                // Consulta SQL para obtener el precio más bajo de cada marca
                string query = $@"
                SELECT c.proveedor, c.marca, c.precio, STR_TO_DATE(c.fecha, '%d/%m/%Y') AS fecha_
                FROM conector c
                WHERE nombre = '{nombre}'
                  AND medida1 = '{medida}'
                 AND caracteristica = '{caracteristica}'
                  AND STR_TO_DATE (c.fecha, '%d/%m/%Y') = (
                SELECT MAX(STR_TO_DATE(c2.fecha, '%d/%m/%Y'))
                FROM conector c2
                WHERE c2.proveedor = c.proveedor
                  AND c2.nombre = c.nombre
                  AND c2.medida1 = c.medida1
                   AND c2.caracteristica = c.caracteristica
                  
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
        FROM conector c
        WHERE marca = '{marca}'
          AND medida1 = '{medida}'
          AND nombre = '{nombre}'
          AND caracteristica = '{caracteristica}'
           AND STR_TO_DATE(c.fecha, '%d/%m/%Y') = (
            SELECT MAX(STR_TO_DATE(c2.fecha, '%d/%m/%Y'))
            FROM conector c2
            WHERE c2.proveedor = c.proveedor
              AND c2.nombre = c.nombre
              AND c2.medida1 = c.medida1
              AND c2.marca = c.marca
              AND c2.caracteristica = c.caracteristica
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
            string nombre = cbTipoConector.Text;
            string modelo = cbModelo.Text;
            string medida = cbMedida.Text;
            string medida2 = lblmm.Text;
            string medida2_2 = lblCalibre.Text;
            string carac = cbCarac.Text;
            string marca = cbMarca.Text;

            //(string nombre, string modelo, string medida, string caracteristica, string marca)

            //Conector bipartido, de cobre
            //Conector recto p/ Tubo licuatite
            //Conector recto Zapa, p/ tubo flexible
            //Conector glándula con contratuerca
            if (nombre == "Conector FoGa P/Delgada")
            {
                consultaGeneral(nombre, modelo ="", medida, carac, marca);

            }else if (nombre == "Conector recto p/ Tubo licuatite")
            {
                consultaGeneral(nombre, modelo = "", medida, carac = " ", marca);
            }
            

        

    }
   }
}

