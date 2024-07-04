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

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM cables";
            DataTable resultados = DbUtils.ExecuteQuery(query);

            // Aquí puedes procesar los resultados (por ejemplo, mostrar en un DataGridView)

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cbCables.Visible = true;
            btnIniciar.Visible = true;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string tipo = cbCables.Text;
            if (tipo == "Cable Cu. THHW-LS, 90°C, 600V, Cal.")
            {
                abrirVentanaCableCu(new Form2());

            }
            else if (tipo == "Cable multiconductor de alambre Cu ARMORFLEX")
            {
                Form ventanaCableMulti = new CableMulti();
                ventanaCableMulti.Show();
            }
            else if (tipo == "Cable de uso rudo THHW")
            {
                Form ventanaRudo = new CableRudo();
                ventanaRudo.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form insercion = new Insercion();
            insercion.Show();
        }

        private void timerHyF_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToShortTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void btSoportaria_Click(object sender, EventArgs e)
        {
            cbSoporteria.Visible = true;
            btIniciarSup.Visible = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void abrirVentanaCableCu (object abrirVentanaCableCuu)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form abrirVentanaCu = abrirVentanaCableCuu as Form2;
            abrirVentanaCu.TopLevel = false;
            abrirVentanaCu.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(abrirVentanaCu);
            this.panel1.Tag = abrirVentanaCu;
            abrirVentanaCu.Show();
        }
    }
}