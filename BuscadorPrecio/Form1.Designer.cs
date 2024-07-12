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
            panelInicio = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnElectrico = new Button();
            btnFoto = new Button();
            btnConstruccion = new Button();
            btnTornilleria = new Button();
            tnFerreteria = new Button();
            lblFecha = new Label();
            lblHora = new Label();
            timerHyF = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            flowLCompras = new FlowLayoutPanel();
            panelInicio.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelInicio
            // 
            panelInicio.BackColor = SystemColors.ActiveCaptionText;
            panelInicio.Controls.Add(flowLayoutPanel2);
            panelInicio.Controls.Add(lblFecha);
            panelInicio.Controls.Add(lblHora);
            panelInicio.Location = new Point(-1, 1);
            panelInicio.Name = "panelInicio";
            panelInicio.Size = new Size(1902, 104);
            panelInicio.TabIndex = 8;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = SystemColors.ActiveCaptionText;
            flowLayoutPanel2.Controls.Add(btnElectrico);
            flowLayoutPanel2.Controls.Add(btnFoto);
            flowLayoutPanel2.Controls.Add(btnConstruccion);
            flowLayoutPanel2.Controls.Add(btnTornilleria);
            flowLayoutPanel2.Controls.Add(tnFerreteria);
            flowLayoutPanel2.Location = new Point(513, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(977, 101);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // btnElectrico
            // 
            btnElectrico.BackColor = SystemColors.ActiveCaption;
            btnElectrico.Font = new Font("Yu Gothic UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnElectrico.Location = new Point(3, 3);
            btnElectrico.Name = "btnElectrico";
            btnElectrico.Size = new Size(189, 95);
            btnElectrico.TabIndex = 0;
            btnElectrico.Text = "Material Electrico";
            btnElectrico.UseVisualStyleBackColor = false;
            btnElectrico.Click += btnElectrico_Click;
            // 
            // btnFoto
            // 
            btnFoto.BackColor = SystemColors.ActiveCaption;
            btnFoto.Font = new Font("Yu Gothic UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnFoto.Location = new Point(198, 3);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(189, 95);
            btnFoto.TabIndex = 1;
            btnFoto.Text = "Material Fotovoltaico";
            btnFoto.UseVisualStyleBackColor = false;
            btnFoto.Click += btnFoto_Click;
            // 
            // btnConstruccion
            // 
            btnConstruccion.BackColor = SystemColors.ActiveCaption;
            btnConstruccion.Font = new Font("Yu Gothic UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnConstruccion.Location = new Point(393, 3);
            btnConstruccion.Name = "btnConstruccion";
            btnConstruccion.Size = new Size(189, 95);
            btnConstruccion.TabIndex = 2;
            btnConstruccion.Text = "Material de Construcción";
            btnConstruccion.UseVisualStyleBackColor = false;
            btnConstruccion.Click += btnConstruccion_Click;
            // 
            // btnTornilleria
            // 
            btnTornilleria.BackColor = SystemColors.ActiveCaption;
            btnTornilleria.Font = new Font("Yu Gothic UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnTornilleria.Location = new Point(588, 3);
            btnTornilleria.Name = "btnTornilleria";
            btnTornilleria.Size = new Size(189, 95);
            btnTornilleria.TabIndex = 3;
            btnTornilleria.Text = "Tornillería";
            btnTornilleria.UseVisualStyleBackColor = false;
            btnTornilleria.Click += btnTornilleria_Click;
            // 
            // tnFerreteria
            // 
            tnFerreteria.BackColor = SystemColors.ActiveCaption;
            tnFerreteria.Font = new Font("Yu Gothic UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            tnFerreteria.Location = new Point(783, 3);
            tnFerreteria.Name = "tnFerreteria";
            tnFerreteria.Size = new Size(189, 95);
            tnFerreteria.TabIndex = 4;
            tnFerreteria.Text = "Ferretería";
            tnFerreteria.UseVisualStyleBackColor = false;
            tnFerreteria.Click += tnFerreteria_Click;
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
            // panel1
            // 
            panel1.Location = new Point(12, 114);
            panel1.Name = "panel1";
            panel1.Size = new Size(1630, 898);
            panel1.TabIndex = 10;
            // 
            // flowLCompras
            // 
            flowLCompras.BackColor = SystemColors.ActiveCaption;
            flowLCompras.Location = new Point(1648, 104);
            flowLCompras.Name = "flowLCompras";
            flowLCompras.Size = new Size(238, 908);
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
            Controls.Add(panelInicio);
            Name = "Form1";
            Text = "Inicio";
            Load += Form1_Load;
            panelInicio.ResumeLayout(false);
            panelInicio.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelInicio;
        private Label lblHora;
        private Label lblFecha;
        private System.Windows.Forms.Timer timerHyF;
        private Panel panel1;
        private FlowLayoutPanel flowLCompras;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnElectrico;
        private Button btnFoto;
        private Button btnConstruccion;
        private Button btnTornilleria;
        private Button tnFerreteria;
    }
}