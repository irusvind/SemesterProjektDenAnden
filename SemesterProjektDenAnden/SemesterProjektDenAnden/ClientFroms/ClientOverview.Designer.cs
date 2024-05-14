namespace SemesterProjektDenAnden.ClientFroms
{
    partial class ClientOverview
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
            OverviewMyPagebtn = new Button();
            OverviewMyCasesbtn = new Button();
            overviewToolsbtn = new Button();
            Startsidelbl = new Label();
            SuspendLayout();
            // 
            // OverviewMyPagebtn
            // 
            OverviewMyPagebtn.BackColor = Color.Black;
            OverviewMyPagebtn.Font = new Font("High Tower Text", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            OverviewMyPagebtn.ForeColor = Color.White;
            OverviewMyPagebtn.Location = new Point(254, 167);
            OverviewMyPagebtn.Name = "OverviewMyPagebtn";
            OverviewMyPagebtn.Size = new Size(250, 150);
            OverviewMyPagebtn.TabIndex = 5;
            OverviewMyPagebtn.Text = "Min side";
            OverviewMyPagebtn.UseVisualStyleBackColor = false;
            OverviewMyPagebtn.MouseEnter += Button_MouseEnter;
            OverviewMyPagebtn.MouseLeave += Button_MouseLeave;
            // 
            // OverviewMyCasesbtn
            // 
            OverviewMyCasesbtn.BackColor = Color.Black;
            OverviewMyCasesbtn.Font = new Font("High Tower Text", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            OverviewMyCasesbtn.ForeColor = Color.White;
            OverviewMyCasesbtn.Location = new Point(555, 167);
            OverviewMyCasesbtn.Name = "OverviewMyCasesbtn";
            OverviewMyCasesbtn.Size = new Size(250, 150);
            OverviewMyCasesbtn.TabIndex = 6;
            OverviewMyCasesbtn.Text = "Mine sager";
            OverviewMyCasesbtn.UseVisualStyleBackColor = false;
            OverviewMyCasesbtn.MouseEnter += Button_MouseEnter;
            OverviewMyCasesbtn.MouseLeave += Button_MouseLeave;
            // 
            // overviewToolsbtn
            // 
            overviewToolsbtn.BackColor = Color.Black;
            overviewToolsbtn.Font = new Font("High Tower Text", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            overviewToolsbtn.ForeColor = Color.White;
            overviewToolsbtn.Location = new Point(254, 356);
            overviewToolsbtn.Name = "overviewToolsbtn";
            overviewToolsbtn.Size = new Size(250, 150);
            overviewToolsbtn.TabIndex = 7;
            overviewToolsbtn.Text = "Værktøjer";
            overviewToolsbtn.UseVisualStyleBackColor = false;
            overviewToolsbtn.MouseEnter += Button_MouseEnter;
            overviewToolsbtn.MouseLeave += Button_MouseLeave;
            // 
            // Startsidelbl
            // 
            Startsidelbl.AutoSize = true;
            Startsidelbl.Font = new Font("High Tower Text", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Startsidelbl.Location = new Point(65, 67);
            Startsidelbl.Name = "Startsidelbl";
            Startsidelbl.Size = new Size(199, 57);
            Startsidelbl.TabIndex = 9;
            Startsidelbl.Text = "Startside";
            // 
            // ClientOverview
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1065, 655);
            Controls.Add(Startsidelbl);
            Controls.Add(overviewToolsbtn);
            Controls.Add(OverviewMyCasesbtn);
            Controls.Add(OverviewMyPagebtn);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "ClientOverview";
            Text = "ClientOverview";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button OverviewMyPagebtn;
        private Button OverviewMyCasesbtn;
        private Button overviewToolsbtn;
        private Label Startsidelbl;
    }
}