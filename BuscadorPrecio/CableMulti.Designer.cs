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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            btnFinalizar = new Button();
            btnCancelar = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btBuscarPrecio
            // 
            btBuscarPrecio.BackColor = SystemColors.ActiveCaption;
            btBuscarPrecio.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btBuscarPrecio.Location = new Point(172, 157);
            btBuscarPrecio.Name = "btBuscarPrecio";
            btBuscarPrecio.Size = new Size(212, 56);
            btBuscarPrecio.TabIndex = 14;
            btBuscarPrecio.Text = "Buscar";
            btBuscarPrecio.UseVisualStyleBackColor = false;
            btBuscarPrecio.Click += btBuscarPrecio_Click;
            // 
            // cbMarca
            // 
            cbMarca.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbMarca.FormattingEnabled = true;
            cbMarca.Items.AddRange(new object[] { "Todos", "VIAKON" });
            cbMarca.Location = new Point(172, 109);
            cbMarca.Name = "cbMarca";
            cbMarca.Size = new Size(212, 40);
            cbMarca.TabIndex = 13;
            cbMarca.SelectedIndexChanged += cbMarca_SelectedIndexChanged;
            // 
            // cbCaracyteristica
            // 
            cbCaracyteristica.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbCaracyteristica.FormattingEnabled = true;
            cbCaracyteristica.Items.AddRange(new object[] { "Rollo Metálico 76.2m", "Métalico" });
            cbCaracyteristica.Location = new Point(172, 68);
            cbCaracyteristica.Name = "cbCaracyteristica";
            cbCaracyteristica.Size = new Size(212, 40);
            cbCaracyteristica.TabIndex = 12;
            cbCaracyteristica.SelectedIndexChanged += cbCaracyteristica_SelectedIndexChanged;
            // 
            // cbCalibre
            // 
            cbCalibre.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbCalibre.FormattingEnabled = true;
            cbCalibre.Items.AddRange(new object[] { "2x14 + T", "3x14 + T", "4x14 + T", "2x6 + T", "3x6 + T", "4x6+ T", "2x14 + T" });
            cbCalibre.Location = new Point(172, 25);
            cbCalibre.Name = "cbCalibre";
            cbCalibre.Size = new Size(212, 40);
            cbCalibre.TabIndex = 11;
            cbCalibre.SelectedIndexChanged += cbCalibre_SelectedIndexChanged;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMarca.Location = new Point(12, 112);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(79, 32);
            lblMarca.TabIndex = 10;
            lblMarca.Text = "Marca";
            lblMarca.Click += lblMarca_Click;
            // 
            // lblCaracteristica
            // 
            lblCaracteristica.AutoSize = true;
            lblCaracteristica.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaracteristica.Location = new Point(12, 71);
            lblCaracteristica.Name = "lblCaracteristica";
            lblCaracteristica.Size = new Size(154, 32);
            lblCaracteristica.TabIndex = 9;
            lblCaracteristica.Text = "Característica";
            lblCaracteristica.Click += lblCaracteristica_Click;
            // 
            // lblCalibre
            // 
            lblCalibre.AutoSize = true;
            lblCalibre.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCalibre.Location = new Point(12, 28);
            lblCalibre.Name = "lblCalibre";
            lblCalibre.Size = new Size(88, 32);
            lblCalibre.TabIndex = 8;
            lblCalibre.Text = "Calibre";
            lblCalibre.Click += lblCalibre_Click;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecio.Location = new Point(443, 28);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(79, 32);
            lblPrecio.TabIndex = 16;
            lblPrecio.Text = "Precio";
            lblPrecio.Visible = false;
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblProveedor.Location = new Point(443, 71);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(123, 32);
            lblProveedor.TabIndex = 17;
            lblProveedor.Text = "Proveedor";
            lblProveedor.Visible = false;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.Location = new Point(447, 112);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(75, 32);
            lblFecha.TabIndex = 18;
            lblFecha.Text = "Fecha";
            lblFecha.Visible = false;
            // 
            // cbProveedorGlobal
            // 
            cbProveedorGlobal.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbProveedorGlobal.FormattingEnabled = true;
            cbProveedorGlobal.Items.AddRange(new object[] { "DIMEGSA", "ELEKTRON" });
            cbProveedorGlobal.Location = new Point(577, 71);
            cbProveedorGlobal.Name = "cbProveedorGlobal";
            cbProveedorGlobal.Size = new Size(196, 40);
            cbProveedorGlobal.TabIndex = 20;
            cbProveedorGlobal.Visible = false;
            // 
            // dtpFechaGlobal
            // 
            dtpFechaGlobal.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFechaGlobal.Format = DateTimePickerFormat.Short;
            dtpFechaGlobal.Location = new Point(577, 112);
            dtpFechaGlobal.Name = "dtpFechaGlobal";
            dtpFechaGlobal.Size = new Size(196, 39);
            dtpFechaGlobal.TabIndex = 21;
            dtpFechaGlobal.Visible = false;
            dtpFechaGlobal.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // txtPrecioGlobal
            // 
            txtPrecioGlobal.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecioGlobal.Location = new Point(575, 28);
            txtPrecioGlobal.Name = "txtPrecioGlobal";
            txtPrecioGlobal.Size = new Size(198, 39);
            txtPrecioGlobal.TabIndex = 22;
            txtPrecioGlobal.Visible = false;
            // 
            // bynAgregarGlobal
            // 
            bynAgregarGlobal.BackColor = SystemColors.ActiveCaption;
            bynAgregarGlobal.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bynAgregarGlobal.Location = new Point(827, 28);
            bynAgregarGlobal.Name = "bynAgregarGlobal";
            bynAgregarGlobal.Size = new Size(178, 55);
            bynAgregarGlobal.TabIndex = 23;
            bynAgregarGlobal.Text = "Agregar último precio";
            bynAgregarGlobal.UseVisualStyleBackColor = false;
            bynAgregarGlobal.Click += bynAgregarGlobal_Click;
            // 
            // btnFinalizar
            // 
            btnFinalizar.BackColor = SystemColors.ActiveCaption;
            btnFinalizar.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFinalizar.Location = new Point(575, 157);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(198, 56);
            btnFinalizar.TabIndex = 24;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = false;
            btnFinalizar.Visible = false;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ActiveCaption;
            btnCancelar.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(827, 98);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(178, 61);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
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
            dataGridView1.Location = new Point(65, 235);
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
            dataGridView1.TabIndex = 26;
            // 
            // CableMulti
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 606);
            Controls.Add(dataGridView1);
            Controls.Add(btnCancelar);
            Controls.Add(btnFinalizar);
            Controls.Add(bynAgregarGlobal);
            Controls.Add(txtPrecioGlobal);
            Controls.Add(dtpFechaGlobal);
            Controls.Add(cbProveedorGlobal);
            Controls.Add(lblFecha);
            Controls.Add(lblProveedor);
            Controls.Add(lblPrecio);
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
        private Button btnFinalizar;
        private Button btnCancelar;
        private DataGridView dataGridView1;
    }
}