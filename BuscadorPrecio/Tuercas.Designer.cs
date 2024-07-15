namespace BuscadorPrecio
{
    partial class Tuercas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btBuscarPrecio = new Button();
            cbMarca = new ComboBox();
            cbMedida = new ComboBox();
            cbTipo = new ComboBox();
            lblMarca = new Label();
            lblCaracteristica = new Label();
            lblTipo = new Label();
            SuspendLayout();
            // 
            // btBuscarPrecio
            // 
            btBuscarPrecio.BackColor = SystemColors.ActiveCaption;
            btBuscarPrecio.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btBuscarPrecio.Location = new Point(194, 174);
            btBuscarPrecio.Name = "btBuscarPrecio";
            btBuscarPrecio.Size = new Size(212, 56);
            btBuscarPrecio.TabIndex = 21;
            btBuscarPrecio.Text = "Buscar";
            btBuscarPrecio.UseVisualStyleBackColor = false;
            btBuscarPrecio.Click += btBuscarPrecio_Click;
            // 
            // cbMarca
            // 
            cbMarca.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbMarca.FormattingEnabled = true;
            cbMarca.Items.AddRange(new object[] { "Todos", "N/A", "ANCLO" });
            cbMarca.Location = new Point(194, 126);
            cbMarca.Name = "cbMarca";
            cbMarca.Size = new Size(212, 40);
            cbMarca.TabIndex = 20;
            // 
            // cbMedida
            // 
            cbMedida.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbMedida.FormattingEnabled = true;
            cbMedida.Items.AddRange(new object[] { "1/4\"", "3/8\"" });
            cbMedida.Location = new Point(194, 85);
            cbMedida.Name = "cbMedida";
            cbMedida.Size = new Size(212, 40);
            cbMedida.TabIndex = 19;
            // 
            // cbTipo
            // 
            cbTipo.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbTipo.FormattingEnabled = true;
            cbTipo.Items.AddRange(new object[] { "Tuerca p/unicanal", "Tuerca COPLE", "Tuerca hexagonal, galvanizada", "Tuerca hexagonal, inoxidable", "Tuerca inserto de nylon, inoxidable" });
            cbTipo.Location = new Point(194, 42);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(335, 40);
            cbTipo.TabIndex = 18;
            cbTipo.SelectedIndexChanged += cbCalibre_SelectedIndexChanged;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMarca.Location = new Point(34, 129);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(79, 32);
            lblMarca.TabIndex = 17;
            lblMarca.Text = "Marca";
            // 
            // lblCaracteristica
            // 
            lblCaracteristica.AutoSize = true;
            lblCaracteristica.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaracteristica.Location = new Point(34, 88);
            lblCaracteristica.Name = "lblCaracteristica";
            lblCaracteristica.Size = new Size(95, 32);
            lblCaracteristica.TabIndex = 16;
            lblCaracteristica.Text = "Medida";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipo.Location = new Point(34, 45);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(61, 32);
            lblTipo.TabIndex = 15;
            lblTipo.Text = "Tipo";
            // 
            // Tuercas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1268, 595);
            Controls.Add(btBuscarPrecio);
            Controls.Add(cbMarca);
            Controls.Add(cbMedida);
            Controls.Add(cbTipo);
            Controls.Add(lblMarca);
            Controls.Add(lblCaracteristica);
            Controls.Add(lblTipo);
            Name = "Tuercas";
            Text = "Tuercas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btBuscarPrecio;
        private ComboBox cbMarca;
        private ComboBox cbMedida;
        private ComboBox cbTipo;
        private Label lblMarca;
        private Label lblCaracteristica;
        private Label lblTipo;
    }
}