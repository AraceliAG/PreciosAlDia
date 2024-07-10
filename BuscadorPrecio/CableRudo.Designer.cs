namespace BuscadorPrecio
{
    partial class CableRudo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CableRudo));
            btBuscarPrecio = new Button();
            cbMarca = new ComboBox();
            cbCalibre = new ComboBox();
            lblMarca = new Label();
            lblCalibre = new Label();
            dataGridView1 = new DataGridView();
            btnFinalizar = new Button();
            bynAgregarGlobal = new Button();
            txtPrecioGlobal = new TextBox();
            dtpFechaGlobal = new DateTimePicker();
            cbProveedorGlobal = new ComboBox();
            lblFecha = new Label();
            lblProveedor = new Label();
            lblPrecio = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btBuscarPrecio
            // 
            btBuscarPrecio.BackColor = SystemColors.ActiveCaption;
            btBuscarPrecio.BackgroundImage = (Image)resources.GetObject("btBuscarPrecio.BackgroundImage");
            btBuscarPrecio.BackgroundImageLayout = ImageLayout.Center;
            btBuscarPrecio.Location = new Point(145, 164);
            btBuscarPrecio.Name = "btBuscarPrecio";
            btBuscarPrecio.Size = new Size(156, 67);
            btBuscarPrecio.TabIndex = 13;
            btBuscarPrecio.Text = "Buscar";
            btBuscarPrecio.TextAlign = ContentAlignment.BottomCenter;
            btBuscarPrecio.UseVisualStyleBackColor = false;
            btBuscarPrecio.Click += btBuscarPrecio_Click;
            // 
            // cbMarca
            // 
            cbMarca.FormattingEnabled = true;
            cbMarca.Items.AddRange(new object[] { "Todos", "CONDULAC", "INDIANA" });
            cbMarca.Location = new Point(120, 106);
            cbMarca.Name = "cbMarca";
            cbMarca.Size = new Size(212, 33);
            cbMarca.TabIndex = 12;
            // 
            // cbCalibre
            // 
            cbCalibre.FormattingEnabled = true;
            cbCalibre.Items.AddRange(new object[] { "2x14", "3x16", "3x14", "3x12", "3x10", "3x8", "4x12", "4x10", "4x8" });
            cbCalibre.Location = new Point(120, 51);
            cbCalibre.Name = "cbCalibre";
            cbCalibre.Size = new Size(212, 33);
            cbCalibre.TabIndex = 10;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(30, 109);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(60, 25);
            lblMarca.TabIndex = 9;
            lblMarca.Text = "Marca";
            // 
            // lblCalibre
            // 
            lblCalibre.AutoSize = true;
            lblCalibre.Location = new Point(30, 47);
            lblCalibre.Name = "lblCalibre";
            lblCalibre.Size = new Size(66, 25);
            lblCalibre.TabIndex = 7;
            lblCalibre.Text = "Calibre";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 260);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(703, 225);
            dataGridView1.TabIndex = 14;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(366, 164);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(299, 33);
            btnFinalizar.TabIndex = 32;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Visible = false;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // bynAgregarGlobal
            // 
            bynAgregarGlobal.Location = new Point(755, 41);
            bynAgregarGlobal.Name = "bynAgregarGlobal";
            bynAgregarGlobal.Size = new Size(145, 70);
            bynAgregarGlobal.TabIndex = 31;
            bynAgregarGlobal.Text = "Agregar último precio";
            bynAgregarGlobal.UseVisualStyleBackColor = true;
            bynAgregarGlobal.Click += bynAgregarGlobal_Click;
            // 
            // txtPrecioGlobal
            // 
            txtPrecioGlobal.Location = new Point(483, 41);
            txtPrecioGlobal.Name = "txtPrecioGlobal";
            txtPrecioGlobal.Size = new Size(182, 31);
            txtPrecioGlobal.TabIndex = 30;
            txtPrecioGlobal.Visible = false;
            // 
            // dtpFechaGlobal
            // 
            dtpFechaGlobal.Format = DateTimePickerFormat.Short;
            dtpFechaGlobal.Location = new Point(483, 127);
            dtpFechaGlobal.Name = "dtpFechaGlobal";
            dtpFechaGlobal.Size = new Size(180, 31);
            dtpFechaGlobal.TabIndex = 29;
            dtpFechaGlobal.Visible = false;
            // 
            // cbProveedorGlobal
            // 
            cbProveedorGlobal.FormattingEnabled = true;
            cbProveedorGlobal.Location = new Point(483, 86);
            cbProveedorGlobal.Name = "cbProveedorGlobal";
            cbProveedorGlobal.Size = new Size(182, 33);
            cbProveedorGlobal.TabIndex = 28;
            cbProveedorGlobal.Visible = false;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(366, 132);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(57, 25);
            lblFecha.TabIndex = 27;
            lblFecha.Text = "Fecha";
            lblFecha.Visible = false;
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Location = new Point(366, 86);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(94, 25);
            lblProveedor.TabIndex = 26;
            lblProveedor.Text = "Proveedor";
            lblProveedor.Visible = false;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(366, 41);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(60, 25);
            lblPrecio.TabIndex = 25;
            lblPrecio.Text = "Precio";
            lblPrecio.Visible = false;
            // 
            // CableRudo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 509);
            Controls.Add(btnFinalizar);
            Controls.Add(bynAgregarGlobal);
            Controls.Add(txtPrecioGlobal);
            Controls.Add(dtpFechaGlobal);
            Controls.Add(cbProveedorGlobal);
            Controls.Add(lblFecha);
            Controls.Add(lblProveedor);
            Controls.Add(lblPrecio);
            Controls.Add(dataGridView1);
            Controls.Add(btBuscarPrecio);
            Controls.Add(cbMarca);
            Controls.Add(cbCalibre);
            Controls.Add(lblMarca);
            Controls.Add(lblCalibre);
            Name = "CableRudo";
            Text = "CableRudo";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btBuscarPrecio;
        private ComboBox cbMarca;
        private ComboBox cbCalibre;
        private Label lblMarca;
        private Label lblCalibre;
        private DataGridView dataGridView1;
        private Button btnFinalizar;
        private Button bynAgregarGlobal;
        private TextBox txtPrecioGlobal;
        private DateTimePicker dtpFechaGlobal;
        private ComboBox cbProveedorGlobal;
        private Label lblFecha;
        private Label lblProveedor;
        private Label lblPrecio;
    }
}