namespace SemesterProjektDenAnden.EmployeeForms
{
    partial class EmployeeOverview
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
            Startsidelbl = new Label();
            sagerBtn = new Button();
            employeeBtn = new Button();
            clientBtn = new Button();
            toolsBtn = new Button();
            SuspendLayout();
            // 
            // Startsidelbl
            // 
            Startsidelbl.AutoSize = true;
            Startsidelbl.Font = new Font("High Tower Text", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Startsidelbl.Location = new Point(65, 67);
            Startsidelbl.Name = "Startsidelbl";
            Startsidelbl.Size = new Size(199, 57);
            Startsidelbl.TabIndex = 0;
            Startsidelbl.Text = "Startside";
            // 
            // sagerBtn
            // 
            sagerBtn.BackColor = Color.Black;
            sagerBtn.Font = new Font("High Tower Text", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            sagerBtn.ForeColor = Color.White;
            sagerBtn.Location = new Point(254, 167);
            sagerBtn.Name = "sagerBtn";
            sagerBtn.Size = new Size(250, 150);
            sagerBtn.TabIndex = 1;
            sagerBtn.Text = "Sager";
            sagerBtn.UseVisualStyleBackColor = false;
            sagerBtn.Click += sagerBtn_Click;
            // 
            // employeeBtn
            // 
            employeeBtn.BackColor = Color.Black;
            employeeBtn.Font = new Font("High Tower Text", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            employeeBtn.ForeColor = Color.White;
            employeeBtn.Location = new Point(254, 356);
            employeeBtn.Name = "employeeBtn";
            employeeBtn.Size = new Size(250, 150);
            employeeBtn.TabIndex = 2;
            employeeBtn.Text = "Medarbejdere";
            employeeBtn.UseVisualStyleBackColor = false;
            employeeBtn.Click += employeeBtn_Click;
            // 
            // clientBtn
            // 
            clientBtn.BackColor = Color.Black;
            clientBtn.Font = new Font("High Tower Text", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            clientBtn.ForeColor = Color.White;
            clientBtn.Location = new Point(550, 356);
            clientBtn.Name = "clientBtn";
            clientBtn.Size = new Size(250, 150);
            clientBtn.TabIndex = 3;
            clientBtn.Text = "Klienter";
            clientBtn.UseVisualStyleBackColor = false;
            clientBtn.Click += clientBtn_Click;
            // 
            // toolsBtn
            // 
            toolsBtn.BackColor = Color.Black;
            toolsBtn.Font = new Font("High Tower Text", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            toolsBtn.ForeColor = Color.White;
            toolsBtn.Location = new Point(550, 167);
            toolsBtn.Name = "toolsBtn";
            toolsBtn.Size = new Size(250, 150);
            toolsBtn.TabIndex = 4;
            toolsBtn.Text = "Værktøjer";
            toolsBtn.UseVisualStyleBackColor = false;
            toolsBtn.Click += toolsBtn_Click;
            // 
            // EmployeeOverview
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1065, 655);
            Controls.Add(toolsBtn);
            Controls.Add(clientBtn);
            Controls.Add(employeeBtn);
            Controls.Add(sagerBtn);
            Controls.Add(Startsidelbl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeeOverview";
            Text = "EmployeeOverview";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Startsidelbl;
        private Button sagerBtn;
        private Button employeeBtn;
        private Button clientBtn;
        private Button toolsBtn;
    }
}