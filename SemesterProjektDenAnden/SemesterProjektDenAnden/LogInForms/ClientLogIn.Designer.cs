namespace SemesterProjektDenAnden.LogInForms
{
    partial class ClientLogIn
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
            SignUpbtn = new Button();
            label2 = new Label();
            Loginbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(253, 72);
            label1.Name = "label1";
            label1.Size = new Size(132, 46);
            label1.TabIndex = 0;
            label1.Text = "Log ind";
            // 
            // SignUpbtn
            // 
            SignUpbtn.FlatStyle = FlatStyle.Flat;
            SignUpbtn.Location = new Point(377, 126);
            SignUpbtn.Name = "SignUpbtn";
            SignUpbtn.Size = new Size(94, 29);
            SignUpbtn.TabIndex = 1;
            SignUpbtn.Text = "Sign-Up";
            SignUpbtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(262, 130);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 2;
            label2.Text = "Ny kunde?";
            // 
            // Loginbtn
            // 
            Loginbtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Loginbtn.Location = new Point(253, 366);
            Loginbtn.Name = "Loginbtn";
            Loginbtn.Size = new Size(119, 44);
            Loginbtn.TabIndex = 3;
            Loginbtn.Text = "Login";
            Loginbtn.UseVisualStyleBackColor = true;
            Loginbtn.Click += Loginbtn_Click;
            // 
            // ClientLogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 653);
            Controls.Add(Loginbtn);
            Controls.Add(label2);
            Controls.Add(SignUpbtn);
            Controls.Add(label1);
            Name = "ClientLogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClientLogIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button SignUpbtn;
        private Label label2;
        private Button Loginbtn;
    }
}