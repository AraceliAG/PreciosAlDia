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
    public partial class Tubería : Form
    {
        public Tubería()
        {
            InitializeComponent();
        }

        private void cbTipoITM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoTubería.Text == "Tubo FoGa, P/Delgada")
            {
                cbMedida.Items.AddRange(new object[]
                {
                    "1/2",
                    "3/4",
                    "1",
                    "1 1/4"
                });
            }
        }
    }
}
