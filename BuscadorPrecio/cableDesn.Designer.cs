﻿namespace BuscadorPrecio
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
            btBuscarPrecio = new Button();
            cbMarca = new ComboBox();
            cbUnidad = new ComboBox();
            cbCalibre = new ComboBox();
            lblMarca = new Label();
            lblColor = new Label();
            lblCalibre = new Label();
            dataGridView1 = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btBuscarPrecio
            // 
            btBuscarPrecio.Location = new Point(120, 177);
            btBuscarPrecio.Name = "btBuscarPrecio";
            btBuscarPrecio.Size = new Size(212, 34);
            btBuscarPrecio.TabIndex = 13;
            btBuscarPrecio.Text = "Buscar";
            btBuscarPrecio.UseVisualStyleBackColor = true;
            btBuscarPrecio.Click += btBuscarPrecio_Click;
            // 
            // cbMarca
            // 
            cbMarca.FormattingEnabled = true;
            cbMarca.Items.AddRange(new object[] { "Todos", "IUSA", "kg/km" });
            cbMarca.Location = new Point(120, 126);
            cbMarca.Name = "cbMarca";
            cbMarca.Size = new Size(212, 33);
            cbMarca.TabIndex = 12;
            // 
            // cbUnidad
            // 
            cbUnidad.FormattingEnabled = true;
            cbUnidad.Items.AddRange(new object[] { "m", "kg" });
            cbUnidad.Location = new Point(120, 82);
            cbUnidad.Name = "cbUnidad";
            cbUnidad.Size = new Size(212, 33);
            cbUnidad.TabIndex = 11;
            cbUnidad.SelectedIndexChanged += cbUnidad_SelectedIndexChanged;
            // 
            // cbCalibre
            // 
            cbCalibre.FormattingEnabled = true;
            cbCalibre.Items.AddRange(new object[] { "12", "10", "8", "6", "4", "2", "1/0", "1/1", "1/2" });
            cbCalibre.Location = new Point(120, 31);
            cbCalibre.Name = "cbCalibre";
            cbCalibre.Size = new Size(212, 33);
            cbCalibre.TabIndex = 10;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(25, 126);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(60, 25);
            lblMarca.TabIndex = 9;
            lblMarca.Text = "Marca";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(30, 82);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(69, 25);
            lblColor.TabIndex = 8;
            lblColor.Text = "Unidad";
            // 
            // lblCalibre
            // 
            lblCalibre.AutoSize = true;
            lblCalibre.Location = new Point(30, 31);
            lblCalibre.Name = "lblCalibre";
            lblCalibre.Size = new Size(66, 25);
            lblCalibre.TabIndex = 7;
            lblCalibre.Text = "Calibre";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 250);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(772, 225);
            dataGridView1.TabIndex = 14;
            // 
            // lblTamanio
            // 
            lblTamanio.AutoSize = true;
            lblTamanio.Location = new Point(338, 85);
            lblTamanio.Name = "lblTamanio";
            lblTamanio.Size = new Size(74, 25);
            lblTamanio.TabIndex = 15;
            lblTamanio.Text = "Tamaño";
            lblTamanio.Visible = false;
            // 
            // cbTamanio
            // 
            cbTamanio.FormattingEnabled = true;
            cbTamanio.Items.AddRange(new object[] { "29.99", "47.7", "75.87", "120.6", "191.8", "304.9", "484.9" });
            cbTamanio.Location = new Point(418, 82);
            cbTamanio.Name = "cbTamanio";
            cbTamanio.Size = new Size(75, 33);
            cbTamanio.TabIndex = 16;
            cbTamanio.Visible = false;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(512, 177);
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
            bynAgregarGlobal.Location = new Point(901, 33);
            bynAgregarGlobal.Name = "bynAgregarGlobal";
            bynAgregarGlobal.Size = new Size(137, 70);
            bynAgregarGlobal.TabIndex = 31;
            bynAgregarGlobal.Text = "Agregar último precio";
            bynAgregarGlobal.UseVisualStyleBackColor = true;
            bynAgregarGlobal.Click += bynAgregarGlobal_Click_1;
            // 
            // txtPrecioGlobal
            // 
            txtPrecioGlobal.Location = new Point(629, 33);
            txtPrecioGlobal.Name = "txtPrecioGlobal";
            txtPrecioGlobal.Size = new Size(182, 31);
            txtPrecioGlobal.TabIndex = 30;
            txtPrecioGlobal.Visible = false;
            // 
            // dtpFechaGlobal
            // 
            dtpFechaGlobal.Format = DateTimePickerFormat.Short;
            dtpFechaGlobal.Location = new Point(629, 119);
            dtpFechaGlobal.Name = "dtpFechaGlobal";
            dtpFechaGlobal.Size = new Size(180, 31);
            dtpFechaGlobal.TabIndex = 29;
            dtpFechaGlobal.Visible = false;
            // 
            // cbProveedorGlobal
            // 
            cbProveedorGlobal.FormattingEnabled = true;
            cbProveedorGlobal.Location = new Point(629, 78);
            cbProveedorGlobal.Name = "cbProveedorGlobal";
            cbProveedorGlobal.Size = new Size(182, 33);
            cbProveedorGlobal.TabIndex = 28;
            cbProveedorGlobal.Visible = false;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(512, 124);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(57, 25);
            lblFecha.TabIndex = 27;
            lblFecha.Text = "Fecha";
            lblFecha.Visible = false;
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Location = new Point(512, 78);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(94, 25);
            lblProveedor.TabIndex = 26;
            lblProveedor.Text = "Proveedor";
            lblProveedor.Visible = false;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(512, 33);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(60, 25);
            lblPrecio.TabIndex = 25;
            lblPrecio.Text = "Precio";
            lblPrecio.Visible = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(868, 176);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(212, 34);
            btnCancelar.TabIndex = 33;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cableDesn
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 524);
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
            Controls.Add(dataGridView1);
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
        private DataGridView dataGridView1;
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
    }
}