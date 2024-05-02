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
            SuspendLayout();
            // 
            // logInBtn
            // 
            logInBtn.Location = new Point(240, 262);
            logInBtn.Name = "logInBtn";
            logInBtn.Size = new Size(75, 23);
            logInBtn.TabIndex = 0;
            logInBtn.Text = "Login";
            logInBtn.UseVisualStyleBackColor = true;
            logInBtn.Click += logInBtn_Click;
            // 
            // EmployeeLogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(logInBtn);
            Name = "EmployeeLogIn";
            Text = "EmployeeLogIn";
            ResumeLayout(false);
        }

        #endregion

        private Button logInBtn;
    }
}