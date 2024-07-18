namespace BuscadorPrecio
{
    partial class Conectores
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
            cbModelo = new ComboBox();
            lblModelo = new Label();
            dataGridView1 = new DataGridView();
            btBuscarPrecio = new Button();
            cbMarca = new ComboBox();
            cbMedida = new ComboBox();
            cbTipoConector = new ComboBox();
            lblMarca = new Label();
            lblMedida = new Label();
            lblTipoConec = new Label();
            lblCarac = new Label();
            cbCarac = new ComboBox();
            lblmm = new Label();
            lblCalibre = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cbModelo
            // 
            cbModelo.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbModelo.FormattingEnabled = true;
            cbModelo.Location = new Point(710, 122);
            cbModelo.Name = "cbModelo";
            cbModelo.Size = new Size(212, 40);
            cbModelo.TabIndex = 47;
            cbModelo.Visible = false;
            cbModelo.SelectedIndexChanged += cbModelo_SelectedIndexChanged;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblModelo.Location = new Point(537, 122);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(97, 32);
            lblModelo.TabIndex = 46;
            lblModelo.Text = "Modelo";
            lblModelo.Visible = false;
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
            dataGridView1.Location = new Point(23, 277);
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
            dataGridView1.TabIndex = 45;
            // 
            // btBuscarPrecio
            // 
            btBuscarPrecio.BackColor = SystemColors.ActiveCaption;
            btBuscarPrecio.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btBuscarPrecio.Location = new Point(242, 208);
            btBuscarPrecio.Name = "btBuscarPrecio";
            btBuscarPrecio.Size = new Size(212, 56);
            btBuscarPrecio.TabIndex = 44;
            btBuscarPrecio.Text = "Buscar";
            btBuscarPrecio.UseVisualStyleBackColor = false;
            btBuscarPrecio.Visible = false;
            // 
            // cbMarca
            // 
            cbMarca.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbMarca.FormattingEnabled = true;
            cbMarca.Items.AddRange(new object[] { "Todos", "ANCLO", "ARGOS", "BURNDY", "DROF", "Crouse Hinds" });
            cbMarca.Location = new Point(242, 114);
            cbMarca.Name = "cbMarca";
            cbMarca.Size = new Size(212, 40);
            cbMarca.TabIndex = 43;
            cbMarca.Visible = false;
            // 
            // cbMedida
            // 
            cbMedida.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbMedida.FormattingEnabled = true;
            cbMedida.Location = new Point(242, 68);
            cbMedida.Name = "cbMedida";
            cbMedida.Size = new Size(182, 40);
            cbMedida.TabIndex = 42;
            cbMedida.Visible = false;
            cbMedida.SelectedIndexChanged += cbMedida_SelectedIndexChanged;
            // 
            // cbTipoConector
            // 
            cbTipoConector.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbTipoConector.FormattingEnabled = true;
            cbTipoConector.Items.AddRange(new object[] { "Conector FoGa P/Delgada", "Conector bipartido, de cobre", "Conector recto p/Tubo licuatite", "Conector recto Zapa, p/tubo flexible", "Conector glándula con contratuerca" });
            cbTipoConector.Location = new Point(242, 25);
            cbTipoConector.Name = "cbTipoConector";
            cbTipoConector.Size = new Size(416, 40);
            cbTipoConector.TabIndex = 41;
            cbTipoConector.SelectedIndexChanged += cbTipoTapa_SelectedIndexChanged;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMarca.Location = new Point(23, 117);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(79, 32);
            lblMarca.TabIndex = 40;
            lblMarca.Text = "Marca";
            lblMarca.Visible = false;
            // 
            // lblMedida
            // 
            lblMedida.AutoSize = true;
            lblMedida.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMedida.Location = new Point(23, 71);
            lblMedida.Name = "lblMedida";
            lblMedida.Size = new Size(95, 32);
            lblMedida.TabIndex = 39;
            lblMedida.Text = "Medida";
            lblMedida.Visible = false;
            // 
            // lblTipoConec
            // 
            lblTipoConec.AutoSize = true;
            lblTipoConec.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipoConec.Location = new Point(23, 28);
            lblTipoConec.Name = "lblTipoConec";
            lblTipoConec.Size = new Size(199, 32);
            lblTipoConec.TabIndex = 38;
            lblTipoConec.Text = "Tipo de Conector";
            // 
            // lblCarac
            // 
            lblCarac.AutoSize = true;
            lblCarac.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCarac.Location = new Point(537, 81);
            lblCarac.Name = "lblCarac";
            lblCarac.Size = new Size(154, 32);
            lblCarac.TabIndex = 48;
            lblCarac.Text = "Característica";
            lblCarac.Visible = false;
            // 
            // cbCarac
            // 
            cbCarac.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbCarac.FormattingEnabled = true;
            cbCarac.Location = new Point(710, 73);
            cbCarac.Name = "cbCarac";
            cbCarac.Size = new Size(212, 40);
            cbCarac.TabIndex = 49;
            cbCarac.Visible = false;
            cbCarac.SelectedIndexChanged += cbCarac_SelectedIndexChanged;
            // 
            // lblmm
            // 
            lblmm.AutoSize = true;
            lblmm.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblmm.Location = new Point(446, 71);
            lblmm.Name = "lblmm";
            lblmm.Size = new Size(24, 32);
            lblmm.TabIndex = 50;
            lblmm.Text = "-";
            lblmm.Visible = false;
            // 
            // lblCalibre
            // 
            lblCalibre.AutoSize = true;
            lblCalibre.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCalibre.Location = new Point(960, 130);
            lblCalibre.Name = "lblCalibre";
            lblCalibre.Size = new Size(24, 32);
            lblCalibre.TabIndex = 51;
            lblCalibre.Text = "-";
            lblCalibre.Visible = false;
            // 
            // Conectores
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1203, 587);
            Controls.Add(lblCalibre);
            Controls.Add(lblmm);
            Controls.Add(cbCarac);
            Controls.Add(lblCarac);
            Controls.Add(cbModelo);
            Controls.Add(lblModelo);
            Controls.Add(dataGridView1);
            Controls.Add(btBuscarPrecio);
            Controls.Add(cbMarca);
            Controls.Add(cbMedida);
            Controls.Add(cbTipoConector);
            Controls.Add(lblMarca);
            Controls.Add(lblMedida);
            Controls.Add(lblTipoConec);
            Name = "Conectores";
            Text = "Conectores";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbModelo;
        private Label lblModelo;
        private DataGridView dataGridView1;
        private Button btBuscarPrecio;
        private ComboBox cbMarca;
        private ComboBox cbMedida;
        private ComboBox cbTipoConector;
        private Label lblMarca;
        private Label lblMedida;
        private Label lblTipoConec;
        private Label lblCarac;
        private ComboBox cbCarac;
        private Label lblmm;
        private Label lblCalibre;
    }
}