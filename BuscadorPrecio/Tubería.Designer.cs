namespace BuscadorPrecio
{
    partial class Tubería
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
            dataGridView1 = new DataGridView();
            btBuscarPrecio = new Button();
            cbMarca = new ComboBox();
            cbMedida = new ComboBox();
            cbTipoTubería = new ComboBox();
            lblMarca = new Label();
            lblMedida = new Label();
            lblTipoTuberia = new Label();
            lblmm = new Label();
            lblCaracterística = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            dataGridView1.Location = new Point(114, 309);
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
            dataGridView1.TabIndex = 43;
            // 
            // btBuscarPrecio
            // 
            btBuscarPrecio.BackColor = SystemColors.ActiveCaption;
            btBuscarPrecio.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btBuscarPrecio.Location = new Point(225, 201);
            btBuscarPrecio.Name = "btBuscarPrecio";
            btBuscarPrecio.Size = new Size(212, 56);
            btBuscarPrecio.TabIndex = 42;
            btBuscarPrecio.Text = "Buscar";
            btBuscarPrecio.UseVisualStyleBackColor = false;
            // 
            // cbMarca
            // 
            cbMarca.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbMarca.FormattingEnabled = true;
            cbMarca.Location = new Point(250, 156);
            cbMarca.Name = "cbMarca";
            cbMarca.Size = new Size(212, 40);
            cbMarca.TabIndex = 41;
            // 
            // cbMedida
            // 
            cbMedida.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbMedida.FormattingEnabled = true;
            cbMedida.Items.AddRange(new object[] { " 1/4", " 3/8" });
            cbMedida.Location = new Point(250, 112);
            cbMedida.Name = "cbMedida";
            cbMedida.Size = new Size(212, 40);
            cbMedida.TabIndex = 40;
            // 
            // cbTipoTubería
            // 
            cbTipoTubería.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbTipoTubería.FormattingEnabled = true;
            cbTipoTubería.Items.AddRange(new object[] { "Tubo FoGa, P/Delgada", "Tubo conduit PVC pesado", "Tubo FoGa, ROSCADO, con cople", "Tubo metálico flexible hermético a líquidos", "" });
            cbTipoTubería.Location = new Point(250, 69);
            cbTipoTubería.Name = "cbTipoTubería";
            cbTipoTubería.Size = new Size(335, 40);
            cbTipoTubería.TabIndex = 39;
            cbTipoTubería.SelectedIndexChanged += cbTipoITM_SelectedIndexChanged;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMarca.Location = new Point(65, 156);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(79, 32);
            lblMarca.TabIndex = 38;
            lblMarca.Text = "Marca";
            // 
            // lblMedida
            // 
            lblMedida.AutoSize = true;
            lblMedida.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMedida.Location = new Point(65, 115);
            lblMedida.Name = "lblMedida";
            lblMedida.Size = new Size(95, 32);
            lblMedida.TabIndex = 37;
            lblMedida.Text = "Medida";
            // 
            // lblTipoTuberia
            // 
            lblTipoTuberia.AutoSize = true;
            lblTipoTuberia.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipoTuberia.Location = new Point(65, 72);
            lblTipoTuberia.Name = "lblTipoTuberia";
            lblTipoTuberia.Size = new Size(179, 32);
            lblTipoTuberia.TabIndex = 36;
            lblTipoTuberia.Text = "Tipo de Tubería";
            // 
            // lblmm
            // 
            lblmm.AutoSize = true;
            lblmm.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblmm.Location = new Point(518, 120);
            lblmm.Name = "lblmm";
            lblmm.Size = new Size(24, 32);
            lblmm.TabIndex = 51;
            lblmm.Text = "-";
            lblmm.Visible = false;
            // 
            // lblCaracterística
            // 
            lblCaracterística.AutoSize = true;
            lblCaracterística.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaracterística.Location = new Point(653, 120);
            lblCaracterística.Name = "lblCaracterística";
            lblCaracterística.Size = new Size(24, 32);
            lblCaracterística.TabIndex = 52;
            lblCaracterística.Text = "-";
            lblCaracterística.Visible = false;
            // 
            // Tubería
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1374, 736);
            Controls.Add(lblCaracterística);
            Controls.Add(lblmm);
            Controls.Add(dataGridView1);
            Controls.Add(btBuscarPrecio);
            Controls.Add(cbMarca);
            Controls.Add(cbMedida);
            Controls.Add(cbTipoTubería);
            Controls.Add(lblMarca);
            Controls.Add(lblMedida);
            Controls.Add(lblTipoTuberia);
            Name = "Tubería";
            Text = "Tubería";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btBuscarPrecio;
        private ComboBox cbMarca;
        private ComboBox cbMedida;
        private ComboBox cbTipoTubería;
        private Label lblMarca;
        private Label lblMedida;
        private Label lblTipoTuberia;
        private Label lblmm;
        private Label lblCaracterística;
    }
}