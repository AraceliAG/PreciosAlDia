using System;
using System.Collections;
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
    public partial class ITM : Form
    {
        public ITM()
        {
            InitializeComponent();
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSerie.Items.Clear();
            cbMarca.Items.Clear();

            string opc = cbTipoITM.Text;

            if (opc == "I.T.M., Riel Din 1P")
            {
                cbSerie.Items.AddRange(new object[] {

                    "5SL61167CC",
                    "5SL61257CC"

                });

                cbMarca.Items.AddRange(new object[] {
                "SIEMENS"});
            }
            else if (opc == "I.T.M., Riel Din 2P")
            {
                cbSerie.Items.AddRange(new object[] {

                    "5SL62207CC",
                    "5SL62327CC"

                });

            }
            else if (opc == "I.T.M., Riel Din 3P")
            {
                cbSerie.Items.AddRange(new object[] {

                    "5SL63167CC",
                    "5SL63327CC",
                    "5SL63407CC"

                });

            }
            else if (opc == "I.T.M., QO-Enchufable")
            {
                cbSerie.Items.AddRange(new object[] {
                    "QO115",
                    "QO120",
                    "QO130",
                    "QO140",
                    "QO215",
                    "QO220",
                    "QO230",
                    "QO240",
                    "QO250",
                    "QO260",
                    "QO270",
                    "QO320",
                    "QO330",
                    "QO340",
                    "QO350",
                    "QO360",
                    "QO370",
                    "QO3100",


                });


            }
            else if (opc == "I.T.M., QO-Atornillable")
            {
                cbSerie.Items.AddRange(new object[] {

                    "QOB3100",
                    "QOB3125VH"
                });

            }
            else if (opc == "I.T.M., HDA 3 POLOS I-LINE")
            {
                cbSerie.Items.AddRange(new object[] {

                    "HDA36040",
                    "HDA36070",
                    "HDA36090",
                    "HDA36100",
                    "HDA36125",
                    "HDA36150"

                });
            }
            else if (opc == "I.T.M., JDA 3 POLOS I-LINE")
            {
                cbSerie.Items.AddRange(new object[] {
                    "JDA36175",
                    "JDA36200",
                    "JDA36225",
                    "JDA36250"

                });
            }
            else if (opc == "I.T.M., HDL 3 POLOS c/Zapatas")
            {
                cbSerie.Items.AddRange(new object[] {
                "HDL36050",
                "HDL36060",
                "HDL36070",
                "HDL36100",
                "HDL36125",
                "HDL36150"

                });
            }
            else if (opc == "I.T.M., JDL 3 POLOS c/Zapatas")
            {
                cbSerie.Items.AddRange(new object[] {
                "JDL36200",
                "JDL36225"
                });
            }
        }


        private void capacidad_voltaje(string nombre, string serie)
        {
            string consulta = $@"SELECT capacidad_a,
            voltaje from itm where nombre='{nombre}' and serie = '{serie}'";

            DataTable resultados = DbUtils.ExecuteQuery(consulta);


            if (resultados.Rows.Count > 0)
            {
                // Extraer el primer resultado
                lblVoltaje.Visible = true;
                DataRow fila = resultados.Rows[0];

                // Asignar los valores a los Labels
                //lblCapacidad.Text = fila["capacidad_a"].ToString();
                lblVoltaje.Text = "Voltaje: " +(fila["voltaje"].ToString()) + "     Capacidad: " + (fila["capacidad_a"].ToString());

            }
            else
            {
                // Manejar el caso cuando no se encuentran resultados
                
                lblVoltaje.Text = "No encontrado";
            }
        }



    
        private void cbSerie_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Dictionary<string, string> capacidades = new Dictionary <string, string>();
            //capacidades.Add("1x16A", "6kA 400V");

            string nombre = cbTipoITM.Text;
            string serie = cbSerie.Text;
                //capacidad_voltaje(nombre, serie);
            capacidad_voltaje(nombre, serie);
            



        }

        private void lblVoltaje_Click(object sender, EventArgs e)
        {
            
        }
    }
}
