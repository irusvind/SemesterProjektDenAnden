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
            ClientCB = new ComboBox();
            BackBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("High Tower Text", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(327, 116);
            label1.Name = "label1";
            label1.Size = new Size(96, 32);
            label1.TabIndex = 0;
            label1.Text = "Log ind";
            // 
            // SignUpbtn
            // 
            SignUpbtn.FlatStyle = FlatStyle.Flat;
            SignUpbtn.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            SignUpbtn.Location = new Point(464, 160);
            SignUpbtn.Margin = new Padding(3, 2, 3, 2);
            SignUpbtn.Name = "SignUpbtn";
            SignUpbtn.Size = new Size(82, 28);
            SignUpbtn.TabIndex = 1;
            SignUpbtn.Text = "Sign-Up";
            SignUpbtn.UseVisualStyleBackColor = true;
            SignUpbtn.Click += SignUpbtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(330, 167);
            label2.Name = "label2";
            label2.Size = new Size(73, 18);
            label2.TabIndex = 2;
            label2.Text = "Ny kunde?";
            // 
            // Loginbtn
            // 
            Loginbtn.BackColor = Color.White;
            Loginbtn.Font = new Font("High Tower Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Loginbtn.ForeColor = Color.Black;
            Loginbtn.Location = new Point(327, 258);
            Loginbtn.Margin = new Padding(3, 2, 3, 2);
            Loginbtn.Name = "Loginbtn";
            Loginbtn.Size = new Size(104, 33);
            Loginbtn.TabIndex = 3;
            Loginbtn.Text = "Login";
            Loginbtn.UseVisualStyleBackColor = false;
            Loginbtn.Click += Loginbtn_Click;
            // 
            // ClientCB
            // 
            ClientCB.DropDownStyle = ComboBoxStyle.DropDownList;
            ClientCB.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            ClientCB.FormattingEnabled = true;
            ClientCB.Location = new Point(330, 210);
            ClientCB.Name = "ClientCB";
            ClientCB.Size = new Size(216, 24);
            ClientCB.TabIndex = 4;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.White;
            BackBtn.Font = new Font("High Tower Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BackBtn.ForeColor = Color.Black;
            BackBtn.Location = new Point(464, 258);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(82, 33);
            BackBtn.TabIndex = 5;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // ClientLogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(804, 451);
            Controls.Add(BackBtn);
            Controls.Add(ClientCB);
            Controls.Add(Loginbtn);
            Controls.Add(label2);
            Controls.Add(SignUpbtn);
            Controls.Add(label1);
            ForeColor = Color.Transparent;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ClientLogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClientLogIn";
            FormClosing += ClientLogIn_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button SignUpbtn;
        private Label label2;
        private Button Loginbtn;
        private ComboBox ClientCB;
        private Button BackBtn;
    }
}