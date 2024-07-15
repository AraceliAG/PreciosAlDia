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

            if (cbTipo.Text == "Tuerca p/unicanal")
            {
                cbMedida.Items.AddRange(new object[]{
                    "1/4",
                    "3/8"
                });
            }
            else if (cbTipo.Text == "Tuerca COPLE")
            {
                cbMedida.Items.AddRange(new object[]{
                    "1/4",
                    "3/8",
                    "1/2"
                });

            }
            else if (cbTipo.Text == "Tuerca hexagonal, inoxidable")
            {
                cbMedida.Items.AddRange(new object[]{
                    "3/8"

                });

            }
            else if (cbTipo.Text == "Tuerca hexagonal, galvanizada")
            {
                cbMedida.Items.AddRange(new object[]{
                    "1/4",
                    "3/8",
                    "1/2"

                });

            }
            else if (cbTipo.Text == "Tuerca inserto de nylon, inoxidable")
            {
                cbMedida.Items.AddRange(new object[]{
                    "3/8 -16"

                });

            }
        }

        private void btBuscarPrecio_Click(object sender, EventArgs e)
        {

        }
    }
}
