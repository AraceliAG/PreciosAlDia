namespace BuscadorPrecio
{
    partial class cableDesn
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
            cbUnidad = new ComboBox();
            cbCalibre = new ComboBox();
            lblMarca = new Label();
            lblColor = new Label();
            lblCalibre = new Label();
            lblTamanio = new Label();
            cbTamanio = new ComboBox();
            btnFinalizar = new Button();
            bynAgregarGlobal = new Button();
            txtPrecioGlobal = new TextBox();
            dtpFechaGlobal = new DateTimePicker();
            cbProveedorGlobal = new ComboBox();
            lblFecha = new Label();
            lblProveedor = new Label();
            lblPrecio = new Label();
            btnCancelar = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btBuscarPrecio
            // 
            btBuscarPrecio.BackColor = SystemColors.ActiveCaption;
            btBuscarPrecio.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btBuscarPrecio.Location = new Point(120, 177);
            btBuscarPrecio.Name = "btBuscarPrecio";
            btBuscarPrecio.Size = new Size(206, 50);
            btBuscarPrecio.TabIndex = 13;
            btBuscarPrecio.Text = "Buscar";
            btBuscarPrecio.UseVisualStyleBackColor = false;
            btBuscarPrecio.Click += btBuscarPrecio_Click;
            // 
            // cbMarca
            // 
            cbMarca.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbMarca.FormattingEnabled = true;
            cbMarca.Items.AddRange(new object[] { "Todos", "IUSA", "kg/km" });
            cbMarca.Location = new Point(120, 126);
            cbMarca.Name = "cbMarca";
            cbMarca.Size = new Size(206, 40);
            cbMarca.TabIndex = 12;
            // 
            // cbUnidad
            // 
            cbUnidad.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbUnidad.FormattingEnabled = true;
            cbUnidad.Items.AddRange(new object[] { "m", "kg" });
            cbUnidad.Location = new Point(120, 82);
            cbUnidad.Name = "cbUnidad";
            cbUnidad.Size = new Size(206, 40);
            cbUnidad.TabIndex = 11;
            cbUnidad.SelectedIndexChanged += cbUnidad_SelectedIndexChanged;
            // 
            // cbCalibre
            // 
            cbCalibre.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbCalibre.FormattingEnabled = true;
            cbCalibre.Items.AddRange(new object[] { "12", "10", "8", "6", "4", "2", "1/0", "1/1", "1/2" });
            cbCalibre.Location = new Point(120, 31);
            cbCalibre.Name = "cbCalibre";
            cbCalibre.Size = new Size(206, 40);
            cbCalibre.TabIndex = 10;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMarca.Location = new Point(25, 126);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(79, 32);
            lblMarca.TabIndex = 9;
            lblMarca.Text = "Marca";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblColor.Location = new Point(30, 82);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(90, 32);
            lblColor.TabIndex = 8;
            lblColor.Text = "Unidad";
            // 
            // lblCalibre
            // 
            lblCalibre.AutoSize = true;
            lblCalibre.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCalibre.Location = new Point(30, 31);
            lblCalibre.Name = "lblCalibre";
            lblCalibre.Size = new Size(88, 32);
            lblCalibre.TabIndex = 7;
            lblCalibre.Text = "Calibre";
            // 
            // lblTamanio
            // 
            lblTamanio.AutoSize = true;
            lblTamanio.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTamanio.Location = new Point(338, 85);
            lblTamanio.Name = "lblTamanio";
            lblTamanio.Size = new Size(97, 32);
            lblTamanio.TabIndex = 15;
            lblTamanio.Text = "Tamaño";
            lblTamanio.Visible = false;
            // 
            // cbTamanio
            // 
            cbTamanio.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbTamanio.FormattingEnabled = true;
            cbTamanio.Items.AddRange(new object[] { "29.99", "47.7", "75.87", "120.6", "191.8", "304.9", "484.9" });
            cbTamanio.Location = new Point(437, 85);
            cbTamanio.Name = "cbTamanio";
            cbTamanio.Size = new Size(69, 40);
            cbTamanio.TabIndex = 16;
            cbTamanio.Visible = false;
            // 
            // btnFinalizar
            // 
            btnFinalizar.BackColor = SystemColors.ActiveCaption;
            btnFinalizar.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFinalizar.Location = new Point(545, 177);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(293, 50);
            btnFinalizar.TabIndex = 32;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = false;
            btnFinalizar.Visible = false;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // bynAgregarGlobal
            // 
            bynAgregarGlobal.BackColor = SystemColors.ActiveCaption;
            bynAgregarGlobal.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bynAgregarGlobal.Location = new Point(910, 34);
            bynAgregarGlobal.Name = "bynAgregarGlobal";
            bynAgregarGlobal.Size = new Size(206, 52);
            bynAgregarGlobal.TabIndex = 31;
            bynAgregarGlobal.Text = "Agregar último precio";
            bynAgregarGlobal.UseVisualStyleBackColor = false;
            bynAgregarGlobal.Click += bynAgregarGlobal_Click_1;
            // 
            // txtPrecioGlobal
            // 
            txtPrecioGlobal.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecioGlobal.Location = new Point(682, 28);
            txtPrecioGlobal.Name = "txtPrecioGlobal";
            txtPrecioGlobal.Size = new Size(176, 39);
            txtPrecioGlobal.TabIndex = 30;
            txtPrecioGlobal.Visible = false;
            // 
            // dtpFechaGlobal
            // 
            dtpFechaGlobal.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFechaGlobal.Format = DateTimePickerFormat.Short;
            dtpFechaGlobal.Location = new Point(684, 123);
            dtpFechaGlobal.Name = "dtpFechaGlobal";
            dtpFechaGlobal.Size = new Size(174, 39);
            dtpFechaGlobal.TabIndex = 29;
            dtpFechaGlobal.Visible = false;
            // 
            // cbProveedorGlobal
            // 
            cbProveedorGlobal.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbProveedorGlobal.FormattingEnabled = true;
            cbProveedorGlobal.Items.AddRange(new object[] { "ASENCIO", "ELEKTRON", "DIMEGSA", "ECOZA" });
            cbProveedorGlobal.Location = new Point(682, 77);
            cbProveedorGlobal.Name = "cbProveedorGlobal";
            cbProveedorGlobal.Size = new Size(176, 40);
            cbProveedorGlobal.TabIndex = 28;
            cbProveedorGlobal.Visible = false;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.Location = new Point(558, 123);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(75, 32);
            lblFecha.TabIndex = 27;
            lblFecha.Text = "Fecha";
            lblFecha.Visible = false;
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblProveedor.Location = new Point(554, 78);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(123, 32);
            lblProveedor.TabIndex = 26;
            lblProveedor.Text = "Proveedor";
            lblProveedor.Visible = false;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecio.Location = new Point(554, 34);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(79, 32);
            lblPrecio.TabIndex = 25;
            lblPrecio.Text = "Precio";
            lblPrecio.Visible = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ActiveCaption;
            btnCancelar.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(910, 104);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(206, 51);
            btnCancelar.TabIndex = 33;
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
            dataGridView1.Location = new Point(30, 233);
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
            dataGridView1.TabIndex = 34;
            // 
            // cableDesn
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 524);
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
            Controls.Add(cbTamanio);
            Controls.Add(lblTamanio);
            Controls.Add(btBuscarPrecio);
            Controls.Add(cbMarca);
            Controls.Add(cbUnidad);
            Controls.Add(cbCalibre);
            Controls.Add(lblMarca);
            Controls.Add(lblColor);
            Controls.Add(lblCalibre);
            Name = "cableDesn";
            Text = "cableDesn";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btBuscarPrecio;
        private ComboBox cbMarca;
        private ComboBox cbUnidad;
        private ComboBox cbCalibre;
        private Label lblMarca;
        private Label lblColor;
        private Label lblCalibre;
        private Label lblTamanio;
        private ComboBox cbTamanio;
        private Button btnFinalizar;
        private Button bynAgregarGlobal;
        private TextBox txtPrecioGlobal;
        private DateTimePicker dtpFechaGlobal;
        private ComboBox cbProveedorGlobal;
        private Label lblFecha;
        private Label lblProveedor;
        private Label lblPrecio;
        private Button btnCancelar;
        private DataGridView dataGridView1;
    }
}