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
    public partial class MaterialElectrico : Form
    {
        public MaterialElectrico()
        {
            InitializeComponent();
        }

        private void btnCables_Click(object sender, EventArgs e)
        {
            cbCables.Visible = true;
        }
        private void AbrirVentana(Form form)
        {
            if (this.panelVista.Controls.Count > 0)
                this.panelVista.Controls.RemoveAt(0);
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.panelVista.Controls.Add(form);
            this.panelVista.Tag = form;
            form.Show();
        }

        private void cbCables_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = cbCables.Text;
            Form formToOpen = null;

            switch (tipo)
            {
                case "Cable Cu. THHW-LS, 90°C, 600V, Cal.":
                    formToOpen = new Form2();
                    break;
                case "Cable multiconductor de alambre Cu ARMORFLEX":
                    formToOpen = new CableMulti();
                    break;
                case "Cable de uso rudo THHW":
                    formToOpen = new CableRudo();
                    break;
                case "Cable Cu. Desnudo, semiduro, Cal.":
                    formToOpen = new cableDesn();
                    break;

            }

            AbrirVentana(formToOpen);
        }

        private void btSoportaria_Click(object sender, EventArgs e)
        {
            cbSoporteria.Visible = true;
        }

        private void cbSoporteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = cbSoporteria.Text;
            Form formToOpen = null;

            switch (tipo)
            {
                case "Abrazaderas":
                    formToOpen = new Abrazadera();
                    break;


            }

            AbrirVentana(formToOpen);

        }
    }
}
