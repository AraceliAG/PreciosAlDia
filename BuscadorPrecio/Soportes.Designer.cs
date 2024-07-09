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
            btnSE = new Button();
            btSMTT = new Button();
            btnSCCT = new Button();
            btnSCPT = new Button();
            SuspendLayout();
            // 
            // btnSE
            // 
            btnSE.Location = new Point(34, 41);
            btnSE.Name = "btnSE";
            btnSE.Size = new Size(201, 71);
            btnSE.TabIndex = 0;
            btnSE.Text = "Soporte para elevacion de tubería";
            btnSE.UseVisualStyleBackColor = true;
            // 
            // btSMTT
            // 
            btSMTT.Location = new Point(295, 41);
            btSMTT.Name = "btSMTT";
            btSMTT.Size = new Size(196, 71);
            btSMTT.TabIndex = 1;
            btSMTT.Text = "Soporte en muro/techo p/tubo";
            btSMTT.UseVisualStyleBackColor = true;
            // 
            // btnSCCT
            // 
            btnSCCT.Location = new Point(551, 41);
            btnSCCT.Name = "btnSCCT";
            btnSCCT.Size = new Size(213, 71);
            btnSCCT.TabIndex = 2;
            btnSCCT.Text = "Soporte colgante CLIP p/tubo";
            btnSCCT.UseVisualStyleBackColor = true;
            // 
            // btnSCPT
            // 
            btnSCPT.Location = new Point(815, 41);
            btnSCPT.Name = "btnSCPT";
            btnSCPT.Size = new Size(222, 71);
            btnSCPT.TabIndex = 3;
            btnSCPT.Text = "Soporte colgante t/pera p/tubo";
            btnSCPT.UseVisualStyleBackColor = true;
            // 
            // Soportes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 586);
            Controls.Add(btnSCPT);
            Controls.Add(btnSCCT);
            Controls.Add(btSMTT);
            Controls.Add(btnSE);
            Name = "Soportes";
            Text = "Soportes";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSE;
        private Button btSMTT;
        private Button btnSCCT;
        private Button btnSCPT;
    }
}