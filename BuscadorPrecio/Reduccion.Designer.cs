namespace BuscadorPrecio
{
    partial class Reduccion
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
            cbSerie = new ComboBox();
            cbTipoITM = new ComboBox();
            lblMarca = new Label();
            lblSerie = new Label();
            lblTipoITM = new Label();
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
            dataGridView1.Location = new Point(46, 271);
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
            dataGridView1.TabIndex = 43;
            // 
            // btBuscarPrecio
            // 
            btBuscarPrecio.BackColor = SystemColors.ActiveCaption;
            btBuscarPrecio.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btBuscarPrecio.Location = new Point(195, 172);
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
            cbMarca.Location = new Point(195, 124);
            cbMarca.Name = "cbMarca";
            cbMarca.Size = new Size(212, 40);
            cbMarca.TabIndex = 41;
            // 
            // cbSerie
            // 
            cbSerie.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbSerie.FormattingEnabled = true;
            cbSerie.Items.AddRange(new object[] { " 1/4", " 3/8" });
            cbSerie.Location = new Point(195, 83);
            cbSerie.Name = "cbSerie";
            cbSerie.Size = new Size(212, 40);
            cbSerie.TabIndex = 40;
            // 
            // cbTipoITM
            // 
            cbTipoITM.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbTipoITM.FormattingEnabled = true;
            cbTipoITM.Items.AddRange(new object[] { "I.T.M., Riel Din 1P", "I.T.M., Riel Din 2P", "I.T.M., Riel Din 3P", "I.T.M., QO-Enchufable", "I.T.M., QO-Atornillable", "I.T.M., JDA 3 POLOS I-LINE", "I.T.M., JDL 3 POLOS c/Zapatas", "I.T.M., HDL 3 POLOS c/Zapatas", "I.T.M., JDL 3 POLOS c/Zapatas" });
            cbTipoITM.Location = new Point(195, 40);
            cbTipoITM.Name = "cbTipoITM";
            cbTipoITM.Size = new Size(335, 40);
            cbTipoITM.TabIndex = 39;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMarca.Location = new Point(35, 127);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(79, 32);
            lblMarca.TabIndex = 38;
            lblMarca.Text = "Marca";
            // 
            // lblSerie
            // 
            lblSerie.AutoSize = true;
            lblSerie.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSerie.Location = new Point(35, 86);
            lblSerie.Name = "lblSerie";
            lblSerie.Size = new Size(67, 32);
            lblSerie.TabIndex = 37;
            lblSerie.Text = "Serie";
            // 
            // lblTipoITM
            // 
            lblTipoITM.AutoSize = true;
            lblTipoITM.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipoITM.Location = new Point(35, 43);
            lblTipoITM.Name = "lblTipoITM";
            lblTipoITM.Size = new Size(121, 32);
            lblTipoITM.TabIndex = 36;
            lblTipoITM.Text = "Tipo I.T.M.";
            // 
            // Reduccion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 606);
            Controls.Add(dataGridView1);
            Controls.Add(btBuscarPrecio);
            Controls.Add(cbMarca);
            Controls.Add(cbSerie);
            Controls.Add(cbTipoITM);
            Controls.Add(lblMarca);
            Controls.Add(lblSerie);
            Controls.Add(lblTipoITM);
            Name = "Reduccion";
            Text = "Reduccion";
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
    }
}