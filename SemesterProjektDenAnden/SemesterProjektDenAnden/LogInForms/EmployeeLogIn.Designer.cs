namespace SemesterProjektDenAnden.LogInForms
{
    partial class EmployeeLogIn
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
            logInBtn = new Button();
            EmployeeCB = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // logInBtn
            // 
            logInBtn.BackColor = Color.White;
            logInBtn.Font = new Font("High Tower Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            logInBtn.ForeColor = Color.Black;
            logInBtn.Location = new Point(322, 228);
            logInBtn.Name = "logInBtn";
            logInBtn.Size = new Size(106, 33);
            logInBtn.TabIndex = 0;
            logInBtn.Text = "Login";
            logInBtn.UseVisualStyleBackColor = false;
            logInBtn.Click += logInBtn_Click;
            // 
            // EmployeeCB
            // 
            EmployeeCB.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            EmployeeCB.FormattingEnabled = true;
            EmployeeCB.Location = new Point(322, 198);
            EmployeeCB.Name = "EmployeeCB";
            EmployeeCB.Size = new Size(204, 24);
            EmployeeCB.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("High Tower Text", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(322, 130);
            label1.Name = "label1";
            label1.Size = new Size(96, 32);
            label1.TabIndex = 5;
            label1.Text = "Log ind";
            // 
            // EmployeeLogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(804, 451);
            Controls.Add(EmployeeCB);
            Controls.Add(label1);
            Controls.Add(logInBtn);
            Name = "EmployeeLogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeLogIn";
            FormClosing += EmployeeLogIn_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button logInBtn;
        private ComboBox EmployeeCB;
        private Label label1;
    }
}