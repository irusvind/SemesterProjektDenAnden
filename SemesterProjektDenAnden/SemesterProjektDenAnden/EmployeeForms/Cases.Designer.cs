namespace SemesterProjektDenAnden.EmployeeForms
{
    partial class Cases
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
            sagerLbl = new Label();
            sagerDgv = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)sagerDgv).BeginInit();
            SuspendLayout();
            // 
            // sagerLbl
            // 
            sagerLbl.AutoSize = true;
            sagerLbl.Font = new Font("High Tower Text", 36F, FontStyle.Regular, GraphicsUnit.Point);
            sagerLbl.ForeColor = Color.Black;
            sagerLbl.Location = new Point(65, 49);
            sagerLbl.Name = "sagerLbl";
            sagerLbl.Size = new Size(136, 57);
            sagerLbl.TabIndex = 0;
            sagerLbl.Text = "Sager";
            // 
            // sagerDgv
            // 
            sagerDgv.BackgroundColor = Color.Black;
            sagerDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            sagerDgv.Location = new Point(65, 151);
            sagerDgv.Name = "sagerDgv";
            sagerDgv.RowTemplate.Height = 25;
            sagerDgv.Size = new Size(922, 366);
            sagerDgv.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(863, 564);
            button1.Name = "button1";
            button1.Size = new Size(124, 35);
            button1.TabIndex = 2;
            button1.Text = "Opret ny sag";
            button1.UseVisualStyleBackColor = false;
            // 
            // Cases
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1065, 655);
            Controls.Add(button1);
            Controls.Add(sagerDgv);
            Controls.Add(sagerLbl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Cases";
            Text = "Cases";
            ((System.ComponentModel.ISupportInitialize)sagerDgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label sagerLbl;
        private DataGridView sagerDgv;
        private Button button1;
    }
}