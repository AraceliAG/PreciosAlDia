namespace BuscadorPrecio
{
    partial class Condulet
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
            dataGridView1 = new DataGridView();
            btBuscarPrecio = new Button();
            cbMarca = new ComboBox();
            cbMedida = new ComboBox();
            cbTipoTapa = new ComboBox();
            lblMarca = new Label();
            lblCaracteristica = new Label();
            lblTipo = new Label();
            cbSerie = new ComboBox();
            lblSerie = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            dataGridView1.Location = new Point(20, 291);
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
            dataGridView1.Size = new Size(991, 355);
            dataGridView1.TabIndex = 35;
            // 
            // btBuscarPrecio
            // 
            btBuscarPrecio.BackColor = SystemColors.ActiveCaption;
            btBuscarPrecio.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btBuscarPrecio.Location = new Point(180, 210);
            btBuscarPrecio.Name = "btBuscarPrecio";
            btBuscarPrecio.Size = new Size(212, 56);
            btBuscarPrecio.TabIndex = 34;
            btBuscarPrecio.Text = "Buscar";
            btBuscarPrecio.UseVisualStyleBackColor = false;
            btBuscarPrecio.Click += btBuscarPrecio_Click;
            // 
            // cbMarca
            // 
            cbMarca.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbMarca.FormattingEnabled = true;
            cbMarca.Items.AddRange(new object[] { "Todos", "Crouse Hinds" });
            cbMarca.Location = new Point(180, 164);
            cbMarca.Name = "cbMarca";
            cbMarca.Size = new Size(212, 40);
            cbMarca.TabIndex = 33;
            // 
            // cbMedida
            // 
            cbMedida.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbMedida.FormattingEnabled = true;
            cbMedida.Items.AddRange(new object[] { " 1/2", " 3/4", "1    ", "1 1/4", "1 1/2", "1, 1/4", "1, 1/2", "2    " });
            cbMedida.Location = new Point(180, 70);
            cbMedida.Name = "cbMedida";
            cbMedida.Size = new Size(212, 40);
            cbMedida.TabIndex = 32;
            // 
            // cbTipoTapa
            // 
            cbTipoTapa.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbTipoTapa.FormattingEnabled = true;
            cbTipoTapa.Items.AddRange(new object[] { "LB", "LL", "LR", "T", "C" });
            cbTipoTapa.Location = new Point(180, 27);
            cbTipoTapa.Name = "cbTipoTapa";
            cbTipoTapa.Size = new Size(212, 40);
            cbTipoTapa.TabIndex = 31;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMarca.Location = new Point(20, 155);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(79, 32);
            lblMarca.TabIndex = 30;
            lblMarca.Text = "Marca";
            // 
            // lblCaracteristica
            // 
            lblCaracteristica.AutoSize = true;
            lblCaracteristica.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaracteristica.Location = new Point(20, 73);
            lblCaracteristica.Name = "lblCaracteristica";
            lblCaracteristica.Size = new Size(95, 32);
            lblCaracteristica.TabIndex = 29;
            lblCaracteristica.Text = "Medida";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipo.Location = new Point(20, 30);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(150, 32);
            lblTipo.TabIndex = 28;
            lblTipo.Text = "Tipo de Tapa";
            // 
            // cbSerie
            // 
            cbSerie.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbSerie.FormattingEnabled = true;
            cbSerie.Items.AddRange(new object[] { "3" });
            cbSerie.Location = new Point(180, 118);
            cbSerie.Name = "cbSerie";
            cbSerie.Size = new Size(212, 40);
            cbSerie.TabIndex = 37;
            // 
            // lblSerie
            // 
            lblSerie.AutoSize = true;
            lblSerie.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSerie.Location = new Point(20, 118);
            lblSerie.Name = "lblSerie";
            lblSerie.Size = new Size(67, 32);
            lblSerie.TabIndex = 36;
            lblSerie.Text = "Serie";
            // 
            // Condulet
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 658);
            Controls.Add(cbSerie);
            Controls.Add(lblSerie);
            Controls.Add(dataGridView1);
            Controls.Add(btBuscarPrecio);
            Controls.Add(cbMarca);
            Controls.Add(cbMedida);
            Controls.Add(cbTipoTapa);
            Controls.Add(lblMarca);
            Controls.Add(lblCaracteristica);
            Controls.Add(lblTipo);
            Name = "Condulet";
            Text = "Condulet";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btBuscarPrecio;
        private ComboBox cbMarca;
        private ComboBox cbMedida;
        private ComboBox cbTipoTapa;
        private Label lblMarca;
        private Label lblCaracteristica;
        private Label lblTipo;
        private ComboBox cbSerie;
        private Label lblSerie;
    }
}