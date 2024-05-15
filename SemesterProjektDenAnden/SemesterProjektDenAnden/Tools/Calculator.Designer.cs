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
            label1 = new Label();
            sizeBox = new TextBox();
            rateBox = new TextBox();
            paymentPYearBox = new TextBox();
            calBtn = new Button();
            yearsBox = new TextBox();
            clearBtn = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            paymentAmount = new Label();
            paymentPYear = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.ForeColor = Color.White;
            label1.Location = new Point(178, 83);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 0;
            label1.Text = "Låne Beregner";
            // 
            // sizeBox
            // 
            sizeBox.BackColor = Color.Black;
            sizeBox.ForeColor = Color.White;
            sizeBox.Location = new Point(321, 197);
            sizeBox.Name = "sizeBox";
            sizeBox.Size = new Size(100, 23);
            sizeBox.TabIndex = 1;
            // 
            // rateBox
            // 
            rateBox.BackColor = Color.Black;
            rateBox.ForeColor = Color.White;
            rateBox.Location = new Point(321, 226);
            rateBox.Name = "rateBox";
            rateBox.Size = new Size(100, 23);
            rateBox.TabIndex = 2;
            // 
            // paymentPYearBox
            // 
            paymentPYearBox.BackColor = Color.Black;
            paymentPYearBox.ForeColor = Color.White;
            paymentPYearBox.Location = new Point(321, 255);
            paymentPYearBox.Name = "paymentPYearBox";
            paymentPYearBox.Size = new Size(100, 23);
            paymentPYearBox.TabIndex = 3;
            // 
            // calBtn
            // 
            calBtn.BackColor = Color.Black;
            calBtn.ForeColor = Color.White;
            calBtn.Location = new Point(277, 329);
            calBtn.Name = "calBtn";
            calBtn.Size = new Size(75, 23);
            calBtn.TabIndex = 4;
            calBtn.Text = "Beregn";
            calBtn.UseVisualStyleBackColor = false;
            calBtn.Click += button1_Click;
            // 
            // yearsBox
            // 
            yearsBox.BackColor = Color.Black;
            yearsBox.ForeColor = Color.White;
            yearsBox.Location = new Point(321, 284);
            yearsBox.Name = "yearsBox";
            yearsBox.Size = new Size(100, 23);
            yearsBox.TabIndex = 5;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(372, 329);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(75, 23);
            clearBtn.TabIndex = 6;
            clearBtn.Text = "button2";
            clearBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(213, 200);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 7;
            label2.Text = "Lånets størrelse";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(213, 229);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 8;
            label3.Text = "Rentefod p. a.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(213, 258);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 9;
            label4.Text = "Antal ydelser pr år";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(213, 287);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 10;
            label5.Text = "Antal år";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(213, 379);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 11;
            label6.Text = "Fast ydelse";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(213, 414);
            label7.Name = "label7";
            label7.Size = new Size(97, 15);
            label7.TabIndex = 12;
            label7.Text = "Fast ydelse per år";
            // 
            // paymentAmount
            // 
            paymentAmount.AutoSize = true;
            paymentAmount.Location = new Point(383, 379);
            paymentAmount.Name = "paymentAmount";
            paymentAmount.Size = new Size(38, 15);
            paymentAmount.TabIndex = 13;
            paymentAmount.Text = "label8";
            // 
            // paymentPYear
            // 
            paymentPYear.AutoSize = true;
            paymentPYear.Location = new Point(383, 414);
            paymentPYear.Name = "paymentPYear";
            paymentPYear.Size = new Size(38, 15);
            paymentPYear.TabIndex = 14;
            paymentPYear.Text = "label9";
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1065, 655);
            Controls.Add(paymentPYear);
            Controls.Add(paymentAmount);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(clearBtn);
            Controls.Add(yearsBox);
            Controls.Add(calBtn);
            Controls.Add(paymentPYearBox);
            Controls.Add(rateBox);
            Controls.Add(sizeBox);
            Controls.Add(label1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Calculator";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox sizeBox;
        private TextBox rateBox;
        private TextBox paymentPYearBox;
        private Button calBtn;
        private TextBox yearsBox;
        private Button clearBtn;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label paymentAmount;
        private Label paymentPYear;
    }
}