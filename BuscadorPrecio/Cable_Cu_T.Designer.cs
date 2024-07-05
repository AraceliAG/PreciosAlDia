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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblCalibre = new Label();
            lblColor = new Label();
            lblMarca = new Label();
            cbCalibre = new ComboBox();
            cbColor = new ComboBox();
            cbMarca = new ComboBox();
            btBuscarPrecio = new Button();
            dataGridView1 = new DataGridView();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblCalibre
            // 
            lblCalibre.AutoSize = true;
            lblCalibre.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCalibre.Location = new Point(23, 94);
            lblCalibre.Name = "lblCalibre";
            lblCalibre.Size = new Size(88, 32);
            lblCalibre.TabIndex = 0;
            lblCalibre.Text = "Calibre";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblColor.Location = new Point(23, 149);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(71, 32);
            lblColor.TabIndex = 1;
            lblColor.Text = "Color";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMarca.Location = new Point(23, 192);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(79, 32);
            lblMarca.TabIndex = 2;
            lblMarca.Text = "Marca";
            // 
            // cbCalibre
            // 
            cbCalibre.FormattingEnabled = true;
            cbCalibre.Items.AddRange(new object[] { "4", "2", "6", "8", "12", "10", "14", "1/0", "2/0", "3/0", "4/0", "" });
            cbCalibre.Location = new Point(118, 97);
            cbCalibre.Name = "cbCalibre";
            cbCalibre.Size = new Size(230, 33);
            cbCalibre.TabIndex = 3;
            // 
            // cbColor
            // 
            cbColor.FormattingEnabled = true;
            cbColor.Items.AddRange(new object[] { "BLANCO", "NEGRO", "ROJO", "VERDE", "AZUL" });
            cbColor.Location = new Point(118, 148);
            cbColor.Name = "cbColor";
            cbColor.Size = new Size(230, 33);
            cbColor.TabIndex = 4;
            // 
            // cbMarca
            // 
            cbMarca.FormattingEnabled = true;
            cbMarca.Items.AddRange(new object[] { "Todos", "Condulac", "Condumex", "Viakon" });
            cbMarca.Location = new Point(118, 192);
            cbMarca.Name = "cbMarca";
            cbMarca.Size = new Size(230, 33);
            cbMarca.TabIndex = 5;
            // 
            // btBuscarPrecio
            // 
            btBuscarPrecio.BackColor = Color.Yellow;
            btBuscarPrecio.Font = new Font("Yu Gothic UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btBuscarPrecio.Image = (Image)resources.GetObject("btBuscarPrecio.Image");
            btBuscarPrecio.ImageAlign = ContentAlignment.TopCenter;
            btBuscarPrecio.Location = new Point(148, 247);
            btBuscarPrecio.Name = "btBuscarPrecio";
            btBuscarPrecio.Size = new Size(162, 60);
            btBuscarPrecio.TabIndex = 6;
            btBuscarPrecio.Text = "Buscar";
            btBuscarPrecio.TextAlign = ContentAlignment.BottomCenter;
            btBuscarPrecio.UseVisualStyleBackColor = false;
            btBuscarPrecio.Click += btBuscarPrecio_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Info;
            dataGridViewCellStyle2.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.GridColor = Color.FromArgb(255, 128, 0);
            dataGridView1.Location = new Point(28, 346);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(952, 261);
            dataGridView1.TabIndex = 7;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1129, 761);
            Controls.Add(dataGridView1);
            Controls.Add(btBuscarPrecio);
            Controls.Add(cbMarca);
            Controls.Add(cbColor);
            Controls.Add(cbCalibre);
            Controls.Add(lblMarca);
            Controls.Add(lblColor);
            Controls.Add(lblCalibre);
            Name = "Form2";
            Text = "Cable Cu. THHW-LS";
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
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}