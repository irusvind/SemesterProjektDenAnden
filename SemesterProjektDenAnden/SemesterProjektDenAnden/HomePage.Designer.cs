namespace SemesterProjektDenAnden
{
    partial class HomePage
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
            Clientbtn = new Button();
            Employeebtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // Clientbtn
            // 
            Clientbtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Clientbtn.Location = new Point(314, 337);
            Clientbtn.Name = "Clientbtn";
            Clientbtn.Size = new Size(234, 97);
            Clientbtn.TabIndex = 0;
            Clientbtn.Text = "Klient";
            Clientbtn.UseVisualStyleBackColor = true;
            Clientbtn.Click += button1_Click;
            // 
            // Employeebtn
            // 
            Employeebtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Employeebtn.Location = new Point(639, 337);
            Employeebtn.Name = "Employeebtn";
            Employeebtn.Size = new Size(234, 97);
            Employeebtn.TabIndex = 0;
            Employeebtn.Text = "Ansat";
            Employeebtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(461, 185);
            label1.Name = "label1";
            label1.Size = new Size(271, 46);
            label1.TabIndex = 1;
            label1.Text = "Klient eller Ansat";
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 653);
            Controls.Add(label1);
            Controls.Add(Employeebtn);
            Controls.Add(Clientbtn);
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Button Clientbtn;
        private Panel panel2;
        private Button Employeebtn;
        private Panel panel3;
        private Button button3;
        private Panel panel4;
        private Button button4;
        private Label label1;
    }
}
