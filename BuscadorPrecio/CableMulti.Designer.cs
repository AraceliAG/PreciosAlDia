namespace BuscadorPrecio
{
    partial class CableMulti
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
            dataGridView1 = new DataGridView();
            btBuscarPrecio = new Button();
            cbMarca = new ComboBox();
            cbCaracyteristica = new ComboBox();
            cbCalibre = new ComboBox();
            lblMarca = new Label();
            lblCaracteristica = new Label();
            lblCalibre = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 203);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(850, 225);
            dataGridView1.TabIndex = 15;
            // 
            // btBuscarPrecio
            // 
            btBuscarPrecio.Location = new Point(122, 148);
            btBuscarPrecio.Name = "btBuscarPrecio";
            btBuscarPrecio.Size = new Size(212, 34);
            btBuscarPrecio.TabIndex = 14;
            btBuscarPrecio.Text = "Buscar";
            btBuscarPrecio.UseVisualStyleBackColor = true;
            // 
            // cbMarca
            // 
            cbMarca.FormattingEnabled = true;
            cbMarca.Items.AddRange(new object[] { "Todos", "VIAKON" });
            cbMarca.Location = new Point(122, 109);
            cbMarca.Name = "cbMarca";
            cbMarca.Size = new Size(212, 33);
            cbMarca.TabIndex = 13;
            // 
            // cbCaracyteristica
            // 
            cbCaracyteristica.FormattingEnabled = true;
            cbCaracyteristica.Items.AddRange(new object[] { "Rollo Metálico 76.2m", "Métalico" });
            cbCaracyteristica.Location = new Point(122, 71);
            cbCaracyteristica.Name = "cbCaracyteristica";
            cbCaracyteristica.Size = new Size(212, 33);
            cbCaracyteristica.TabIndex = 12;
            // 
            // cbCalibre
            // 
            cbCalibre.FormattingEnabled = true;
            cbCalibre.Items.AddRange(new object[] { "2x14 + T", "3x14 + T", "4x14 + T", "2x6 + T", "3x6 + T", "4x6+ T", "2x14 + T" });
            cbCalibre.Location = new Point(122, 24);
            cbCalibre.Name = "cbCalibre";
            cbCalibre.Size = new Size(212, 33);
            cbCalibre.TabIndex = 11;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(33, 112);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(60, 25);
            lblMarca.TabIndex = 10;
            lblMarca.Text = "Marca";
            // 
            // lblCaracteristica
            // 
            lblCaracteristica.AutoSize = true;
            lblCaracteristica.Location = new Point(12, 71);
            lblCaracteristica.Name = "lblCaracteristica";
            lblCaracteristica.Size = new Size(115, 25);
            lblCaracteristica.TabIndex = 9;
            lblCaracteristica.Text = "Característica";
            // 
            // lblCalibre
            // 
            lblCalibre.AutoSize = true;
            lblCalibre.Location = new Point(32, 20);
            lblCalibre.Name = "lblCalibre";
            lblCalibre.Size = new Size(66, 25);
            lblCalibre.TabIndex = 8;
            lblCalibre.Text = "Calibre";
            // 
            // CableMulti
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btBuscarPrecio);
            Controls.Add(cbMarca);
            Controls.Add(cbCaracyteristica);
            Controls.Add(cbCalibre);
            Controls.Add(lblMarca);
            Controls.Add(lblCaracteristica);
            Controls.Add(lblCalibre);
            Name = "CableMulti";
            Text = "CableMulti";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btBuscarPrecio;
        private ComboBox cbMarca;
        private ComboBox cbCaracyteristica;
        private ComboBox cbCalibre;
        private Label lblMarca;
        private Label lblCaracteristica;
        private Label lblCalibre;
    }
}