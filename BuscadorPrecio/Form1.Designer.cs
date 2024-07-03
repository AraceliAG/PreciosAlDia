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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            cbCables = new ComboBox();
            btnIniciar = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1031, 15);
            button1.Name = "button1";
            button1.Size = new Size(151, 34);
            button1.TabIndex = 0;
            button1.Text = "test";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(472, 94);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(677, 319);
            dataGridView1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(70, 15);
            button2.Name = "button2";
            button2.Size = new Size(185, 48);
            button2.TabIndex = 2;
            button2.Text = "cable";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // cbCables
            // 
            cbCables.FormattingEnabled = true;
            cbCables.Items.AddRange(new object[] { "Cable Cu. THHW-LS, 90°C, 600V, Cal.", "Cable multiconductor de alambre Cu ARMORFLEX", "Cable de uso rudo THHW", "Cable Cu. Desnudo, semiduro, Cal." });
            cbCables.Location = new Point(12, 76);
            cbCables.Name = "cbCables";
            cbCables.Size = new Size(338, 33);
            cbCables.TabIndex = 3;
            cbCables.Visible = false;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(98, 127);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(112, 34);
            btnIniciar.TabIndex = 4;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // button3
            // 
            button3.Location = new Point(576, 27);
            button3.Name = "button3";
            button3.Size = new Size(144, 36);
            button3.TabIndex = 5;
            button3.Text = "insertar Datos";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 520);
            Controls.Add(button3);
            Controls.Add(btnIniciar);
            Controls.Add(cbCables);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private ComboBox cbCables;
        private Button btnIniciar;
        private Button button3;
    }
}