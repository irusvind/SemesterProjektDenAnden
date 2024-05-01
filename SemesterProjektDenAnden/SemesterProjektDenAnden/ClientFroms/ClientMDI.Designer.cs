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
            button4 = new Button();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(150, 653);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.WrapContents = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(overviewbtn);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(185, 58);
            panel1.TabIndex = 2;
            // 
            // overviewbtn
            // 
            overviewbtn.Location = new Point(-45, -17);
            overviewbtn.Name = "overviewbtn";
            overviewbtn.Size = new Size(234, 93);
            overviewbtn.TabIndex = 0;
            overviewbtn.Text = "Overview";
            overviewbtn.UseVisualStyleBackColor = true;
            overviewbtn.Click += overviewbtn_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(myPagebtn);
            panel2.Location = new Point(3, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(185, 58);
            panel2.TabIndex = 3;
            // 
            // myPagebtn
            // 
            myPagebtn.Location = new Point(-45, -22);
            myPagebtn.Name = "myPagebtn";
            myPagebtn.Size = new Size(234, 97);
            myPagebtn.TabIndex = 0;
            myPagebtn.Text = "My Page";
            myPagebtn.UseVisualStyleBackColor = true;
            myPagebtn.Click += myPagebtn_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(myCasesbtn);
            panel3.Location = new Point(3, 131);
            panel3.Name = "panel3";
            panel3.Size = new Size(185, 58);
            panel3.TabIndex = 4;
            // 
            // myCasesbtn
            // 
            myCasesbtn.Location = new Point(-45, -22);
            myCasesbtn.Name = "myCasesbtn";
            myCasesbtn.Size = new Size(234, 97);
            myCasesbtn.TabIndex = 0;
            myCasesbtn.Text = "My Cases";
            myCasesbtn.UseVisualStyleBackColor = true;
            myCasesbtn.Click += myCasesbtn_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(button4);
            panel4.Location = new Point(3, 195);
            panel4.Name = "panel4";
            panel4.Size = new Size(185, 58);
            panel4.TabIndex = 4;
            // 
            // button4
            // 
            button4.Location = new Point(-45, -20);
            button4.Name = "button4";
            button4.Size = new Size(234, 97);
            button4.TabIndex = 0;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // ClientMDI
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1182, 653);
            Controls.Add(flowLayoutPanel1);
            IsMdiContainer = true;
            Name = "ClientMDI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            FormClosing += ClientMDI_FormClosing;
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
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
        private Button button4;
    }
}