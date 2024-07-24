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
    public partial class Cople : Form
    {
        public Cople()
        {
            InitializeComponent();
        }

        private void cbTipoITM_SelectedIndexChanged(object sender, EventArgs e)
        {

            cbMedida.Items.Clear();
            if (cbTipoCople.Text == "Cople FoGa P/Delgada")
            {
                cbMedida.Items.AddRange(new object[]
                {
                    "1/2",
                    "3/4",
                    "1",
                    "1 1/4",
                    "1 1/2",
                    "2"

                });



            }else if (cbTipoCople.Text == "Cople p/Tubo conduit PVC pesado")
            {
                cbMedida.Items.AddRange(new object[] {
                "1/2",
                "3/4",                 
                "1 1/4",
                 "2"

                });

            }
        }
    }
}
