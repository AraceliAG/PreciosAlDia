namespace BuscadorPrecio
{
    partial class MaterialElectrico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaterialElectrico));
            panelMenu = new Panel();
            btSoportaria = new Button();
            cbSoporteria = new ComboBox();
            btnCana = new Button();
            cbCana = new ComboBox();
            btnCables = new Button();
            cbCables = new ComboBox();
            panelVista = new Panel();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = SystemColors.ActiveCaptionText;
            panelMenu.Controls.Add(btSoportaria);
            panelMenu.Controls.Add(cbSoporteria);
            panelMenu.Controls.Add(btnCana);
            panelMenu.Controls.Add(cbCana);
            panelMenu.Controls.Add(btnCables);
            panelMenu.Controls.Add(cbCables);
            panelMenu.Location = new Point(3, 6);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(330, 834);
            panelMenu.TabIndex = 0;
            // 
            // btSoportaria
            // 
            btSoportaria.BackColor = SystemColors.ActiveCaption;
            btSoportaria.BackgroundImage = (Image)resources.GetObject("btSoportaria.BackgroundImage");
            btSoportaria.BackgroundImageLayout = ImageLayout.Center;
            btSoportaria.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btSoportaria.Location = new Point(16, 141);
            btSoportaria.Name = "btSoportaria";
            btSoportaria.Size = new Size(297, 83);
            btSoportaria.TabIndex = 11;
            btSoportaria.Text = "Soporte";
            btSoportaria.TextAlign = ContentAlignment.BottomCenter;
            btSoportaria.UseVisualStyleBackColor = false;
            btSoportaria.Click += btSoportaria_Click;
            // 
            // cbSoporteria
            // 
            cbSoporteria.Font = new Font("Yu Gothic UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbSoporteria.FormattingEnabled = true;
            cbSoporteria.Items.AddRange(new object[] { "Abrazaderas", "Tuercas", "Soportes", "Unicanal galvanizado" });
            cbSoporteria.Location = new Point(16, 230);
            cbSoporteria.Name = "cbSoporteria";
            cbSoporteria.Size = new Size(297, 36);
            cbSoporteria.TabIndex = 12;
            cbSoporteria.Visible = false;
            cbSoporteria.SelectedIndexChanged += cbSoporteria_SelectedIndexChanged;
            // 
            // btnCana
            // 
            btnCana.BackColor = SystemColors.ActiveCaption;
            btnCana.BackgroundImage = (Image)resources.GetObject("btnCana.BackgroundImage");
            btnCana.BackgroundImageLayout = ImageLayout.Center;
            btnCana.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCana.Location = new Point(16, 272);
            btnCana.Name = "btnCana";
            btnCana.Size = new Size(297, 83);
            btnCana.TabIndex = 14;
            btnCana.Text = "Canalización";
            btnCana.TextAlign = ContentAlignment.BottomCenter;
            btnCana.UseVisualStyleBackColor = false;
            btnCana.Click += btnCana_Click;
            // 
            // cbCana
            // 
            cbCana.Font = new Font("Yu Gothic UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbCana.FormattingEnabled = true;
            cbCana.Items.AddRange(new object[] { "Condulet oval", "Conector", "ITM", "Tubería" });
            cbCana.Location = new Point(16, 361);
            cbCana.Name = "cbCana";
            cbCana.Size = new Size(297, 36);
            cbCana.TabIndex = 15;
            cbCana.Visible = false;
            cbCana.SelectedIndexChanged += cbCana_SelectedIndexChanged;
            // 
            // btnCables
            // 
            btnCables.BackColor = SystemColors.ActiveCaption;
            btnCables.BackgroundImage = (Image)resources.GetObject("btnCables.BackgroundImage");
            btnCables.BackgroundImageLayout = ImageLayout.Zoom;
            btnCables.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCables.Location = new Point(16, 10);
            btnCables.Name = "btnCables";
            btnCables.Size = new Size(297, 83);
            btnCables.TabIndex = 5;
            btnCables.Text = "Cables";
            btnCables.TextAlign = ContentAlignment.BottomCenter;
            btnCables.UseVisualStyleBackColor = false;
            btnCables.Click += btnCables_Click;
            // 
            // cbCables
            // 
            cbCables.Font = new Font("Yu Gothic UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbCables.FormattingEnabled = true;
            cbCables.Items.AddRange(new object[] { "Cable Cu. THHW-LS, 90°C, 600V, Cal.", "Cable multiconductor de alambre Cu ARMORFLEX", "Cable de uso rudo THHW", "Cable Cu. Desnudo, semiduro, Cal." });
            cbCables.Location = new Point(16, 99);
            cbCables.Name = "cbCables";
            cbCables.Size = new Size(297, 36);
            cbCables.TabIndex = 6;
            cbCables.Visible = false;
            cbCables.SelectedIndexChanged += cbCables_SelectedIndexChanged;
            // 
            // panelVista
            // 
            panelVista.Location = new Point(339, 6);
            panelVista.Name = "panelVista";
            panelVista.Size = new Size(1268, 834);
            panelVista.TabIndex = 1;
            // 
            // MaterialElectrico
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1608, 842);
            Controls.Add(panelVista);
            Controls.Add(panelMenu);
            Name = "MaterialElectrico";
            Text = "Material Electrico";
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelVista;
        private Button btnCables;
        private ComboBox cbCables;
        private Button btSoportaria;
        private ComboBox cbSoporteria;
        private Button btnCana;
        private ComboBox cbCana;
    }
}