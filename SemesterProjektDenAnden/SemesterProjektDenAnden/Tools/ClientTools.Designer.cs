namespace SemesterProjektDenAnden.Tools
{
    partial class ClientTools
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
            calculator_Click = new Button();
            Formular1 = new LinkLabel();
            Formular2 = new LinkLabel();
            værktøjerLbl = new Label();
            BuyForm1Btn = new Button();
            BuyForm2Btn = new Button();
            CalculatorLabel = new Label();
            SuspendLayout();
            // 
            // calculator_Click
            // 
            calculator_Click.BackColor = Color.Black;
            calculator_Click.Font = new Font("High Tower Text", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            calculator_Click.ForeColor = Color.White;
            calculator_Click.Location = new Point(699, 198);
            calculator_Click.Name = "calculator_Click";
            calculator_Click.Size = new Size(254, 65);
            calculator_Click.TabIndex = 0;
            calculator_Click.Text = "Låneberegner";
            calculator_Click.UseVisualStyleBackColor = false;
            calculator_Click.Click += Calculator_Click;
            // 
            // Formular1
            // 
            Formular1.AutoSize = true;
            Formular1.Font = new Font("High Tower Text", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Formular1.LinkColor = Color.Black;
            Formular1.Location = new Point(138, 217);
            Formular1.Name = "Formular1";
            Formular1.Size = new Size(108, 28);
            Formular1.TabIndex = 1;
            Formular1.TabStop = true;
            Formular1.Text = "Formular1";
            Formular1.LinkClicked += Formular1_Click;
            // 
            // Formular2
            // 
            Formular2.AutoSize = true;
            Formular2.Font = new Font("High Tower Text", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Formular2.LinkColor = Color.Black;
            Formular2.Location = new Point(138, 279);
            Formular2.Name = "Formular2";
            Formular2.Size = new Size(111, 28);
            Formular2.TabIndex = 2;
            Formular2.TabStop = true;
            Formular2.Text = "Formular2";
            Formular2.LinkClicked += Formular2_Clicked;
            // 
            // værktøjerLbl
            // 
            værktøjerLbl.AutoSize = true;
            værktøjerLbl.Font = new Font("High Tower Text", 36F, FontStyle.Regular, GraphicsUnit.Point);
            værktøjerLbl.ForeColor = Color.Black;
            værktøjerLbl.Location = new Point(65, 67);
            værktøjerLbl.Name = "værktøjerLbl";
            værktøjerLbl.Size = new Size(232, 57);
            værktøjerLbl.TabIndex = 3;
            værktøjerLbl.Text = "Værktøjer";
            // 
            // BuyForm1Btn
            // 
            BuyForm1Btn.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            BuyForm1Btn.Location = new Point(301, 223);
            BuyForm1Btn.Name = "BuyForm1Btn";
            BuyForm1Btn.Size = new Size(75, 23);
            BuyForm1Btn.TabIndex = 4;
            BuyForm1Btn.Text = "Køb";
            BuyForm1Btn.UseVisualStyleBackColor = true;
            BuyForm1Btn.Click += BuyForm1Btn_Click;
            // 
            // BuyForm2Btn
            // 
            BuyForm2Btn.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            BuyForm2Btn.Location = new Point(301, 285);
            BuyForm2Btn.Name = "BuyForm2Btn";
            BuyForm2Btn.Size = new Size(75, 23);
            BuyForm2Btn.TabIndex = 5;
            BuyForm2Btn.Text = "Køb";
            BuyForm2Btn.UseVisualStyleBackColor = true;
            BuyForm2Btn.Click += BuyForm2Btn_Click;
            // 
            // CalculatorLabel
            // 
            CalculatorLabel.AutoSize = true;
            CalculatorLabel.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            CalculatorLabel.ForeColor = Color.Red;
            CalculatorLabel.Location = new Point(688, 279);
            CalculatorLabel.Name = "CalculatorLabel";
            CalculatorLabel.Size = new Size(307, 18);
            CalculatorLabel.TabIndex = 6;
            CalculatorLabel.Text = "Køb abonnement for at få adgang til lånberegneren";
            // 
            // ClientTools
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1065, 655);
            Controls.Add(CalculatorLabel);
            Controls.Add(BuyForm2Btn);
            Controls.Add(BuyForm1Btn);
            Controls.Add(værktøjerLbl);
            Controls.Add(Formular2);
            Controls.Add(Formular1);
            Controls.Add(calculator_Click);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ClientTools";
            Text = "Tools";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button calculator_Click;
        private LinkLabel Formular1;
        private LinkLabel Formular2;
        protected internal Label værktøjerLbl;
        private Button BuyForm1Btn;
        private Button BuyForm2Btn;
        private Label CalculatorLabel;
    }
}