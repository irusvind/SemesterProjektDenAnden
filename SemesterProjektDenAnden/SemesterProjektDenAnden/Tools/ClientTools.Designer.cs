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
            linkLabel2 = new LinkLabel();
            værktøjerLbl = new Label();
            SuspendLayout();
            // 
            // calculator_Click
            // 
            calculator_Click.BackColor = Color.Black;
            calculator_Click.Font = new Font("High Tower Text", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            calculator_Click.ForeColor = Color.White;
            calculator_Click.Location = new Point(426, 180);
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
            Formular1.Location = new Point(426, 276);
            Formular1.Name = "Formular1";
            Formular1.Size = new Size(108, 28);
            Formular1.TabIndex = 1;
            Formular1.TabStop = true;
            Formular1.Text = "Formular1";
            Formular1.LinkClicked += Formular1_Click;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("High Tower Text", 18F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(426, 338);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(111, 28);
            linkLabel2.TabIndex = 2;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Formular2";
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
            // ClientTools
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1065, 655);
            Controls.Add(værktøjerLbl);
            Controls.Add(linkLabel2);
            Controls.Add(Formular1);
            Controls.Add(calculator_Click);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ClientTools";
            Text = "Tools";
            Load += Tools_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button calculator_Click;
        private LinkLabel Formular1;
        private LinkLabel linkLabel2;
        protected internal Label værktøjerLbl;
    }
}