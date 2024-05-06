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
            SubscribeCB = new CheckBox();
            FnameLbl = new Label();
            Lnamelbl = new Label();
            PhoneLbl = new Label();
            MailLbl = new Label();
            AddressLbl = new Label();
            SubscribeLbl = new Label();
            CreateBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(207, 72);
            label1.Name = "label1";
            label1.Size = new Size(107, 37);
            label1.TabIndex = 0;
            label1.Text = "Sign up";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(207, 121);
            label2.Name = "label2";
            label2.Size = new Size(146, 15);
            label2.TabIndex = 1;
            label2.Text = "Har du allerede en bruger?";
            // 
            // button1
            // 
            button1.Location = new Point(359, 121);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Log ind";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FnameTxt
            // 
            FnameTxt.Location = new Point(207, 177);
            FnameTxt.Name = "FnameTxt";
            FnameTxt.Size = new Size(100, 23);
            FnameTxt.TabIndex = 3;
            // 
            // LnameTxt
            // 
            LnameTxt.Location = new Point(207, 244);
            LnameTxt.Name = "LnameTxt";
            LnameTxt.Size = new Size(100, 23);
            LnameTxt.TabIndex = 4;
            // 
            // PhoneTxt
            // 
            PhoneTxt.Location = new Point(207, 312);
            PhoneTxt.Name = "PhoneTxt";
            PhoneTxt.Size = new Size(100, 23);
            PhoneTxt.TabIndex = 5;
            // 
            // MailTxt
            // 
            MailTxt.Location = new Point(404, 177);
            MailTxt.Name = "MailTxt";
            MailTxt.Size = new Size(100, 23);
            MailTxt.TabIndex = 6;
            // 
            // AddressTxt
            // 
            AddressTxt.Location = new Point(404, 244);
            AddressTxt.Name = "AddressTxt";
            AddressTxt.Size = new Size(100, 23);
            AddressTxt.TabIndex = 7;
            // 
            // SubscribeCB
            // 
            SubscribeCB.AutoSize = true;
            SubscribeCB.Location = new Point(419, 316);
            SubscribeCB.Name = "SubscribeCB";
            SubscribeCB.Size = new Size(15, 14);
            SubscribeCB.TabIndex = 8;
            SubscribeCB.UseVisualStyleBackColor = true;
            // 
            // FnameLbl
            // 
            FnameLbl.AutoSize = true;
            FnameLbl.Location = new Point(207, 159);
            FnameLbl.Name = "FnameLbl";
            FnameLbl.Size = new Size(50, 15);
            FnameLbl.TabIndex = 9;
            FnameLbl.Text = "Fornavn";
            // 
            // Lnamelbl
            // 
            Lnamelbl.AutoSize = true;
            Lnamelbl.Location = new Point(207, 226);
            Lnamelbl.Name = "Lnamelbl";
            Lnamelbl.Size = new Size(57, 15);
            Lnamelbl.TabIndex = 10;
            Lnamelbl.Text = "Efternavn";
            // 
            // PhoneLbl
            // 
            PhoneLbl.AutoSize = true;
            PhoneLbl.Location = new Point(207, 294);
            PhoneLbl.Name = "PhoneLbl";
            PhoneLbl.Size = new Size(64, 15);
            PhoneLbl.TabIndex = 11;
            PhoneLbl.Text = "Telefon Nr.";
            // 
            // MailLbl
            // 
            MailLbl.AutoSize = true;
            MailLbl.Location = new Point(404, 159);
            MailLbl.Name = "MailLbl";
            MailLbl.Size = new Size(30, 15);
            MailLbl.TabIndex = 12;
            MailLbl.Text = "Mail";
            // 
            // AddressLbl
            // 
            AddressLbl.AutoSize = true;
            AddressLbl.Location = new Point(404, 226);
            AddressLbl.Name = "AddressLbl";
            AddressLbl.Size = new Size(55, 15);
            AddressLbl.TabIndex = 13;
            AddressLbl.Text = "Addresse";
            // 
            // SubscribeLbl
            // 
            SubscribeLbl.AutoSize = true;
            SubscribeLbl.Location = new Point(404, 294);
            SubscribeLbl.Name = "SubscribeLbl";
            SubscribeLbl.Size = new Size(58, 15);
            SubscribeLbl.TabIndex = 14;
            SubscribeLbl.Text = "Abonnér?";
            // 
            // CreateBtn
            // 
            CreateBtn.Location = new Point(315, 391);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(92, 23);
            CreateBtn.TabIndex = 15;
            CreateBtn.Text = "Opret Bruger";
            CreateBtn.UseVisualStyleBackColor = true;
            CreateBtn.Click += CreateBtn_Click;
            // 
            // ClientSignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CreateBtn);
            Controls.Add(SubscribeLbl);
            Controls.Add(AddressLbl);
            Controls.Add(MailLbl);
            Controls.Add(PhoneLbl);
            Controls.Add(Lnamelbl);
            Controls.Add(FnameLbl);
            Controls.Add(SubscribeCB);
            Controls.Add(AddressTxt);
            Controls.Add(MailTxt);
            Controls.Add(PhoneTxt);
            Controls.Add(LnameTxt);
            Controls.Add(FnameTxt);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ClientSignUp";
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
        private CheckBox SubscribeCB;
        private Label FnameLbl;
        private Label Lnamelbl;
        private Label PhoneLbl;
        private Label MailLbl;
        private Label AddressLbl;
        private Label SubscribeLbl;
        private Button CreateBtn;
    }
}