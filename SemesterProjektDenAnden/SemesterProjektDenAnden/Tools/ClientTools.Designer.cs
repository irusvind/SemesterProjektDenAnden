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
            SuspendLayout();
            // 
            // button1
            // 
            calculator_Click.BackColor = Color.Black;
            calculator_Click.ForeColor = Color.White;
            calculator_Click.Location = new Point(382, 35);
            calculator_Click.Name = "button1";
            calculator_Click.Size = new Size(349, 113);
            calculator_Click.TabIndex = 0;
            calculator_Click.Text = "Værktøjer";
            calculator_Click.UseVisualStyleBackColor = false;
            calculator_Click.Click += Calculator_Click;
            // 
            // Formular1
            // 
            Formular1.AutoSize = true;
            Formular1.Location = new Point(382, 186);
            Formular1.Name = "Formular1";
            Formular1.Size = new Size(61, 15);
            Formular1.TabIndex = 1;
            Formular1.TabStop = true;
            Formular1.Text = "Formular1";
            Formular1.LinkClicked += Formular1_Click;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(382, 227);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(61, 15);
            linkLabel2.TabIndex = 2;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Formular2";
            // 
            // ClientTools
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.Black;
            ClientSize = new Size(1065, 655);
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
    }
}