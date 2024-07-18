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
            milimetros(cbMedida.Text);

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
    }
}

