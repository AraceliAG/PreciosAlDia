namespace BuscadorPrecio
{
    partial class Insercion
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
            btnAgregar = new Button();
            cbMarca = new ComboBox();
            cbColor = new ComboBox();
            cbCalibre = new ComboBox();
            lblMarca = new Label();
            lblColor = new Label();
            lblCalibre = new Label();
            label1 = new Label();
            txtFecha = new TextBox();
            label2 = new Label();
            txtPrecio = new TextBox();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(547, 40);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 34);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // cbMarca
            // 
            cbMarca.FormattingEnabled = true;
            cbMarca.Items.AddRange(new object[] { "Condulac", "Condumex", "Viakon" });
            cbMarca.Location = new Point(118, 116);
            cbMarca.Name = "cbMarca";
            cbMarca.Size = new Size(212, 33);
            cbMarca.TabIndex = 11;
            // 
            // cbColor
            // 
            cbColor.FormattingEnabled = true;
            cbColor.Items.AddRange(new object[] { "BLANCO", "NEGRO", "ROJO", "VERDE", "AZUL" });
            cbColor.Location = new Point(118, 78);
            cbColor.Name = "cbColor";
            cbColor.Size = new Size(212, 33);
            cbColor.TabIndex = 10;
            // 
            // cbCalibre
            // 
            cbCalibre.FormattingEnabled = true;
            cbCalibre.Items.AddRange(new object[] { "4", "2", "6", "8", "12", "10", "14", "1/0", "2/0", "3/0", "4/0", "" });
            cbCalibre.Location = new Point(118, 31);
            cbCalibre.Name = "cbCalibre";
            cbCalibre.Size = new Size(212, 33);
            cbCalibre.TabIndex = 9;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(29, 119);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(60, 25);
            lblMarca.TabIndex = 8;
            lblMarca.Text = "Marca";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(28, 78);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(55, 25);
            lblColor.TabIndex = 7;
            lblColor.Text = "Color";
            // 
            // lblCalibre
            // 
            lblCalibre.AutoSize = true;
            lblCalibre.Location = new Point(28, 27);
            lblCalibre.Name = "lblCalibre";
            lblCalibre.Size = new Size(66, 25);
            lblCalibre.TabIndex = 6;
            lblCalibre.Text = "Calibre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 168);
            label1.Name = "label1";
            label1.Size = new Size(57, 25);
            label1.TabIndex = 12;
            label1.Text = "Fecha";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(118, 168);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(212, 31);
            txtFecha.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 211);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 14;
            label2.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(118, 211);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(212, 31);
            txtPrecio.TabIndex = 15;
            // 
            // Insercion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 450);
            Controls.Add(txtPrecio);
            Controls.Add(label2);
            Controls.Add(txtFecha);
            Controls.Add(label1);
            Controls.Add(cbMarca);
            Controls.Add(cbColor);
            Controls.Add(cbCalibre);
            Controls.Add(lblMarca);
            Controls.Add(lblColor);
            Controls.Add(lblCalibre);
            Controls.Add(btnAgregar);
            Name = "Insercion";
            Text = "Insercion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private ComboBox cbMarca;
        private ComboBox cbColor;
        private ComboBox cbCalibre;
        private Label lblMarca;
        private Label lblColor;
        private Label lblCalibre;
        private Label label1;
        private TextBox txtFecha;
        private Label label2;
        private TextBox txtPrecio;
    }
}