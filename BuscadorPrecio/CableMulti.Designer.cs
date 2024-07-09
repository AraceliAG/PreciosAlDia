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
            lblPrecio = new Label();
            lblProveedor = new Label();
            lblFecha = new Label();
            cbProveedorGlobal = new ComboBox();
            dtpFechaGlobal = new DateTimePicker();
            txtPrecioGlobal = new TextBox();
            bynAgregarGlobal = new Button();
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
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btBuscarPrecio
            // 
            btBuscarPrecio.Location = new Point(122, 148);
            btBuscarPrecio.Name = "btBuscarPrecio";
            btBuscarPrecio.Size = new Size(212, 34);
            btBuscarPrecio.TabIndex = 14;
            btBuscarPrecio.Text = "Buscar";
            btBuscarPrecio.UseVisualStyleBackColor = true;
            btBuscarPrecio.Click += btBuscarPrecio_Click;
            // 
            // cbMarca
            // 
            cbMarca.FormattingEnabled = true;
            cbMarca.Items.AddRange(new object[] { "Todos", "VIAKON" });
            cbMarca.Location = new Point(122, 109);
            cbMarca.Name = "cbMarca";
            cbMarca.Size = new Size(212, 33);
            cbMarca.TabIndex = 13;
            cbMarca.SelectedIndexChanged += cbMarca_SelectedIndexChanged;
            // 
            // cbCaracyteristica
            // 
            cbCaracyteristica.FormattingEnabled = true;
            cbCaracyteristica.Items.AddRange(new object[] { "Rollo Metálico 76.2m", "Métalico" });
            cbCaracyteristica.Location = new Point(122, 71);
            cbCaracyteristica.Name = "cbCaracyteristica";
            cbCaracyteristica.Size = new Size(212, 33);
            cbCaracyteristica.TabIndex = 12;
            cbCaracyteristica.SelectedIndexChanged += cbCaracyteristica_SelectedIndexChanged;
            // 
            // cbCalibre
            // 
            cbCalibre.FormattingEnabled = true;
            cbCalibre.Items.AddRange(new object[] { "2x14 + T", "3x14 + T", "4x14 + T", "2x6 + T", "3x6 + T", "4x6+ T", "2x14 + T" });
            cbCalibre.Location = new Point(122, 24);
            cbCalibre.Name = "cbCalibre";
            cbCalibre.Size = new Size(212, 33);
            cbCalibre.TabIndex = 11;
            cbCalibre.SelectedIndexChanged += cbCalibre_SelectedIndexChanged;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(33, 112);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(60, 25);
            lblMarca.TabIndex = 10;
            lblMarca.Text = "Marca";
            lblMarca.Click += lblMarca_Click;
            // 
            // lblCaracteristica
            // 
            lblCaracteristica.AutoSize = true;
            lblCaracteristica.Location = new Point(12, 71);
            lblCaracteristica.Name = "lblCaracteristica";
            lblCaracteristica.Size = new Size(115, 25);
            lblCaracteristica.TabIndex = 9;
            lblCaracteristica.Text = "Característica";
            lblCaracteristica.Click += lblCaracteristica_Click;
            // 
            // lblCalibre
            // 
            lblCalibre.AutoSize = true;
            lblCalibre.Location = new Point(32, 20);
            lblCalibre.Name = "lblCalibre";
            lblCalibre.Size = new Size(66, 25);
            lblCalibre.TabIndex = 8;
            lblCalibre.Text = "Calibre";
            lblCalibre.Click += lblCalibre_Click;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(374, 26);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(60, 25);
            lblPrecio.TabIndex = 16;
            lblPrecio.Text = "Precio";
            lblPrecio.Visible = false;
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Location = new Point(374, 71);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(94, 25);
            lblProveedor.TabIndex = 17;
            lblProveedor.Text = "Proveedor";
            lblProveedor.Visible = false;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(374, 117);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(57, 25);
            lblFecha.TabIndex = 18;
            lblFecha.Text = "Fecha";
            lblFecha.Visible = false;
            // 
            // cbProveedorGlobal
            // 
            cbProveedorGlobal.FormattingEnabled = true;
            cbProveedorGlobal.Location = new Point(491, 71);
            cbProveedorGlobal.Name = "cbProveedorGlobal";
            cbProveedorGlobal.Size = new Size(182, 33);
            cbProveedorGlobal.TabIndex = 20;
            cbProveedorGlobal.Visible = false;
            // 
            // dtpFechaGlobal
            // 
            dtpFechaGlobal.Format = DateTimePickerFormat.Short;
            dtpFechaGlobal.Location = new Point(491, 112);
            dtpFechaGlobal.Name = "dtpFechaGlobal";
            dtpFechaGlobal.Size = new Size(180, 31);
            dtpFechaGlobal.TabIndex = 21;
            dtpFechaGlobal.Visible = false;
            dtpFechaGlobal.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // txtPrecioGlobal
            // 
            txtPrecioGlobal.Location = new Point(491, 26);
            txtPrecioGlobal.Name = "txtPrecioGlobal";
            txtPrecioGlobal.Size = new Size(182, 31);
            txtPrecioGlobal.TabIndex = 22;
            txtPrecioGlobal.Visible = false;
            // 
            // bynAgregarGlobal
            // 
            bynAgregarGlobal.Location = new Point(386, 149);
            bynAgregarGlobal.Name = "bynAgregarGlobal";
            bynAgregarGlobal.Size = new Size(314, 33);
            bynAgregarGlobal.TabIndex = 23;
            bynAgregarGlobal.Text = "Agregar";
            bynAgregarGlobal.UseVisualStyleBackColor = true;
            bynAgregarGlobal.Visible = false;
            // 
            // CableMulti
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 450);
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
        private Label lblPrecio;
        private Label lblProveedor;
        private Label lblFecha;
        private ComboBox cbProveedorGlobal;
        private DateTimePicker dtpFechaGlobal;
        private TextBox txtPrecioGlobal;
        private Button bynAgregarGlobal;
    }
}