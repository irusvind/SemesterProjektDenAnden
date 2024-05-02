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
            label1 = new Label();
            OverviewMyPagebtn = new Button();
            OverviewMyCasesbtn = new Button();
            overviewToolsbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(30, 25);
            label1.Name = "label1";
            label1.Size = new Size(188, 54);
            label1.TabIndex = 4;
            label1.Text = "Start side";
            // 
            // OverviewMyPagebtn
            // 
            OverviewMyPagebtn.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            OverviewMyPagebtn.Location = new Point(279, 165);
            OverviewMyPagebtn.Name = "OverviewMyPagebtn";
            OverviewMyPagebtn.Size = new Size(175, 123);
            OverviewMyPagebtn.TabIndex = 5;
            OverviewMyPagebtn.Text = "Min side";
            OverviewMyPagebtn.UseVisualStyleBackColor = true;
            OverviewMyPagebtn.Click += OverviewMyPagebtn_Click;
            // 
            // OverviewMyCasesbtn
            // 
            OverviewMyCasesbtn.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            OverviewMyCasesbtn.Location = new Point(645, 165);
            OverviewMyCasesbtn.Name = "OverviewMyCasesbtn";
            OverviewMyCasesbtn.Size = new Size(175, 123);
            OverviewMyCasesbtn.TabIndex = 6;
            OverviewMyCasesbtn.Text = "Mine sager";
            OverviewMyCasesbtn.UseVisualStyleBackColor = true;
            OverviewMyCasesbtn.Click += OverviewMyCasesbtn_Click;
            // 
            // overviewToolsbtn
            // 
            overviewToolsbtn.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            overviewToolsbtn.Location = new Point(279, 418);
            overviewToolsbtn.Name = "overviewToolsbtn";
            overviewToolsbtn.Size = new Size(175, 123);
            overviewToolsbtn.TabIndex = 7;
            overviewToolsbtn.Text = "Værktøjer";
            overviewToolsbtn.UseVisualStyleBackColor = true;
            overviewToolsbtn.Click += overviewToolsbtn_Click;
            // 
            // ClientOverview
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1065, 655);
            Controls.Add(overviewToolsbtn);
            Controls.Add(OverviewMyCasesbtn);
            Controls.Add(OverviewMyPagebtn);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "ClientOverview";
            Text = "ClientOverview";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button OverviewMyPagebtn;
        private Button OverviewMyCasesbtn;
        private Button overviewToolsbtn;
    }
}