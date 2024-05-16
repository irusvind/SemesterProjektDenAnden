namespace SemesterProjektDenAnden.Tools
{
    partial class EmployeeTools
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
            label1 = new Label();
            Formular1 = new LinkLabel();
            Formular2 = new LinkLabel();
            CalculatorBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("High Tower Text", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(65, 67);
            label1.Name = "label1";
            label1.Size = new Size(232, 57);
            label1.TabIndex = 0;
            label1.Text = "Værktøjer";
            // 
            // Formular1
            // 
            Formular1.AutoSize = true;
            Formular1.Font = new Font("High Tower Text", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Formular1.LinkColor = Color.Black;
            Formular1.Location = new Point(138, 217);
            Formular1.Name = "Formular1";
            Formular1.Size = new Size(114, 28);
            Formular1.TabIndex = 1;
            Formular1.TabStop = true;
            Formular1.Text = "Formular 1";
            Formular1.LinkClicked += Formular1_LinkClicked;
            // 
            // Formular2
            // 
            Formular2.AutoSize = true;
            Formular2.Font = new Font("High Tower Text", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Formular2.LinkColor = Color.Black;
            Formular2.Location = new Point(138, 279);
            Formular2.Name = "Formular2";
            Formular2.Size = new Size(117, 28);
            Formular2.TabIndex = 2;
            Formular2.TabStop = true;
            Formular2.Text = "Formular 2";
            Formular2.LinkClicked += Formular2_LinkClicked;
            // 
            // CalculatorBtn
            // 
            CalculatorBtn.BackColor = Color.Black;
            CalculatorBtn.Font = new Font("High Tower Text", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            CalculatorBtn.ForeColor = Color.White;
            CalculatorBtn.Location = new Point(699, 198);
            CalculatorBtn.Name = "CalculatorBtn";
            CalculatorBtn.Size = new Size(254, 65);
            CalculatorBtn.TabIndex = 3;
            CalculatorBtn.Text = "Lånberegner";
            CalculatorBtn.UseVisualStyleBackColor = false;
            CalculatorBtn.Click += CalculatorBtn_Click;
            // 
            // EmployeeTools
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1065, 655);
            Controls.Add(CalculatorBtn);
            Controls.Add(Formular2);
            Controls.Add(Formular1);
            Controls.Add(label1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeeTools";
            Text = "EmployeeTools";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private LinkLabel Formular1;
        private LinkLabel Formular2;
        private Button CalculatorBtn;
    }
}