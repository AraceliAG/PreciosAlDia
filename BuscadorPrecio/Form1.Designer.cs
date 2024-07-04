namespace BuscadorPrecio
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnCables = new Button();
            cbCables = new ComboBox();
            btnIniciar = new Button();
            SuspendLayout();
            // 
            // btnCables
            // 
            btnCables.BackColor = Color.Yellow;
            btnCables.BackgroundImage = (Image)resources.GetObject("btnCables.BackgroundImage");
            btnCables.BackgroundImageLayout = ImageLayout.Zoom;
            btnCables.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCables.Location = new Point(112, 70);
            btnCables.Name = "btnCables";
            btnCables.Size = new Size(120, 92);
            btnCables.TabIndex = 2;
            btnCables.Text = "Cables";
            btnCables.TextAlign = ContentAlignment.BottomCenter;
            btnCables.UseVisualStyleBackColor = false;
            btnCables.Click += button2_Click;
            // 
            // cbCables
            // 
            cbCables.Font = new Font("Yu Gothic UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbCables.FormattingEnabled = true;
            cbCables.Items.AddRange(new object[] { "Cable Cu. THHW-LS, 90°C, 600V, Cal.", "Cable multiconductor de alambre Cu ARMORFLEX", "Cable de uso rudo THHW", "Cable Cu. Desnudo, semiduro, Cal." });
            cbCables.Location = new Point(47, 185);
            cbCables.Name = "cbCables";
            cbCables.Size = new Size(287, 36);
            cbCables.TabIndex = 3;
            cbCables.Visible = false;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.Yellow;
            btnIniciar.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnIniciar.Location = new Point(112, 250);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(131, 41);
            btnIniciar.TabIndex = 4;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Visible = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 520);
            Controls.Add(btnIniciar);
            Controls.Add(cbCables);
            Controls.Add(btnCables);
            Name = "Form1";
            Text = "Inicio";
            ResumeLayout(false);
        }

        #endregion
        private Button btnCables;
        private ComboBox cbCables;
        private Button btnIniciar;
    }
}