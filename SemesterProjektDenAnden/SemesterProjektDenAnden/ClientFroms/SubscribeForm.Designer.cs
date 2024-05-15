namespace SemesterProjektDenAnden.ClientFroms
{
    partial class SubscribeForm
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
            btnPay = new Button();
            btnCancel = new Button();
            CB1mdr = new CheckBox();
            CB6mdr = new CheckBox();
            CB3mdr = new CheckBox();
            CB12mdr = new CheckBox();
            lblSubcribe = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnPay
            // 
            btnPay.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            btnPay.Location = new Point(316, 292);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(121, 29);
            btnPay.TabIndex = 0;
            btnPay.Text = "Gå til betaling";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(125, 292);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(121, 29);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Annuller";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // CB1mdr
            // 
            CB1mdr.AutoSize = true;
            CB1mdr.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            CB1mdr.ForeColor = Color.White;
            CB1mdr.Location = new Point(117, 131);
            CB1mdr.Name = "CB1mdr";
            CB1mdr.Size = new Size(129, 22);
            CB1mdr.TabIndex = 2;
            CB1mdr.Text = "1 måned - 999 kr.";
            CB1mdr.UseVisualStyleBackColor = true;
            // 
            // CB6mdr
            // 
            CB6mdr.AutoSize = true;
            CB6mdr.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            CB6mdr.ForeColor = Color.White;
            CB6mdr.Location = new Point(117, 210);
            CB6mdr.Name = "CB6mdr";
            CB6mdr.Size = new Size(149, 22);
            CB6mdr.TabIndex = 3;
            CB6mdr.Text = "6 måneder - 3299 kr.";
            CB6mdr.UseVisualStyleBackColor = true;
            // 
            // CB3mdr
            // 
            CB3mdr.AutoSize = true;
            CB3mdr.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            CB3mdr.ForeColor = Color.White;
            CB3mdr.Location = new Point(316, 131);
            CB3mdr.Name = "CB3mdr";
            CB3mdr.Size = new Size(148, 22);
            CB3mdr.TabIndex = 4;
            CB3mdr.Text = "3 måneder - 1749 kr.";
            CB3mdr.UseVisualStyleBackColor = true;
            // 
            // CB12mdr
            // 
            CB12mdr.AutoSize = true;
            CB12mdr.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            CB12mdr.ForeColor = Color.White;
            CB12mdr.Location = new Point(316, 210);
            CB12mdr.Name = "CB12mdr";
            CB12mdr.Size = new Size(155, 22);
            CB12mdr.TabIndex = 5;
            CB12mdr.Text = "12 måneder - 5555 kr. ";
            CB12mdr.UseVisualStyleBackColor = true;
            // 
            // lblSubcribe
            // 
            lblSubcribe.AutoSize = true;
            lblSubcribe.Font = new Font("High Tower Text", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubcribe.ForeColor = Color.White;
            lblSubcribe.Location = new Point(172, 29);
            lblSubcribe.Name = "lblSubcribe";
            lblSubcribe.Size = new Size(210, 26);
            lblSubcribe.TabIndex = 6;
            lblSubcribe.Text = "Vælg dit abonnement";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(71, 73);
            label1.Name = "label1";
            label1.Size = new Size(414, 18);
            label1.TabIndex = 7;
            label1.Text = "Vælg nedenfor hvor mange måneder du ønsker at have abonnement.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(71, 73);
            label2.Name = "label2";
            label2.Size = new Size(0, 18);
            label2.TabIndex = 8;
            // 
            // SubscribeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(551, 393);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblSubcribe);
            Controls.Add(CB12mdr);
            Controls.Add(CB3mdr);
            Controls.Add(CB6mdr);
            Controls.Add(CB1mdr);
            Controls.Add(btnCancel);
            Controls.Add(btnPay);
            Name = "SubscribeForm";
            Text = "SubcribeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPay;
        private Button btnCancel;
        private CheckBox CB1mdr;
        private CheckBox CB6mdr;
        private CheckBox CB3mdr;
        private CheckBox CB12mdr;
        private Label lblSubcribe;
        private Label label1;
        private Label label2;
    }
}