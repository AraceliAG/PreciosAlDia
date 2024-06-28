namespace BuscadorPrecio
{
    partial class Form2
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
            lblCalibre = new Label();
            lblColor = new Label();
            lblMarca = new Label();
            cbCalibre = new ComboBox();
            cbColor = new ComboBox();
            cbMarca = new ComboBox();
            btBuscarPrecio = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblCalibre
            // 
            lblCalibre.AutoSize = true;
            lblCalibre.Location = new Point(28, 64);
            lblCalibre.Name = "lblCalibre";
            lblCalibre.Size = new Size(66, 25);
            lblCalibre.TabIndex = 0;
            lblCalibre.Text = "Calibre";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(28, 115);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(55, 25);
            lblColor.TabIndex = 1;
            lblColor.Text = "Color";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(29, 156);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(60, 25);
            lblMarca.TabIndex = 2;
            lblMarca.Text = "Marca";
            // 
            // cbCalibre
            // 
            cbCalibre.FormattingEnabled = true;
            cbCalibre.Items.AddRange(new object[] { "4", "2", "6", "8", "12", "10", "14", "1/0", "2/0", "3/0", "4/0", "" });
            cbCalibre.Location = new Point(118, 68);
            cbCalibre.Name = "cbCalibre";
            cbCalibre.Size = new Size(212, 33);
            cbCalibre.TabIndex = 3;
            // 
            // cbColor
            // 
            cbColor.FormattingEnabled = true;
            cbColor.Items.AddRange(new object[] { "BLANCO", "NEGRO", "ROJO", "VERDE", "AZUL" });
            cbColor.Location = new Point(118, 115);
            cbColor.Name = "cbColor";
            cbColor.Size = new Size(212, 33);
            cbColor.TabIndex = 4;
            // 
            // cbMarca
            // 
            cbMarca.FormattingEnabled = true;
            cbMarca.Items.AddRange(new object[] { "Todos", "Condulac", "Condumex", "Viakon" });
            cbMarca.Location = new Point(118, 153);
            cbMarca.Name = "cbMarca";
            cbMarca.Size = new Size(212, 33);
            cbMarca.TabIndex = 5;
            // 
            // btBuscarPrecio
            // 
            btBuscarPrecio.Location = new Point(118, 192);
            btBuscarPrecio.Name = "btBuscarPrecio";
            btBuscarPrecio.Size = new Size(212, 34);
            btBuscarPrecio.TabIndex = 6;
            btBuscarPrecio.Text = "Buscar";
            btBuscarPrecio.UseVisualStyleBackColor = true;
            btBuscarPrecio.Click += btBuscarPrecio_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 262);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(850, 225);
            dataGridView1.TabIndex = 7;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 499);
            Controls.Add(dataGridView1);
            Controls.Add(btBuscarPrecio);
            Controls.Add(cbMarca);
            Controls.Add(cbColor);
            Controls.Add(cbCalibre);
            Controls.Add(lblMarca);
            Controls.Add(lblColor);
            Controls.Add(lblCalibre);
            Name = "Form2";
            Text = "Cable_Cu_T";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCalibre;
        private Label lblColor;
        private Label lblMarca;
        private ComboBox cbCalibre;
        private ComboBox cbColor;
        private ComboBox cbMarca;
        private Button btBuscarPrecio;
        private DataGridView dataGridView1;
    }
}