namespace BuscadorPrecio
{
    partial class Abrazadera
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
            cbMedidaMili = new ComboBox();
            cbCalibre = new ComboBox();
            lblMarca = new Label();
            lblMedida = new Label();
            lblCalibre = new Label();
            btAbrzaderdaUnical = new Button();
            btnAbrazaderaOmega = new Button();
            btnBucarO = new Button();
            cbMarcaOmega = new ComboBox();
            cbCalibreOmega = new ComboBox();
            lblMarcaO = new Label();
            lblCalibreO = new Label();
            btnAbrazaderaPera = new Button();
            btnBuscarP = new Button();
            cbMarcaPera = new ComboBox();
            cbCalibrePera = new ComboBox();
            lblMarcaP = new Label();
            lblCalibreP = new Label();
            cbMedidaOmega = new ComboBox();
            lblMedidaP = new Label();
            cbMedidaPera = new ComboBox();
            lblMedidaO = new Label();
            btnFinalizar = new Button();
            btnAgregarGlobal = new Button();
            txtPrecioGlobal = new TextBox();
            dtpFechaGlobal = new DateTimePicker();
            cbProveedorGlobal = new ComboBox();
            lblFecha = new Label();
            lblProveedor = new Label();
            lblPrecio = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 304);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(689, 225);
            dataGridView1.TabIndex = 23;
            // 
            // btBuscarPrecio
            // 
            btBuscarPrecio.Location = new Point(108, 209);
            btBuscarPrecio.Name = "btBuscarPrecio";
            btBuscarPrecio.Size = new Size(150, 34);
            btBuscarPrecio.TabIndex = 22;
            btBuscarPrecio.Text = "Buscar";
            btBuscarPrecio.UseVisualStyleBackColor = true;
            btBuscarPrecio.Visible = false;
            btBuscarPrecio.Click += btBuscarPrecio_Click;
            // 
            // cbMarca
            // 
            cbMarca.FormattingEnabled = true;
            cbMarca.Items.AddRange(new object[] { "Todos", "ANCLO" });
            cbMarca.Location = new Point(108, 170);
            cbMarca.Name = "cbMarca";
            cbMarca.Size = new Size(150, 33);
            cbMarca.TabIndex = 21;
            cbMarca.Visible = false;
            // 
            // cbMedidaMili
            // 
            cbMedidaMili.FormattingEnabled = true;
            cbMedidaMili.Items.AddRange(new object[] { "16 mm", "21 mm", "27 mm", "35 mm", "41 mm", "53 mm", "63 mm", "78 mm" });
            cbMedidaMili.Location = new Point(108, 131);
            cbMedidaMili.Name = "cbMedidaMili";
            cbMedidaMili.Size = new Size(150, 33);
            cbMedidaMili.TabIndex = 20;
            cbMedidaMili.Visible = false;
            // 
            // cbCalibre
            // 
            cbCalibre.FormattingEnabled = true;
            cbCalibre.Items.AddRange(new object[] { "1/2\"", "3/4\"", "1\"", "1 1/4\"", "1 1/2\"", "2\"", "2 1/2\"", "3\"" });
            cbCalibre.Location = new Point(108, 83);
            cbCalibre.Name = "cbCalibre";
            cbCalibre.Size = new Size(150, 33);
            cbCalibre.TabIndex = 19;
            cbCalibre.Visible = false;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(18, 170);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(60, 25);
            lblMarca.TabIndex = 18;
            lblMarca.Text = "Marca";
            lblMarca.Visible = false;
            // 
            // lblMedida
            // 
            lblMedida.AutoSize = true;
            lblMedida.Location = new Point(12, 131);
            lblMedida.Name = "lblMedida";
            lblMedida.Size = new Size(72, 25);
            lblMedida.TabIndex = 17;
            lblMedida.Text = "Medida";
            lblMedida.Visible = false;
            // 
            // lblCalibre
            // 
            lblCalibre.AutoSize = true;
            lblCalibre.Location = new Point(18, 86);
            lblCalibre.Name = "lblCalibre";
            lblCalibre.Size = new Size(66, 25);
            lblCalibre.TabIndex = 16;
            lblCalibre.Text = "Calibre";
            lblCalibre.Visible = false;
            // 
            // btAbrzaderdaUnical
            // 
            btAbrzaderdaUnical.Location = new Point(84, 32);
            btAbrzaderdaUnical.Name = "btAbrzaderdaUnical";
            btAbrzaderdaUnical.Size = new Size(212, 34);
            btAbrzaderdaUnical.TabIndex = 24;
            btAbrzaderdaUnical.Text = "Abrazadera Unical";
            btAbrzaderdaUnical.UseVisualStyleBackColor = true;
            btAbrzaderdaUnical.Click += btAbrzaderdaUnical_Click;
            // 
            // btnAbrazaderaOmega
            // 
            btnAbrazaderaOmega.Location = new Point(377, 32);
            btnAbrazaderaOmega.Name = "btnAbrazaderaOmega";
            btnAbrazaderaOmega.Size = new Size(212, 34);
            btnAbrazaderaOmega.TabIndex = 32;
            btnAbrazaderaOmega.Text = "Abrazadra Omega";
            btnAbrazaderaOmega.UseVisualStyleBackColor = true;
            btnAbrazaderaOmega.Click += btnAbrazaderaOmega_Click;
            // 
            // btnBucarO
            // 
            btnBucarO.Location = new Point(401, 209);
            btnBucarO.Name = "btnBucarO";
            btnBucarO.Size = new Size(150, 34);
            btnBucarO.TabIndex = 31;
            btnBucarO.Text = "Buscar";
            btnBucarO.UseVisualStyleBackColor = true;
            btnBucarO.Visible = false;
            btnBucarO.Click += btnBucarO_Click;
            // 
            // cbMarcaOmega
            // 
            cbMarcaOmega.FormattingEnabled = true;
            cbMarcaOmega.Items.AddRange(new object[] { "Todos", "ANCLO" });
            cbMarcaOmega.Location = new Point(401, 170);
            cbMarcaOmega.Name = "cbMarcaOmega";
            cbMarcaOmega.Size = new Size(150, 33);
            cbMarcaOmega.TabIndex = 30;
            cbMarcaOmega.Visible = false;
            // 
            // cbCalibreOmega
            // 
            cbCalibreOmega.FormattingEnabled = true;
            cbCalibreOmega.Items.AddRange(new object[] { "1/2\"", "3/4\"", "1\"", "1 1/4\"", "1 1/2\"", "2\"" });
            cbCalibreOmega.Location = new Point(401, 83);
            cbCalibreOmega.Name = "cbCalibreOmega";
            cbCalibreOmega.Size = new Size(150, 33);
            cbCalibreOmega.TabIndex = 28;
            cbCalibreOmega.Visible = false;
            // 
            // lblMarcaO
            // 
            lblMarcaO.AutoSize = true;
            lblMarcaO.Location = new Point(311, 170);
            lblMarcaO.Name = "lblMarcaO";
            lblMarcaO.Size = new Size(60, 25);
            lblMarcaO.TabIndex = 27;
            lblMarcaO.Text = "Marca";
            lblMarcaO.Visible = false;
            // 
            // lblCalibreO
            // 
            lblCalibreO.AutoSize = true;
            lblCalibreO.Location = new Point(311, 86);
            lblCalibreO.Name = "lblCalibreO";
            lblCalibreO.Size = new Size(66, 25);
            lblCalibreO.TabIndex = 25;
            lblCalibreO.Text = "Calibre";
            lblCalibreO.Visible = false;
            // 
            // btnAbrazaderaPera
            // 
            btnAbrazaderaPera.Location = new Point(707, 32);
            btnAbrazaderaPera.Name = "btnAbrazaderaPera";
            btnAbrazaderaPera.Size = new Size(212, 34);
            btnAbrazaderaPera.TabIndex = 40;
            btnAbrazaderaPera.Text = "Abrazadera tipo Pera";
            btnAbrazaderaPera.UseVisualStyleBackColor = true;
            btnAbrazaderaPera.Click += btnAbrazaderaPera_Click;
            // 
            // btnBuscarP
            // 
            btnBuscarP.Location = new Point(731, 209);
            btnBuscarP.Name = "btnBuscarP";
            btnBuscarP.Size = new Size(150, 34);
            btnBuscarP.TabIndex = 39;
            btnBuscarP.Text = "Buscar";
            btnBuscarP.UseVisualStyleBackColor = true;
            btnBuscarP.Visible = false;
            btnBuscarP.Click += btnBuscarP_Click;
            // 
            // cbMarcaPera
            // 
            cbMarcaPera.FormattingEnabled = true;
            cbMarcaPera.Items.AddRange(new object[] { "Todos", "ANCLO" });
            cbMarcaPera.Location = new Point(731, 170);
            cbMarcaPera.Name = "cbMarcaPera";
            cbMarcaPera.Size = new Size(150, 33);
            cbMarcaPera.TabIndex = 38;
            cbMarcaPera.Visible = false;
            // 
            // cbCalibrePera
            // 
            cbCalibrePera.FormattingEnabled = true;
            cbCalibrePera.Items.AddRange(new object[] { "1/2\"", "1/2\"", "3/4\"", "3/4\"", "1\"", "1\"", "1 1/4\"" });
            cbCalibrePera.Location = new Point(731, 83);
            cbCalibrePera.Name = "cbCalibrePera";
            cbCalibrePera.Size = new Size(150, 33);
            cbCalibrePera.TabIndex = 36;
            cbCalibrePera.Visible = false;
            // 
            // lblMarcaP
            // 
            lblMarcaP.AutoSize = true;
            lblMarcaP.Location = new Point(641, 170);
            lblMarcaP.Name = "lblMarcaP";
            lblMarcaP.Size = new Size(60, 25);
            lblMarcaP.TabIndex = 35;
            lblMarcaP.Text = "Marca";
            lblMarcaP.Visible = false;
            // 
            // lblCalibreP
            // 
            lblCalibreP.AutoSize = true;
            lblCalibreP.Location = new Point(641, 86);
            lblCalibreP.Name = "lblCalibreP";
            lblCalibreP.Size = new Size(66, 25);
            lblCalibreP.TabIndex = 33;
            lblCalibreP.Text = "Calibre";
            lblCalibreP.Visible = false;
            // 
            // cbMedidaOmega
            // 
            cbMedidaOmega.FormattingEnabled = true;
            cbMedidaOmega.Items.AddRange(new object[] { "IMC" });
            cbMedidaOmega.Location = new Point(401, 131);
            cbMedidaOmega.Name = "cbMedidaOmega";
            cbMedidaOmega.Size = new Size(150, 33);
            cbMedidaOmega.TabIndex = 29;
            cbMedidaOmega.Visible = false;
            // 
            // lblMedidaP
            // 
            lblMedidaP.AutoSize = true;
            lblMedidaP.Location = new Point(635, 131);
            lblMedidaP.Name = "lblMedidaP";
            lblMedidaP.Size = new Size(72, 25);
            lblMedidaP.TabIndex = 34;
            lblMedidaP.Text = "Medida";
            lblMedidaP.Visible = false;
            // 
            // cbMedidaPera
            // 
            cbMedidaPera.FormattingEnabled = true;
            cbMedidaPera.Items.AddRange(new object[] { "IMC" });
            cbMedidaPera.Location = new Point(731, 131);
            cbMedidaPera.Name = "cbMedidaPera";
            cbMedidaPera.Size = new Size(150, 33);
            cbMedidaPera.TabIndex = 37;
            cbMedidaPera.Visible = false;
            // 
            // lblMedidaO
            // 
            lblMedidaO.AutoSize = true;
            lblMedidaO.Location = new Point(305, 131);
            lblMedidaO.Name = "lblMedidaO";
            lblMedidaO.Size = new Size(72, 25);
            lblMedidaO.TabIndex = 26;
            lblMedidaO.Text = "Medida";
            lblMedidaO.Visible = false;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(958, 209);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(299, 33);
            btnFinalizar.TabIndex = 48;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Visible = false;
            // 
            // btnAgregarGlobal
            // 
            btnAgregarGlobal.Location = new Point(1075, 33);
            btnAgregarGlobal.Name = "btnAgregarGlobal";
            btnAgregarGlobal.Size = new Size(140, 33);
            btnAgregarGlobal.TabIndex = 47;
            btnAgregarGlobal.Text = "Agregar";
            btnAgregarGlobal.UseVisualStyleBackColor = true;
            btnAgregarGlobal.Click += btnAgregarGlobal_Click;
            // 
            // txtPrecioGlobal
            // 
            txtPrecioGlobal.Location = new Point(1075, 86);
            txtPrecioGlobal.Name = "txtPrecioGlobal";
            txtPrecioGlobal.Size = new Size(182, 31);
            txtPrecioGlobal.TabIndex = 46;
            txtPrecioGlobal.Visible = false;
            // 
            // dtpFechaGlobal
            // 
            dtpFechaGlobal.Format = DateTimePickerFormat.Short;
            dtpFechaGlobal.Location = new Point(1075, 172);
            dtpFechaGlobal.Name = "dtpFechaGlobal";
            dtpFechaGlobal.Size = new Size(180, 31);
            dtpFechaGlobal.TabIndex = 45;
            dtpFechaGlobal.Visible = false;
            // 
            // cbProveedorGlobal
            // 
            cbProveedorGlobal.FormattingEnabled = true;
            cbProveedorGlobal.Location = new Point(1075, 131);
            cbProveedorGlobal.Name = "cbProveedorGlobal";
            cbProveedorGlobal.Size = new Size(182, 33);
            cbProveedorGlobal.TabIndex = 44;
            cbProveedorGlobal.Visible = false;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(958, 177);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(57, 25);
            lblFecha.TabIndex = 43;
            lblFecha.Text = "Fecha";
            lblFecha.Visible = false;
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Location = new Point(958, 131);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(94, 25);
            lblProveedor.TabIndex = 42;
            lblProveedor.Text = "Proveedor";
            lblProveedor.Visible = false;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(958, 86);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(60, 25);
            lblPrecio.TabIndex = 41;
            lblPrecio.Text = "Precio";
            lblPrecio.Visible = false;
            // 
            // Abrazadera
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 583);
            Controls.Add(btnFinalizar);
            Controls.Add(btnAgregarGlobal);
            Controls.Add(txtPrecioGlobal);
            Controls.Add(dtpFechaGlobal);
            Controls.Add(cbProveedorGlobal);
            Controls.Add(lblFecha);
            Controls.Add(lblProveedor);
            Controls.Add(lblPrecio);
            Controls.Add(btnAbrazaderaPera);
            Controls.Add(btnBuscarP);
            Controls.Add(cbMarcaPera);
            Controls.Add(cbMedidaPera);
            Controls.Add(cbCalibrePera);
            Controls.Add(lblMarcaP);
            Controls.Add(lblMedidaP);
            Controls.Add(lblCalibreP);
            Controls.Add(btnAbrazaderaOmega);
            Controls.Add(btnBucarO);
            Controls.Add(cbMarcaOmega);
            Controls.Add(cbMedidaOmega);
            Controls.Add(cbCalibreOmega);
            Controls.Add(lblMarcaO);
            Controls.Add(lblMedidaO);
            Controls.Add(lblCalibreO);
            Controls.Add(btAbrzaderdaUnical);
            Controls.Add(dataGridView1);
            Controls.Add(btBuscarPrecio);
            Controls.Add(cbMarca);
            Controls.Add(cbMedidaMili);
            Controls.Add(cbCalibre);
            Controls.Add(lblMarca);
            Controls.Add(lblMedida);
            Controls.Add(lblCalibre);
            Name = "Abrazadera";
            Text = "Abrazadera";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btBuscarPrecio;
        private ComboBox cbMarca;
        private ComboBox cbMedidaMili;
        private ComboBox cbCalibre;
        private Label lblMarca;
        private Label lblMedida;
        private Label lblCalibre;
        private Button btAbrzaderdaUnical;
        private Button btnAbrazaderaOmega;
        private Button btnBucarO;
        private ComboBox cbMarcaOmega;
        private ComboBox cbCalibreOmega;
        private Label lblMarcaO;
        private Label lblCalibreO;
        private Button btnAbrazaderaPera;
        private Button btnBuscarP;
        private ComboBox cbMarcaPera;
        private ComboBox cbCalibrePera;
        private Label lblMarcaP;
        private Label lblCalibreP;
        private ComboBox cbMedidaOmega;
        private Label lblMedidaP;
        private ComboBox cbMedidaPera;
        private Label lblMedidaO;
        private Button btnFinalizar;
        private Button btnAgregarGlobal;
        private TextBox txtPrecioGlobal;
        private DateTimePicker dtpFechaGlobal;
        private ComboBox cbProveedorGlobal;
        private Label lblFecha;
        private Label lblProveedor;
        private Label lblPrecio;
    }
}