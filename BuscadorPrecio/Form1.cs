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
            dataGridView1.DataSource = resultados;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cbCables.Visible = true;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string tipo = cbCables.Text;
            if (tipo == "Cable Cu. THHW-LS, 90°C, 600V, Cal.")
            {
                Form ventanaCableTH = new Form2();
                ventanaCableTH.Show();

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
    }
}