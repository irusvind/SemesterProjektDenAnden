namespace SemesterProjektDenAnden.Tools
{
    partial class Calculator
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
            sizeBox = new TextBox();
            rateBox = new TextBox();
            paymentPYearBox = new TextBox();
            calBtn = new Button();
            yearsBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            paymentAmount = new Label();
            paymentPYear = new Label();
            sagerLbl = new Label();
            descrptLbl = new Label();
            label1 = new Label();
            clearAllBtn = new Button();
            SuspendLayout();
            // 
            // sizeBox
            // 
            sizeBox.BackColor = Color.White;
            sizeBox.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            sizeBox.ForeColor = Color.Black;
            sizeBox.Location = new Point(268, 194);
            sizeBox.Name = "sizeBox";
            sizeBox.Size = new Size(153, 24);
            sizeBox.TabIndex = 1;
            // 
            // rateBox
            // 
            rateBox.BackColor = Color.White;
            rateBox.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            rateBox.ForeColor = Color.Black;
            rateBox.Location = new Point(268, 223);
            rateBox.Name = "rateBox";
            rateBox.Size = new Size(153, 24);
            rateBox.TabIndex = 2;
            // 
            // paymentPYearBox
            // 
            paymentPYearBox.BackColor = Color.White;
            paymentPYearBox.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            paymentPYearBox.ForeColor = Color.Black;
            paymentPYearBox.Location = new Point(268, 252);
            paymentPYearBox.Name = "paymentPYearBox";
            paymentPYearBox.Size = new Size(153, 24);
            paymentPYearBox.TabIndex = 3;
            // 
            // calBtn
            // 
            calBtn.BackColor = Color.Black;
            calBtn.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            calBtn.ForeColor = Color.White;
            calBtn.Location = new Point(83, 336);
            calBtn.Name = "calBtn";
            calBtn.Size = new Size(130, 30);
            calBtn.TabIndex = 5;
            calBtn.Text = "Beregn";
            calBtn.UseVisualStyleBackColor = false;
            calBtn.Click += button1_Click;
            // 
            // yearsBox
            // 
            yearsBox.BackColor = Color.White;
            yearsBox.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            yearsBox.ForeColor = Color.Black;
            yearsBox.Location = new Point(268, 281);
            yearsBox.Name = "yearsBox";
            yearsBox.Size = new Size(153, 24);
            yearsBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("High Tower Text", 10.875F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(83, 196);
            label2.Name = "label2";
            label2.Size = new Size(98, 19);
            label2.TabIndex = 7;
            label2.Text = "Lånets størrelse";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("High Tower Text", 10.875F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(83, 225);
            label3.Name = "label3";
            label3.Size = new Size(90, 19);
            label3.TabIndex = 8;
            label3.Text = "Rentefod p. a.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("High Tower Text", 10.875F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(83, 254);
            label4.Name = "label4";
            label4.Size = new Size(119, 19);
            label4.TabIndex = 9;
            label4.Text = "Antal ydelser pr år";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("High Tower Text", 10.875F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(83, 283);
            label5.Name = "label5";
            label5.Size = new Size(59, 19);
            label5.TabIndex = 10;
            label5.Text = "Antal år";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("High Tower Text", 10.875F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(83, 431);
            label6.Name = "label6";
            label6.Size = new Size(73, 19);
            label6.TabIndex = 11;
            label6.Text = "Fast ydelse";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("High Tower Text", 10.875F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(83, 466);
            label7.Name = "label7";
            label7.Size = new Size(111, 19);
            label7.TabIndex = 12;
            label7.Text = "Fast ydelse per år";
            // 
            // paymentAmount
            // 
            paymentAmount.AutoSize = true;
            paymentAmount.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            paymentAmount.Location = new Point(268, 431);
            paymentAmount.Name = "paymentAmount";
            paymentAmount.Size = new Size(25, 18);
            paymentAmount.TabIndex = 13;
            paymentAmount.Text = "FY";
            // 
            // paymentPYear
            // 
            paymentPYear.AutoSize = true;
            paymentPYear.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            paymentPYear.Location = new Point(268, 466);
            paymentPYear.Name = "paymentPYear";
            paymentPYear.Size = new Size(45, 18);
            paymentPYear.TabIndex = 14;
            paymentPYear.Text = "FYPA";
            // 
            // sagerLbl
            // 
            sagerLbl.AutoSize = true;
            sagerLbl.Font = new Font("High Tower Text", 36F, FontStyle.Italic, GraphicsUnit.Point);
            sagerLbl.ForeColor = Color.Black;
            sagerLbl.Location = new Point(65, 67);
            sagerLbl.Name = "sagerLbl";
            sagerLbl.Size = new Size(269, 57);
            sagerLbl.TabIndex = 15;
            sagerLbl.Text = "Låneberegner";
            // 
            // descrptLbl
            // 
            descrptLbl.AutoSize = true;
            descrptLbl.Font = new Font("High Tower Text", 10.875F, FontStyle.Italic, GraphicsUnit.Point);
            descrptLbl.Location = new Point(83, 141);
            descrptLbl.Name = "descrptLbl";
            descrptLbl.Size = new Size(391, 19);
            descrptLbl.TabIndex = 16;
            descrptLbl.Text = "Indtast dine værdier nedenfor, og find det lån der passer dig bedst.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("High Tower Text", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(83, 398);
            label1.Name = "label1";
            label1.Size = new Size(352, 15);
            label1.TabIndex = 17;
            label1.Text = "_____________________________________________________________________";
            // 
            // clearAllBtn
            // 
            clearAllBtn.BackColor = Color.Black;
            clearAllBtn.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            clearAllBtn.ForeColor = Color.White;
            clearAllBtn.Location = new Point(219, 336);
            clearAllBtn.Name = "clearAllBtn";
            clearAllBtn.Size = new Size(130, 30);
            clearAllBtn.TabIndex = 18;
            clearAllBtn.Text = "Ryd alt";
            clearAllBtn.UseVisualStyleBackColor = false;
            clearAllBtn.Click += clearAllBtn_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1065, 655);
            Controls.Add(clearAllBtn);
            Controls.Add(label1);
            Controls.Add(descrptLbl);
            Controls.Add(sagerLbl);
            Controls.Add(paymentPYear);
            Controls.Add(paymentAmount);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(yearsBox);
            Controls.Add(calBtn);
            Controls.Add(paymentPYearBox);
            Controls.Add(rateBox);
            Controls.Add(sizeBox);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Calculator";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox sizeBox;
        private TextBox rateBox;
        private TextBox paymentPYearBox;
        private Button calBtn;
        private TextBox yearsBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label paymentAmount;
        private Label paymentPYear;
        private Label sagerLbl;
        private Label descrptLbl;
        private Label label1;
        private Button clearAllBtn;
    }
}