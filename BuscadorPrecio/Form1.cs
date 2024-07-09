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

        private void ChangeButtonColors(Control parent, Color color)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is Button)
                {
                    control.BackColor = color;
                }
                else if (control.Controls.Count > 0)
                {
                    ChangeButtonColors(control, color);
                }
            }
        }

        private void visibilidadBotones(string name, bool boleano)
        {
            // Iterar sobre los controles dentro del formulario para encontrar el botón
            foreach (Control control in this.Controls)
            {
                // Verificar si el control es un panel
                if (control is Panel)
                {
                    // Iterar sobre los controles dentro del panel
                    foreach (Control innerControl in control.Controls)
                    {
                        // Verificar si el control dentro del panel es un botón y tiene el nombre correcto
                        if (innerControl is Button && innerControl.Name == name)
                        {
                            // Hacer invisible el botón encontrado
                            innerControl.Visible = boleano;
                            // Salir del bucle ya que hemos encontrado y procesado el botón
                            break;
                        }
                    }
                }
            }

        }




        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Form ventanaAgregar = new Agregar();
            //AbrirVentana(ventanaAgregar);
            btnSalir.Visible = true;
            // Cambia el color de fondo de todos los botones a rojo
            ChangeButtonColors(this, Color.Gold);
            flowLCompras.BackColor = Color.Gold;
            visibilidadBotones("btnEliminar", false);
            visibilidadBotones("btnActualizar", false);


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
                case "Abrazaderas":
                    formToOpen = new Abrazadera();
                    break;
                case "Tuercas":
                    formToOpen = new Tuercas();
                    break;
                default:
                    MessageBox.Show("Vuelve a intentarlo");
                    return;
            }

            AbrirVentana(formToOpen);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            ChangeButtonColors(this, Color.FromArgb(153, 180, 209));
            flowLCompras.BackColor = Color.FromArgb(153, 180, 209);
            btnSalir.Visible = false;
            visibilidadBotones("btnEliminar", true);
            visibilidadBotones("btnActualizar", true);
            // Supongamos que tienes una referencia a la ventana externa llamada externalForm
            // Accediendo al formulario externo desde otro formulario





        }
    }
}