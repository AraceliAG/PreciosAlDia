namespace BuscadorPrecio
{
    partial class Soportes
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            cbSerie = new ComboBox();
            lblSerie = new Label();
            dataGridView1 = new DataGridView();
            btBuscarPrecio = new Button();
            cbMarca = new ComboBox();
            cbMedida = new ComboBox();
            cbTipoSop = new ComboBox();
            lblMarca = new Label();
            lblCaracteristica = new Label();
            lblTipo = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cbSerie
            // 
            cbSerie.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbSerie.FormattingEnabled = true;
            cbSerie.Items.AddRange(new object[] { "3" });
            cbSerie.Location = new Point(286, 137);
            cbSerie.Name = "cbSerie";
            cbSerie.Size = new Size(212, 40);
            cbSerie.TabIndex = 47;
            // 
            // lblSerie
            // 
            lblSerie.AutoSize = true;
            lblSerie.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSerie.Location = new Point(62, 133);
            lblSerie.Name = "lblSerie";
            lblSerie.Size = new Size(67, 32);
            lblSerie.TabIndex = 46;
            lblSerie.Text = "Serie";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.Location = new Point(62, 306);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle6.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.Window;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(991, 355);
            dataGridView1.TabIndex = 45;
            // 
            // btBuscarPrecio
            // 
            btBuscarPrecio.BackColor = SystemColors.ActiveCaption;
            btBuscarPrecio.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btBuscarPrecio.Location = new Point(286, 229);
            btBuscarPrecio.Name = "btBuscarPrecio";
            btBuscarPrecio.Size = new Size(212, 56);
            btBuscarPrecio.TabIndex = 44;
            btBuscarPrecio.Text = "Buscar";
            btBuscarPrecio.UseVisualStyleBackColor = false;
            // 
            // cbMarca
            // 
            cbMarca.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbMarca.FormattingEnabled = true;
            cbMarca.Items.AddRange(new object[] { "Todos", "Crouse Hinds" });
            cbMarca.Location = new Point(286, 183);
            cbMarca.Name = "cbMarca";
            cbMarca.Size = new Size(212, 40);
            cbMarca.TabIndex = 43;
            // 
            // cbMedida
            // 
            cbMedida.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbMedida.FormattingEnabled = true;
            cbMedida.Items.AddRange(new object[] { " 1/2", " 3/4", "1    ", "1 1/4", "1 1/2", "1, 1/4", "1, 1/2", "2    " });
            cbMedida.Location = new Point(286, 91);
            cbMedida.Name = "cbMedida";
            cbMedida.Size = new Size(212, 40);
            cbMedida.TabIndex = 42;
            // 
            // cbTipoSop
            // 
            cbTipoSop.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbTipoSop.FormattingEnabled = true;
            cbTipoSop.Items.AddRange(new object[] { "LB", "LL", "LR", "T", "C" });
            cbTipoSop.Location = new Point(286, 45);
            cbTipoSop.Name = "cbTipoSop";
            cbTipoSop.Size = new Size(212, 40);
            cbTipoSop.TabIndex = 41;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMarca.Location = new Point(62, 170);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(79, 32);
            lblMarca.TabIndex = 40;
            lblMarca.Text = "Marca";
            // 
            // lblCaracteristica
            // 
            lblCaracteristica.AutoSize = true;
            lblCaracteristica.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaracteristica.Location = new Point(62, 88);
            lblCaracteristica.Name = "lblCaracteristica";
            lblCaracteristica.Size = new Size(95, 32);
            lblCaracteristica.TabIndex = 39;
            lblCaracteristica.Text = "Medida";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipo.Location = new Point(62, 45);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(186, 32);
            lblTipo.TabIndex = 38;
            lblTipo.Text = "Tipo de Soporte";
            lblTipo.Click += lblTipo_Click;
            // 
            // Soportes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 586);
            Controls.Add(cbSerie);
            Controls.Add(lblSerie);
            Controls.Add(dataGridView1);
            Controls.Add(btBuscarPrecio);
            Controls.Add(cbMarca);
            Controls.Add(cbMedida);
            Controls.Add(cbTipoSop);
            Controls.Add(lblMarca);
            Controls.Add(lblCaracteristica);
            Controls.Add(lblTipo);
            Name = "Soportes";
            Text = "Soportes";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbSerie;
        private Label lblSerie;
        private DataGridView dataGridView1;
        private Button btBuscarPrecio;
        private ComboBox cbMarca;
        private ComboBox cbMedida;
        private ComboBox cbTipoSop;
        private Label lblMarca;
        private Label lblCaracteristica;
        private Label lblTipo;
    }
}