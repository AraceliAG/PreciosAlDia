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
    public partial class Conectores : Form
    {
        public Conectores()
        {
            InitializeComponent();
        }

        private void cbMedida_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbModelo.Items.Clear();
            cbModelo.Text = " ";

            if (cbModelo.Text == "")
            {
                cbMedida.Items.AddRange(new object[]
                {


                });

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

        }

        private void cbTipoTapa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoConector.Text == "Conector FoGa P/Delgada")
            {
                visible();

            }
        }
    }
}
