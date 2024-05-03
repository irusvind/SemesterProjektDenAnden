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
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(441, 121);
            label1.Name = "label1";
            label1.Size = new Size(110, 27);
            label1.TabIndex = 0;
            label1.Text = "Log ind";
            // 
            // SignUpbtn
            // 
            SignUpbtn.FlatStyle = FlatStyle.Flat;
            SignUpbtn.Font = new Font("SimSun", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            SignUpbtn.Location = new Point(578, 165);
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
            label2.Font = new Font("SimSun", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(444, 172);
            label2.Name = "label2";
            label2.Size = new Size(70, 14);
            label2.TabIndex = 2;
            label2.Text = "Ny kunde?";
            // 
            // Loginbtn
            // 
            Loginbtn.BackColor = Color.White;
            Loginbtn.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Loginbtn.ForeColor = Color.Black;
            Loginbtn.Location = new Point(441, 263);
            Loginbtn.Margin = new Padding(3, 2, 3, 2);
            Loginbtn.Name = "Loginbtn";
            Loginbtn.Size = new Size(104, 33);
            Loginbtn.TabIndex = 3;
            Loginbtn.Text = "Login";
            Loginbtn.UseVisualStyleBackColor = false;
            Loginbtn.Click += Loginbtn_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("SimSun", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(444, 215);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 21);
            comboBox1.TabIndex = 4;
            // 
            // ClientLogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1034, 490);
            Controls.Add(comboBox1);
            Controls.Add(Loginbtn);
            Controls.Add(label2);
            Controls.Add(SignUpbtn);
            Controls.Add(label1);
            ForeColor = Color.Transparent;
            Margin = new Padding(3, 2, 3, 2);
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
        private ComboBox comboBox1;
    }
}