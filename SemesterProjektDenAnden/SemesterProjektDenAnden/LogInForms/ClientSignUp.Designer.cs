namespace SemesterProjektDenAnden.LogInForms
{
    partial class ClientSignUp
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
            label2 = new Label();
            button1 = new Button();
            FnameTxt = new TextBox();
            LnameTxt = new TextBox();
            PhoneTxt = new TextBox();
            MailTxt = new TextBox();
            AddressTxt = new TextBox();
            FnameLbl = new Label();
            Lnamelbl = new Label();
            PhoneLbl = new Label();
            MailLbl = new Label();
            AddressLbl = new Label();
            CreateBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("High Tower Text", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(270, 49);
            label1.Name = "label1";
            label1.Size = new Size(98, 32);
            label1.TabIndex = 0;
            label1.Text = "Sign up";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(270, 98);
            label2.Name = "label2";
            label2.Size = new Size(168, 18);
            label2.TabIndex = 1;
            label2.Text = "Har du allerede en bruger?";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(447, 89);
            button1.Name = "button1";
            button1.Size = new Size(78, 27);
            button1.TabIndex = 2;
            button1.Text = "Log ind";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FnameTxt
            // 
            FnameTxt.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            FnameTxt.Location = new Point(364, 142);
            FnameTxt.Name = "FnameTxt";
            FnameTxt.Size = new Size(161, 24);
            FnameTxt.TabIndex = 3;
            // 
            // LnameTxt
            // 
            LnameTxt.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            LnameTxt.Location = new Point(364, 193);
            LnameTxt.Name = "LnameTxt";
            LnameTxt.Size = new Size(161, 24);
            LnameTxt.TabIndex = 4;
            // 
            // PhoneTxt
            // 
            PhoneTxt.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneTxt.Location = new Point(364, 243);
            PhoneTxt.Name = "PhoneTxt";
            PhoneTxt.Size = new Size(161, 24);
            PhoneTxt.TabIndex = 5;
            // 
            // MailTxt
            // 
            MailTxt.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            MailTxt.Location = new Point(364, 296);
            MailTxt.Name = "MailTxt";
            MailTxt.Size = new Size(161, 24);
            MailTxt.TabIndex = 6;
            // 
            // AddressTxt
            // 
            AddressTxt.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            AddressTxt.Location = new Point(364, 347);
            AddressTxt.Name = "AddressTxt";
            AddressTxt.Size = new Size(161, 24);
            AddressTxt.TabIndex = 7;
            // 
            // FnameLbl
            // 
            FnameLbl.AutoSize = true;
            FnameLbl.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            FnameLbl.ForeColor = Color.White;
            FnameLbl.Location = new Point(270, 144);
            FnameLbl.Name = "FnameLbl";
            FnameLbl.Size = new Size(57, 18);
            FnameLbl.TabIndex = 9;
            FnameLbl.Text = "Fornavn";
            // 
            // Lnamelbl
            // 
            Lnamelbl.AutoSize = true;
            Lnamelbl.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            Lnamelbl.ForeColor = Color.White;
            Lnamelbl.Location = new Point(270, 193);
            Lnamelbl.Name = "Lnamelbl";
            Lnamelbl.Size = new Size(66, 18);
            Lnamelbl.TabIndex = 10;
            Lnamelbl.Text = "Efternavn";
            // 
            // PhoneLbl
            // 
            PhoneLbl.AutoSize = true;
            PhoneLbl.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneLbl.ForeColor = Color.White;
            PhoneLbl.Location = new Point(270, 246);
            PhoneLbl.Name = "PhoneLbl";
            PhoneLbl.Size = new Size(83, 18);
            PhoneLbl.TabIndex = 11;
            PhoneLbl.Text = "Telefon Nr.";
            // 
            // MailLbl
            // 
            MailLbl.AutoSize = true;
            MailLbl.BackColor = Color.Transparent;
            MailLbl.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            MailLbl.ForeColor = Color.White;
            MailLbl.Location = new Point(270, 299);
            MailLbl.Name = "MailLbl";
            MailLbl.Size = new Size(35, 18);
            MailLbl.TabIndex = 12;
            MailLbl.Text = "Mail";
            // 
            // AddressLbl
            // 
            AddressLbl.AutoSize = true;
            AddressLbl.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            AddressLbl.ForeColor = Color.White;
            AddressLbl.Location = new Point(270, 349);
            AddressLbl.Name = "AddressLbl";
            AddressLbl.Size = new Size(58, 18);
            AddressLbl.TabIndex = 13;
            AddressLbl.Text = "Adresse";
            // 
            // CreateBtn
            // 
            CreateBtn.BackColor = Color.White;
            CreateBtn.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            CreateBtn.ForeColor = Color.Black;
            CreateBtn.Location = new Point(617, 379);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(147, 31);
            CreateBtn.TabIndex = 15;
            CreateBtn.Text = "Opret Bruger";
            CreateBtn.UseVisualStyleBackColor = false;
            CreateBtn.Click += CreateBtn_Click;
            // 
            // ClientSignUp
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.Black;
            ClientSize = new Size(804, 451);
            Controls.Add(CreateBtn);
            Controls.Add(AddressLbl);
            Controls.Add(MailLbl);
            Controls.Add(PhoneLbl);
            Controls.Add(Lnamelbl);
            Controls.Add(FnameLbl);
            Controls.Add(AddressTxt);
            Controls.Add(MailTxt);
            Controls.Add(PhoneTxt);
            Controls.Add(LnameTxt);
            Controls.Add(FnameTxt);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ClientSignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClientSignUp";
            FormClosing += ClientSignUp_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox FnameTxt;
        private TextBox LnameTxt;
        private TextBox PhoneTxt;
        private TextBox MailTxt;
        private TextBox AddressTxt;
        private Label FnameLbl;
        private Label Lnamelbl;
        private Label PhoneLbl;
        private Label MailLbl;
        private Label AddressLbl;
        private Button CreateBtn;
    }
}