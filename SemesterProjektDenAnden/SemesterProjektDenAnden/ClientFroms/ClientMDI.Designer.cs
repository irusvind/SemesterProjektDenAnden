namespace SemesterProjektDenAnden.ClientFroms
{
    partial class ClientMDI
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            overviewbtn = new Button();
            panel2 = new Panel();
            myPagebtn = new Button();
            panel3 = new Panel();
            myCasesbtn = new Button();
            panel4 = new Panel();
            Toolsbtn = new Button();
            panel5 = new Panel();
            Logoutbtn = new Button();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.Black;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(120, 661);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.WrapContents = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(overviewbtn);
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(148, 46);
            panel1.TabIndex = 2;
            // 
            // overviewbtn
            // 
            overviewbtn.BackColor = Color.Black;
            overviewbtn.ForeColor = Color.White;
            overviewbtn.Location = new Point(-36, -14);
            overviewbtn.Margin = new Padding(2);
            overviewbtn.Name = "overviewbtn";
            overviewbtn.Size = new Size(187, 74);
            overviewbtn.TabIndex = 0;
            overviewbtn.Text = "Startside";
            overviewbtn.UseVisualStyleBackColor = false;
            overviewbtn.Click += overviewbtn_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(myPagebtn);
            panel2.Location = new Point(2, 52);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(148, 46);
            panel2.TabIndex = 3;
            // 
            // myPagebtn
            // 
            myPagebtn.BackColor = Color.Black;
            myPagebtn.ForeColor = Color.White;
            myPagebtn.Location = new Point(-36, -18);
            myPagebtn.Margin = new Padding(2);
            myPagebtn.Name = "myPagebtn";
            myPagebtn.Size = new Size(187, 78);
            myPagebtn.TabIndex = 0;
            myPagebtn.Text = "Min Side";
            myPagebtn.UseVisualStyleBackColor = false;
            myPagebtn.Click += myPagebtn_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(myCasesbtn);
            panel3.Location = new Point(2, 102);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(148, 46);
            panel3.TabIndex = 4;
            // 
            // myCasesbtn
            // 
            myCasesbtn.BackColor = Color.Black;
            myCasesbtn.ForeColor = Color.White;
            myCasesbtn.Location = new Point(-36, -18);
            myCasesbtn.Margin = new Padding(2);
            myCasesbtn.Name = "myCasesbtn";
            myCasesbtn.Size = new Size(187, 78);
            myCasesbtn.TabIndex = 0;
            myCasesbtn.Text = "Mine sager";
            myCasesbtn.UseVisualStyleBackColor = false;
            myCasesbtn.Click += myCasesbtn_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(Toolsbtn);
            panel4.Location = new Point(2, 152);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(148, 46);
            panel4.TabIndex = 4;
            // 
            // Toolsbtn
            // 
            Toolsbtn.BackColor = Color.Black;
            Toolsbtn.ForeColor = Color.White;
            Toolsbtn.Location = new Point(-36, -17);
            Toolsbtn.Margin = new Padding(2);
            Toolsbtn.Name = "Toolsbtn";
            Toolsbtn.Size = new Size(187, 78);
            Toolsbtn.TabIndex = 0;
            Toolsbtn.Text = "Værktøjer";
            Toolsbtn.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(Logoutbtn);
            panel5.Location = new Point(2, 202);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(148, 46);
            panel5.TabIndex = 5;
            // 
            // Logoutbtn
            // 
            Logoutbtn.BackColor = Color.Black;
            Logoutbtn.ForeColor = Color.White;
            Logoutbtn.Location = new Point(-36, -18);
            Logoutbtn.Margin = new Padding(2);
            Logoutbtn.Name = "Logoutbtn";
            Logoutbtn.Size = new Size(187, 78);
            Logoutbtn.TabIndex = 3;
            Logoutbtn.Text = "Log ud";
            Logoutbtn.UseVisualStyleBackColor = false;
            Logoutbtn.Click += Logoutbtn_Click;
            // 
            // ClientMDI
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1184, 661);
            Controls.Add(flowLayoutPanel1);
            IsMdiContainer = true;
            Margin = new Padding(2);
            Name = "ClientMDI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            FormClosing += ClientMDI_FormClosing;
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Button overviewbtn;
        private Panel panel2;
        private Button myPagebtn;
        private Panel panel3;
        private Button myCasesbtn;
        private Panel panel4;
        private Button Toolsbtn;
        private Panel panel5;
        private Button Logoutbtn;
    }
}