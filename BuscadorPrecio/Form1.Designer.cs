namespace BuscadorPrecio
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnCables = new Button();
            cbCables = new ComboBox();
            btnIniciar = new Button();
            btSoportaria = new Button();
            cbSoporteria = new ComboBox();
            btIniciarSup = new Button();
            panelInicio = new Panel();
            btnSalir = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnAgregar = new Button();
            lblFecha = new Label();
            lblHora = new Label();
            timerHyF = new System.Windows.Forms.Timer(components);
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            flowLCompras = new FlowLayoutPanel();
            panelInicio.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCables
            // 
            btnCables.BackColor = SystemColors.ActiveCaption;
            btnCables.BackgroundImage = (Image)resources.GetObject("btnCables.BackgroundImage");
            btnCables.BackgroundImageLayout = ImageLayout.Zoom;
            btnCables.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCables.Location = new Point(3, 3);
            btnCables.Name = "btnCables";
            btnCables.Size = new Size(297, 105);
            btnCables.TabIndex = 2;
            btnCables.Text = "Cables";
            btnCables.TextAlign = ContentAlignment.BottomCenter;
            btnCables.UseVisualStyleBackColor = false;
            btnCables.Click += button2_Click;
            // 
            // cbCables
            // 
            cbCables.Font = new Font("Yu Gothic UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbCables.FormattingEnabled = true;
            cbCables.Items.AddRange(new object[] { "Cable Cu. THHW-LS, 90°C, 600V, Cal.", "Cable multiconductor de alambre Cu ARMORFLEX", "Cable de uso rudo THHW", "Cable Cu. Desnudo, semiduro, Cal." });
            cbCables.Location = new Point(3, 114);
            cbCables.Name = "cbCables";
            cbCables.Size = new Size(297, 36);
            cbCables.TabIndex = 3;
            cbCables.Visible = false;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = SystemColors.ActiveCaption;
            btnIniciar.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnIniciar.Location = new Point(3, 156);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(297, 41);
            btnIniciar.TabIndex = 4;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Visible = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btSoportaria
            // 
            btSoportaria.BackColor = SystemColors.ActiveCaption;
            btSoportaria.BackgroundImage = (Image)resources.GetObject("btSoportaria.BackgroundImage");
            btSoportaria.BackgroundImageLayout = ImageLayout.Center;
            btSoportaria.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btSoportaria.Location = new Point(3, 203);
            btSoportaria.Name = "btSoportaria";
            btSoportaria.Size = new Size(297, 105);
            btSoportaria.TabIndex = 5;
            btSoportaria.Text = "Soportería";
            btSoportaria.TextAlign = ContentAlignment.BottomCenter;
            btSoportaria.UseVisualStyleBackColor = false;
            btSoportaria.Click += btSoportaria_Click;
            // 
            // cbSoporteria
            // 
            cbSoporteria.Font = new Font("Yu Gothic UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbSoporteria.FormattingEnabled = true;
            cbSoporteria.Items.AddRange(new object[] { "Abrazaderas", "Tuercas", "Soportes", "Unicanal galvanizado" });
            cbSoporteria.Location = new Point(3, 314);
            cbSoporteria.Name = "cbSoporteria";
            cbSoporteria.Size = new Size(297, 36);
            cbSoporteria.TabIndex = 6;
            cbSoporteria.Visible = false;
            // 
            // btIniciarSup
            // 
            btIniciarSup.BackColor = SystemColors.ActiveCaption;
            btIniciarSup.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btIniciarSup.Location = new Point(3, 356);
            btIniciarSup.Name = "btIniciarSup";
            btIniciarSup.Size = new Size(297, 41);
            btIniciarSup.TabIndex = 7;
            btIniciarSup.Text = "Iniciar";
            btIniciarSup.UseVisualStyleBackColor = false;
            btIniciarSup.Visible = false;
            btIniciarSup.Click += btIniciarSup_Click;
            // 
            // panelInicio
            // 
            panelInicio.BackColor = SystemColors.ActiveCaptionText;
            panelInicio.Controls.Add(btnSalir);
            panelInicio.Controls.Add(btnEliminar);
            panelInicio.Controls.Add(btnActualizar);
            panelInicio.Controls.Add(btnAgregar);
            panelInicio.Controls.Add(lblFecha);
            panelInicio.Controls.Add(lblHora);
            panelInicio.Location = new Point(-1, 1);
            panelInicio.Name = "panelInicio";
            panelInicio.Size = new Size(1902, 104);
            panelInicio.TabIndex = 8;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ActiveCaption;
            btnSalir.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.Location = new Point(1332, 11);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(166, 83);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Visible = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.ActiveCaption;
            btnEliminar.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.Location = new Point(1073, 11);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(166, 83);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.ActiveCaption;
            btnActualizar.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnActualizar.Location = new Point(812, 11);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(166, 83);
            btnActualizar.TabIndex = 4;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.ActiveCaption;
            btnAgregar.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.Location = new Point(546, 11);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(166, 83);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblFecha.ForeColor = SystemColors.ControlLightLight;
            lblFecha.Location = new Point(22, 28);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(62, 48);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "---";
            lblFecha.Click += lblFecha_Click;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblHora.ForeColor = SystemColors.ControlLightLight;
            lblHora.Location = new Point(1526, 28);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(62, 48);
            lblHora.TabIndex = 0;
            lblHora.Text = "---";
            // 
            // timerHyF
            // 
            timerHyF.Enabled = true;
            timerHyF.Tick += timerHyF_Tick;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaptionText;
            flowLayoutPanel1.Controls.Add(btnCables);
            flowLayoutPanel1.Controls.Add(cbCables);
            flowLayoutPanel1.Controls.Add(btnIniciar);
            flowLayoutPanel1.Controls.Add(btSoportaria);
            flowLayoutPanel1.Controls.Add(cbSoporteria);
            flowLayoutPanel1.Controls.Add(btIniciarSup);
            flowLayoutPanel1.Location = new Point(-1, 111);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(300, 910);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.Location = new Point(305, 114);
            panel1.Name = "panel1";
            panel1.Size = new Size(1337, 841);
            panel1.TabIndex = 10;
            // 
            // flowLCompras
            // 
            flowLCompras.BackColor = SystemColors.ActiveCaption;
            flowLCompras.Location = new Point(1648, 114);
            flowLCompras.Name = "flowLCompras";
            flowLCompras.Size = new Size(238, 898);
            flowLCompras.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1898, 1024);
            Controls.Add(flowLCompras);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panelInicio);
            Name = "Form1";
            Text = "Inicio";
            Load += Form1_Load;
            panelInicio.ResumeLayout(false);
            panelInicio.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnCables;
        private ComboBox cbCables;
        private Button btnIniciar;
        private Button btSoportaria;
        private ComboBox cbSoporteria;
        private Button btIniciarSup;
        private Panel panelInicio;
        private Label lblHora;
        private Label lblFecha;
        private System.Windows.Forms.Timer timerHyF;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private FlowLayoutPanel flowLCompras;
        private Button btnEliminar;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnSalir;
    }
}