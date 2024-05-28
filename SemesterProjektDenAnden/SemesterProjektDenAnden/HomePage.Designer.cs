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
            label2 = new Label();
            SuspendLayout();
            // 
            // Clientbtn
            // 
            Clientbtn.BackColor = Color.White;
            Clientbtn.Font = new Font("High Tower Text", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            Clientbtn.Location = new Point(204, 180);
            Clientbtn.Margin = new Padding(3, 2, 3, 2);
            Clientbtn.Name = "Clientbtn";
            Clientbtn.Size = new Size(266, 159);
            Clientbtn.TabIndex = 0;
            Clientbtn.Text = "Klient";
            Clientbtn.UseVisualStyleBackColor = false;
            Clientbtn.Click += button1_Click;
            // 
            // Employeebtn
            // 
            Employeebtn.BackColor = Color.White;
            Employeebtn.Font = new Font("High Tower Text", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            Employeebtn.Location = new Point(543, 180);
            Employeebtn.Margin = new Padding(3, 2, 3, 2);
            Employeebtn.Name = "Employeebtn";
            Employeebtn.Size = new Size(266, 159);
            Employeebtn.TabIndex = 0;
            Employeebtn.Text = "Ansat";
            Employeebtn.UseVisualStyleBackColor = false;
            Employeebtn.Click += Employeebtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("High Tower Text", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(386, 60);
            label1.Name = "label1";
            label1.Size = new Size(238, 57);
            label1.TabIndex = 1;
            label1.Text = "LawHouse";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("High Tower Text", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(328, 117);
            label2.Name = "label2";
            label2.Size = new Size(339, 22);
            label2.TabIndex = 2;
            label2.Text = "Vi hjælper dig, med at skabe din fremtid";
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1034, 490);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Employeebtn);
            Controls.Add(Clientbtn);
            ForeColor = Color.Black;
            Margin = new Padding(3, 2, 3, 2);
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
        private Label label2;
    }
}
