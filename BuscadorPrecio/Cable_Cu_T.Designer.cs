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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblCalibre = new Label();
            lblColor = new Label();
            lblMarca = new Label();
            cbCalibre = new ComboBox();
            cbColor = new ComboBox();
            cbMarca = new ComboBox();
            btBuscarPrecio = new Button();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            dataGridView1 = new DataGridView();
            btnFinalizar = new Button();
            btnAgregarGlobal = new Button();
            txtPrecioGlobal = new TextBox();
            dtpFechaGlobal = new DateTimePicker();
            cbProveedorGlobal = new ComboBox();
            lblFecha = new Label();
            lblProveedor = new Label();
            lblPrecio = new Label();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblCalibre
            // 
            lblCalibre.AutoSize = true;
            lblCalibre.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCalibre.Location = new Point(12, 40);
            lblCalibre.Name = "lblCalibre";
            lblCalibre.Size = new Size(88, 32);
            lblCalibre.TabIndex = 0;
            lblCalibre.Text = "Calibre";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblColor.Location = new Point(12, 90);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(71, 32);
            lblColor.TabIndex = 1;
            lblColor.Text = "Color";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMarca.Location = new Point(12, 144);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(79, 32);
            lblMarca.TabIndex = 2;
            lblMarca.Text = "Marca";
            // 
            // cbCalibre
            // 
            cbCalibre.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbCalibre.FormattingEnabled = true;
            cbCalibre.Items.AddRange(new object[] { "4", "2", "6", "8", "12", "10", "14", "1/0", "2/0", "3/0", "4/0", "" });
            cbCalibre.Location = new Point(118, 37);
            cbCalibre.Name = "cbCalibre";
            cbCalibre.Size = new Size(230, 40);
            cbCalibre.TabIndex = 3;
            // 
            // cbColor
            // 
            cbColor.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbColor.FormattingEnabled = true;
            cbColor.Items.AddRange(new object[] { "BLANCO", "NEGRO", "ROJO", "VERDE", "AZUL" });
            cbColor.Location = new Point(118, 89);
            cbColor.Name = "cbColor";
            cbColor.Size = new Size(230, 40);
            cbColor.TabIndex = 4;
            // 
            // cbMarca
            // 
            cbMarca.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbMarca.FormattingEnabled = true;
            cbMarca.Items.AddRange(new object[] { "Todos", "Condulac", "Condumex", "Viakon" });
            cbMarca.Location = new Point(118, 144);
            cbMarca.Name = "cbMarca";
            cbMarca.Size = new Size(230, 40);
            cbMarca.TabIndex = 5;
            // 
            // btBuscarPrecio
            // 
            btBuscarPrecio.BackColor = SystemColors.ActiveCaption;
            btBuscarPrecio.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btBuscarPrecio.Image = (Image)resources.GetObject("btBuscarPrecio.Image");
            btBuscarPrecio.ImageAlign = ContentAlignment.TopCenter;
            btBuscarPrecio.Location = new Point(118, 206);
            btBuscarPrecio.Name = "btBuscarPrecio";
            btBuscarPrecio.Size = new Size(230, 63);
            btBuscarPrecio.TabIndex = 6;
            btBuscarPrecio.Text = "Buscar";
            btBuscarPrecio.TextAlign = ContentAlignment.BottomCenter;
            btBuscarPrecio.UseVisualStyleBackColor = false;
            btBuscarPrecio.Click += btBuscarPrecio_Click;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(32, 295);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle3.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(828, 279);
            dataGridView1.TabIndex = 7;
            // 
            // btnFinalizar
            // 
            btnFinalizar.BackColor = SystemColors.ActiveCaption;
            btnFinalizar.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFinalizar.Location = new Point(577, 190);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(299, 58);
            btnFinalizar.TabIndex = 32;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = false;
            btnFinalizar.Visible = false;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // btnAgregarGlobal
            // 
            btnAgregarGlobal.BackColor = SystemColors.ActiveCaption;
            btnAgregarGlobal.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarGlobal.Location = new Point(907, 34);
            btnAgregarGlobal.Name = "btnAgregarGlobal";
            btnAgregarGlobal.Size = new Size(169, 49);
            btnAgregarGlobal.TabIndex = 31;
            btnAgregarGlobal.Text = "Agregar";
            btnAgregarGlobal.UseVisualStyleBackColor = false;
            btnAgregarGlobal.Click += btnAgregarGlobal_Click;
            // 
            // txtPrecioGlobal
            // 
            txtPrecioGlobal.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecioGlobal.Location = new Point(653, 34);
            txtPrecioGlobal.Name = "txtPrecioGlobal";
            txtPrecioGlobal.Size = new Size(223, 39);
            txtPrecioGlobal.TabIndex = 30;
            txtPrecioGlobal.Visible = false;
            txtPrecioGlobal.TextChanged += txtPrecioGlobal_TextChanged;
            // 
            // dtpFechaGlobal
            // 
            dtpFechaGlobal.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFechaGlobal.Format = DateTimePickerFormat.Short;
            dtpFechaGlobal.Location = new Point(653, 125);
            dtpFechaGlobal.Name = "dtpFechaGlobal";
            dtpFechaGlobal.Size = new Size(221, 39);
            dtpFechaGlobal.TabIndex = 29;
            dtpFechaGlobal.Visible = false;
            dtpFechaGlobal.ValueChanged += dtpFechaGlobal_ValueChanged;
            // 
            // cbProveedorGlobal
            // 
            cbProveedorGlobal.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbProveedorGlobal.FormattingEnabled = true;
            cbProveedorGlobal.Items.AddRange(new object[] { "ECOZA", "DIMEGSA", "ASENCIO" });
            cbProveedorGlobal.Location = new Point(653, 79);
            cbProveedorGlobal.Name = "cbProveedorGlobal";
            cbProveedorGlobal.Size = new Size(223, 40);
            cbProveedorGlobal.TabIndex = 28;
            cbProveedorGlobal.Visible = false;
            cbProveedorGlobal.SelectedIndexChanged += cbProveedorGlobal_SelectedIndexChanged;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.Location = new Point(530, 125);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(75, 32);
            lblFecha.TabIndex = 27;
            lblFecha.Text = "Fecha";
            lblFecha.Visible = false;
            lblFecha.Click += lblFecha_Click;
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblProveedor.Location = new Point(529, 79);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(123, 32);
            lblProveedor.TabIndex = 26;
            lblProveedor.Text = "Proveedor";
            lblProveedor.Visible = false;
            lblProveedor.Click += lblProveedor_Click;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecio.Location = new Point(526, 34);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(79, 32);
            lblPrecio.TabIndex = 25;
            lblPrecio.Text = "Precio";
            lblPrecio.Visible = false;
            lblPrecio.Click += lblPrecio_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ActiveCaption;
            btnCancelar.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(907, 89);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(169, 53);
            btnCancelar.TabIndex = 33;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1365, 652);
            Controls.Add(btnCancelar);
            Controls.Add(btnFinalizar);
            Controls.Add(btnAgregarGlobal);
            Controls.Add(txtPrecioGlobal);
            Controls.Add(dtpFechaGlobal);
            Controls.Add(cbProveedorGlobal);
            Controls.Add(lblFecha);
            Controls.Add(lblProveedor);
            Controls.Add(lblPrecio);
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
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private DataGridView dataGridView1;
        private Button btnFinalizar;
        private Button btnAgregarGlobal;
        private TextBox txtPrecioGlobal;
        private DateTimePicker dtpFechaGlobal;
        private ComboBox cbProveedorGlobal;
        private Label lblFecha;
        private Label lblProveedor;
        private Label lblPrecio;
        private Button btnCancelar;
    }
}