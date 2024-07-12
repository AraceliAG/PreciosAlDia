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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btBuscarPrecio
            // 
            btBuscarPrecio.BackColor = SystemColors.ActiveCaption;
            btBuscarPrecio.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btBuscarPrecio.Location = new Point(108, 226);
            btBuscarPrecio.Name = "btBuscarPrecio";
            btBuscarPrecio.Size = new Size(181, 42);
            btBuscarPrecio.TabIndex = 22;
            btBuscarPrecio.Text = "Buscar";
            btBuscarPrecio.UseVisualStyleBackColor = false;
            btBuscarPrecio.Visible = false;
            btBuscarPrecio.Click += btBuscarPrecio_Click;
            // 
            // cbMarca
            // 
            cbMarca.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbMarca.FormattingEnabled = true;
            cbMarca.Items.AddRange(new object[] { "Todos", "ANCLO" });
            cbMarca.Location = new Point(108, 170);
            cbMarca.Name = "cbMarca";
            cbMarca.Size = new Size(181, 40);
            cbMarca.TabIndex = 21;
            cbMarca.Visible = false;
            // 
            // cbMedidaMili
            // 
            cbMedidaMili.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbMedidaMili.FormattingEnabled = true;
            cbMedidaMili.Items.AddRange(new object[] { "16 mm", "21 mm", "27 mm", "35 mm", "41 mm", "53 mm", "63 mm", "78 mm" });
            cbMedidaMili.Location = new Point(108, 128);
            cbMedidaMili.Name = "cbMedidaMili";
            cbMedidaMili.Size = new Size(181, 40);
            cbMedidaMili.TabIndex = 20;
            cbMedidaMili.Visible = false;
            // 
            // cbCalibre
            // 
            cbCalibre.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbCalibre.FormattingEnabled = true;
            cbCalibre.Items.AddRange(new object[] { "1/2\"", "3/4\"", "1\"", "1 1/4\"", "1 1/2\"", "2\"", "2 1/2\"", "3\"" });
            cbCalibre.Location = new Point(108, 83);
            cbCalibre.Name = "cbCalibre";
            cbCalibre.Size = new Size(181, 40);
            cbCalibre.TabIndex = 19;
            cbCalibre.Visible = false;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMarca.Location = new Point(12, 173);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(79, 32);
            lblMarca.TabIndex = 18;
            lblMarca.Text = "Marca";
            lblMarca.Visible = false;
            // 
            // lblMedida
            // 
            lblMedida.AutoSize = true;
            lblMedida.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMedida.Location = new Point(12, 131);
            lblMedida.Name = "lblMedida";
            lblMedida.Size = new Size(95, 32);
            lblMedida.TabIndex = 17;
            lblMedida.Text = "Medida";
            lblMedida.Visible = false;
            // 
            // lblCalibre
            // 
            lblCalibre.AutoSize = true;
            lblCalibre.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCalibre.Location = new Point(12, 83);
            lblCalibre.Name = "lblCalibre";
            lblCalibre.Size = new Size(88, 32);
            lblCalibre.TabIndex = 16;
            lblCalibre.Text = "Calibre";
            lblCalibre.Visible = false;
            // 
            // btAbrzaderdaUnical
            // 
            btAbrzaderdaUnical.BackColor = SystemColors.ActiveCaption;
            btAbrzaderdaUnical.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btAbrzaderdaUnical.Location = new Point(82, 24);
            btAbrzaderdaUnical.Name = "btAbrzaderdaUnical";
            btAbrzaderdaUnical.Size = new Size(242, 51);
            btAbrzaderdaUnical.TabIndex = 24;
            btAbrzaderdaUnical.Text = "Abrazadera Unical";
            btAbrzaderdaUnical.UseVisualStyleBackColor = false;
            btAbrzaderdaUnical.Click += btAbrzaderdaUnical_Click;
            // 
            // btnAbrazaderaOmega
            // 
            btnAbrazaderaOmega.BackColor = SystemColors.ActiveCaption;
            btnAbrazaderaOmega.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAbrazaderaOmega.Location = new Point(372, 24);
            btnAbrazaderaOmega.Name = "btnAbrazaderaOmega";
            btnAbrazaderaOmega.Size = new Size(235, 51);
            btnAbrazaderaOmega.TabIndex = 32;
            btnAbrazaderaOmega.Text = "Abrazadra Omega";
            btnAbrazaderaOmega.UseVisualStyleBackColor = false;
            btnAbrazaderaOmega.Click += btnAbrazaderaOmega_Click;
            // 
            // btnBucarO
            // 
            btnBucarO.BackColor = SystemColors.ActiveCaption;
            btnBucarO.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBucarO.Location = new Point(401, 226);
            btnBucarO.Name = "btnBucarO";
            btnBucarO.Size = new Size(178, 42);
            btnBucarO.TabIndex = 31;
            btnBucarO.Text = "Buscar";
            btnBucarO.UseVisualStyleBackColor = false;
            btnBucarO.Visible = false;
            btnBucarO.Click += btnBucarO_Click;
            // 
            // cbMarcaOmega
            // 
            cbMarcaOmega.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbMarcaOmega.FormattingEnabled = true;
            cbMarcaOmega.Items.AddRange(new object[] { "Todos", "ANCLO" });
            cbMarcaOmega.Location = new Point(401, 170);
            cbMarcaOmega.Name = "cbMarcaOmega";
            cbMarcaOmega.Size = new Size(178, 40);
            cbMarcaOmega.TabIndex = 30;
            cbMarcaOmega.Visible = false;
            // 
            // cbCalibreOmega
            // 
            cbCalibreOmega.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbCalibreOmega.FormattingEnabled = true;
            cbCalibreOmega.Items.AddRange(new object[] { "1/2\"", "3/4\"", "1\"", "1 1/4\"", "1 1/2\"", "2\"" });
            cbCalibreOmega.Location = new Point(401, 83);
            cbCalibreOmega.Name = "cbCalibreOmega";
            cbCalibreOmega.Size = new Size(178, 40);
            cbCalibreOmega.TabIndex = 28;
            cbCalibreOmega.Visible = false;
            // 
            // lblMarcaO
            // 
            lblMarcaO.AutoSize = true;
            lblMarcaO.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMarcaO.Location = new Point(307, 173);
            lblMarcaO.Name = "lblMarcaO";
            lblMarcaO.Size = new Size(79, 32);
            lblMarcaO.TabIndex = 27;
            lblMarcaO.Text = "Marca";
            lblMarcaO.Visible = false;
            // 
            // lblCalibreO
            // 
            lblCalibreO.AutoSize = true;
            lblCalibreO.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCalibreO.Location = new Point(307, 91);
            lblCalibreO.Name = "lblCalibreO";
            lblCalibreO.Size = new Size(88, 32);
            lblCalibreO.TabIndex = 25;
            lblCalibreO.Text = "Calibre";
            lblCalibreO.Visible = false;
            // 
            // btnAbrazaderaPera
            // 
            btnAbrazaderaPera.BackColor = SystemColors.ActiveCaption;
            btnAbrazaderaPera.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAbrazaderaPera.Location = new Point(706, 24);
            btnAbrazaderaPera.Name = "btnAbrazaderaPera";
            btnAbrazaderaPera.Size = new Size(240, 51);
            btnAbrazaderaPera.TabIndex = 40;
            btnAbrazaderaPera.Text = "Abrazadera tipo Pera";
            btnAbrazaderaPera.UseVisualStyleBackColor = false;
            btnAbrazaderaPera.Click += btnAbrazaderaPera_Click;
            // 
            // btnBuscarP
            // 
            btnBuscarP.BackColor = SystemColors.ActiveCaption;
            btnBuscarP.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscarP.Location = new Point(731, 226);
            btnBuscarP.Name = "btnBuscarP";
            btnBuscarP.Size = new Size(190, 42);
            btnBuscarP.TabIndex = 39;
            btnBuscarP.Text = "Buscar";
            btnBuscarP.UseVisualStyleBackColor = false;
            btnBuscarP.Visible = false;
            btnBuscarP.Click += btnBuscarP_Click;
            // 
            // cbMarcaPera
            // 
            cbMarcaPera.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbMarcaPera.FormattingEnabled = true;
            cbMarcaPera.Items.AddRange(new object[] { "Todos", "ANCLO" });
            cbMarcaPera.Location = new Point(731, 170);
            cbMarcaPera.Name = "cbMarcaPera";
            cbMarcaPera.Size = new Size(190, 40);
            cbMarcaPera.TabIndex = 38;
            cbMarcaPera.Visible = false;
            // 
            // cbCalibrePera
            // 
            cbCalibrePera.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbCalibrePera.FormattingEnabled = true;
            cbCalibrePera.Items.AddRange(new object[] { "1/2\"", "1/2\"", "3/4\"", "3/4\"", "1\"", "1\"", "1 1/4\"" });
            cbCalibrePera.Location = new Point(731, 83);
            cbCalibrePera.Name = "cbCalibrePera";
            cbCalibrePera.Size = new Size(190, 40);
            cbCalibrePera.TabIndex = 36;
            cbCalibrePera.Visible = false;
            // 
            // lblMarcaP
            // 
            lblMarcaP.AutoSize = true;
            lblMarcaP.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMarcaP.Location = new Point(641, 170);
            lblMarcaP.Name = "lblMarcaP";
            lblMarcaP.Size = new Size(79, 32);
            lblMarcaP.TabIndex = 35;
            lblMarcaP.Text = "Marca";
            lblMarcaP.Visible = false;
            // 
            // lblCalibreP
            // 
            lblCalibreP.AutoSize = true;
            lblCalibreP.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCalibreP.Location = new Point(641, 86);
            lblCalibreP.Name = "lblCalibreP";
            lblCalibreP.Size = new Size(88, 32);
            lblCalibreP.TabIndex = 33;
            lblCalibreP.Text = "Calibre";
            lblCalibreP.Visible = false;
            // 
            // cbMedidaOmega
            // 
            cbMedidaOmega.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbMedidaOmega.FormattingEnabled = true;
            cbMedidaOmega.Items.AddRange(new object[] { "IMC" });
            cbMedidaOmega.Location = new Point(401, 128);
            cbMedidaOmega.Name = "cbMedidaOmega";
            cbMedidaOmega.Size = new Size(178, 40);
            cbMedidaOmega.TabIndex = 29;
            cbMedidaOmega.Visible = false;
            // 
            // lblMedidaP
            // 
            lblMedidaP.AutoSize = true;
            lblMedidaP.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMedidaP.Location = new Point(635, 131);
            lblMedidaP.Name = "lblMedidaP";
            lblMedidaP.Size = new Size(95, 32);
            lblMedidaP.TabIndex = 34;
            lblMedidaP.Text = "Medida";
            lblMedidaP.Visible = false;
            // 
            // cbMedidaPera
            // 
            cbMedidaPera.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbMedidaPera.FormattingEnabled = true;
            cbMedidaPera.Items.AddRange(new object[] { "IMC" });
            cbMedidaPera.Location = new Point(731, 128);
            cbMedidaPera.Name = "cbMedidaPera";
            cbMedidaPera.Size = new Size(190, 40);
            cbMedidaPera.TabIndex = 37;
            cbMedidaPera.Visible = false;
            // 
            // lblMedidaO
            // 
            lblMedidaO.AutoSize = true;
            lblMedidaO.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMedidaO.Location = new Point(305, 131);
            lblMedidaO.Name = "lblMedidaO";
            lblMedidaO.Size = new Size(95, 32);
            lblMedidaO.TabIndex = 26;
            lblMedidaO.Text = "Medida";
            lblMedidaO.Visible = false;
            // 
            // btnFinalizar
            // 
            btnFinalizar.BackColor = SystemColors.ActiveCaption;
            btnFinalizar.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFinalizar.Location = new Point(1075, 226);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(182, 42);
            btnFinalizar.TabIndex = 48;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = false;
            btnFinalizar.Visible = false;
            // 
            // btnAgregarGlobal
            // 
            btnAgregarGlobal.BackColor = SystemColors.ActiveCaption;
            btnAgregarGlobal.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarGlobal.Location = new Point(1075, 26);
            btnAgregarGlobal.Name = "btnAgregarGlobal";
            btnAgregarGlobal.Size = new Size(186, 47);
            btnAgregarGlobal.TabIndex = 47;
            btnAgregarGlobal.Text = "Agregar";
            btnAgregarGlobal.UseVisualStyleBackColor = false;
            btnAgregarGlobal.Click += btnAgregarGlobal_Click;
            // 
            // txtPrecioGlobal
            // 
            txtPrecioGlobal.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecioGlobal.Location = new Point(1075, 86);
            txtPrecioGlobal.Name = "txtPrecioGlobal";
            txtPrecioGlobal.Size = new Size(182, 39);
            txtPrecioGlobal.TabIndex = 46;
            txtPrecioGlobal.Visible = false;
            // 
            // dtpFechaGlobal
            // 
            dtpFechaGlobal.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFechaGlobal.Format = DateTimePickerFormat.Short;
            dtpFechaGlobal.Location = new Point(1075, 172);
            dtpFechaGlobal.Name = "dtpFechaGlobal";
            dtpFechaGlobal.Size = new Size(180, 39);
            dtpFechaGlobal.TabIndex = 45;
            dtpFechaGlobal.Visible = false;
            // 
            // cbProveedorGlobal
            // 
            cbProveedorGlobal.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbProveedorGlobal.FormattingEnabled = true;
            cbProveedorGlobal.Location = new Point(1075, 128);
            cbProveedorGlobal.Name = "cbProveedorGlobal";
            cbProveedorGlobal.Size = new Size(182, 40);
            cbProveedorGlobal.TabIndex = 44;
            cbProveedorGlobal.Visible = false;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.Location = new Point(962, 173);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(75, 32);
            lblFecha.TabIndex = 43;
            lblFecha.Text = "Fecha";
            lblFecha.Visible = false;
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblProveedor.Location = new Point(958, 131);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(123, 32);
            lblProveedor.TabIndex = 42;
            lblProveedor.Text = "Proveedor";
            lblProveedor.Visible = false;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecio.Location = new Point(958, 86);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(79, 32);
            lblPrecio.TabIndex = 41;
            lblPrecio.Text = "Precio";
            lblPrecio.Visible = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
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
            dataGridView1.Location = new Point(108, 300);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle3.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(869, 326);
            dataGridView1.TabIndex = 49;
            // 
            // Abrazadera
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1365, 652);
            Controls.Add(dataGridView1);
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
        private DataGridView dataGridView1;
    }
}