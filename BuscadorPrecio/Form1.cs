using System.Data;
using System.Windows.Forms;

namespace BuscadorPrecio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void AbrirVentana(Form form)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(form);
            this.panel1.Tag = form;
            form.Show();
        }
        private void timerHyF_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void btnElectrico_Click(object sender, EventArgs e)
        {
            Form formToOpen;
            formToOpen = new MaterialElectrico();
            AbrirVentana(formToOpen);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            Form ventanaFoto ;
            ventanaFoto = new MaterialFotovoltaico();
            AbrirVentana(ventanaFoto);

        }

        private void btnConstruccion_Click(object sender, EventArgs e)
        {
            Form ventanaCons ;
            ventanaCons = new MaterialConstruccion();
            AbrirVentana(ventanaCons);
        }

        private void btnTornilleria_Click(object sender, EventArgs e)
        {
            Form ventanaTornilleria;
            ventanaTornilleria = new Tornilleria();
            AbrirVentana(ventanaTornilleria);
        }

        private void tnFerreteria_Click(object sender, EventArgs e)
        {
            Form ventanaFerreteria ;
            ventanaFerreteria = new Ferreteria();
            AbrirVentana(ventanaFerreteria);
        }
    }
}