namespace BuscadorPrecio
{
    partial class ITM
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
            cbSerie = new ComboBox();
            cbTipoITM = new ComboBox();
            lblMarca = new Label();
            lblSerie = new Label();
            lblTipoITM = new Label();
            lblVoltaje = new Label();
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
            dataGridView1.Location = new Point(47, 274);
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
            dataGridView1.TabIndex = 35;
            // 
            // btBuscarPrecio
            // 
            btBuscarPrecio.BackColor = SystemColors.ActiveCaption;
            btBuscarPrecio.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btBuscarPrecio.Location = new Point(196, 175);
            btBuscarPrecio.Name = "btBuscarPrecio";
            btBuscarPrecio.Size = new Size(212, 56);
            btBuscarPrecio.TabIndex = 34;
            btBuscarPrecio.Text = "Buscar";
            btBuscarPrecio.UseVisualStyleBackColor = false;
            // 
            // cbMarca
            // 
            cbMarca.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbMarca.FormattingEnabled = true;
            cbMarca.Items.AddRange(new object[] { "Todos", "N/A", "ANCLO" });
            cbMarca.Location = new Point(196, 127);
            cbMarca.Name = "cbMarca";
            cbMarca.Size = new Size(212, 40);
            cbMarca.TabIndex = 33;
            // 
            // cbSerie
            // 
            cbSerie.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbSerie.FormattingEnabled = true;
            cbSerie.Items.AddRange(new object[] { " 1/4", " 3/8" });
            cbSerie.Location = new Point(196, 86);
            cbSerie.Name = "cbSerie";
            cbSerie.Size = new Size(212, 40);
            cbSerie.TabIndex = 32;
            cbSerie.SelectedIndexChanged += cbSerie_SelectedIndexChanged;
            // 
            // cbTipoITM
            // 
            cbTipoITM.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbTipoITM.FormattingEnabled = true;
            cbTipoITM.Items.AddRange(new object[] { "I.T.M., Riel Din 1P", "I.T.M., Riel Din 2P", "I.T.M., Riel Din 3P", "I.T.M., QO-Enchufable", "I.T.M., QO-Atornillable", "I.T.M., JDA 3 POLOS I-LINE", "I.T.M., JDL 3 POLOS c/Zapatas", "I.T.M., HDL 3 POLOS c/Zapatas", "I.T.M., JDL 3 POLOS c/Zapatas" });
            cbTipoITM.Location = new Point(196, 43);
            cbTipoITM.Name = "cbTipoITM";
            cbTipoITM.Size = new Size(335, 40);
            cbTipoITM.TabIndex = 31;
            cbTipoITM.SelectedIndexChanged += cbTipo_SelectedIndexChanged;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMarca.Location = new Point(36, 130);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(79, 32);
            lblMarca.TabIndex = 30;
            lblMarca.Text = "Marca";
            // 
            // lblSerie
            // 
            lblSerie.AutoSize = true;
            lblSerie.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSerie.Location = new Point(36, 89);
            lblSerie.Name = "lblSerie";
            lblSerie.Size = new Size(67, 32);
            lblSerie.TabIndex = 29;
            lblSerie.Text = "Serie";
            // 
            // lblTipoITM
            // 
            lblTipoITM.AutoSize = true;
            lblTipoITM.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipoITM.Location = new Point(36, 46);
            lblTipoITM.Name = "lblTipoITM";
            lblTipoITM.Size = new Size(121, 32);
            lblTipoITM.TabIndex = 28;
            lblTipoITM.Text = "Tipo I.T.M.";
            // 
            // lblVoltaje
            // 
            lblVoltaje.AutoSize = true;
            lblVoltaje.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblVoltaje.Location = new Point(439, 89);
            lblVoltaje.Name = "lblVoltaje";
            lblVoltaje.Size = new Size(24, 32);
            lblVoltaje.TabIndex = 51;
            lblVoltaje.Text = "-";
            lblVoltaje.Visible = false;
            // 
            // ITM
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1220, 658);
            Controls.Add(lblVoltaje);
            Controls.Add(dataGridView1);
            Controls.Add(btBuscarPrecio);
            Controls.Add(cbMarca);
            Controls.Add(cbSerie);
            Controls.Add(cbTipoITM);
            Controls.Add(lblMarca);
            Controls.Add(lblSerie);
            Controls.Add(lblTipoITM);
            Name = "ITM";
            Text = "ITM";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btBuscarPrecio;
        private ComboBox cbMarca;
        private ComboBox cbSerie;
        private ComboBox cbTipoITM;
        private Label lblMarca;
        private Label lblSerie;
        private Label lblTipoITM;
        private Label lblVoltaje;
    }
}