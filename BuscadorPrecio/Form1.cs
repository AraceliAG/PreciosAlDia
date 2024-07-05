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

        private void btnIniciar_Click(object sender, EventArgs e)
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
                default:
                    MessageBox.Show("Seleccione un tipo de cable válido.");
                    return;
            }

            AbrirVentana(formToOpen);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form insercion = new Insercion();
            insercion.Show();
        }

        private void timerHyF_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void btSoportaria_Click(object sender, EventArgs e)
        {
            cbSoporteria.Visible = true;
            btIniciarSup.Visible = true;

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Form ventanaAgregar = new Agregar();
            AbrirVentana(ventanaAgregar);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void btIniciarSup_Click(object sender, EventArgs e)
        {
            string tipo = cbSoporteria.Text;
            Form formToOpen = null;

            switch (tipo)
            {
                case "Abrazadera unicanal":
                    formToOpen = new Abrazadera();
                    break;
                default:
                    MessageBox.Show("Vuelve a intentarlo");
                    return;
            }

            AbrirVentana(formToOpen);
        }

    

      
    }
}