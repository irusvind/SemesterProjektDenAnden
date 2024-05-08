namespace SemesterProjektDenAnden.EmployeeForms
{
    partial class CreateCase
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
            workTitel = new TextBox();
            estimated_hours = new TextBox();
            employeeBox = new ComboBox();
            clientBox = new ComboBox();
            serviceBox = new ComboBox();
            createCaseBtn = new Button();
            endDateCal = new MonthCalendar();
            startDateCal = new MonthCalendar();
            SuspendLayout();
            // 
            // workTitel
            // 
            workTitel.BackColor = Color.Black;
            workTitel.ForeColor = Color.White;
            workTitel.Location = new Point(113, 46);
            workTitel.Name = "workTitel";
            workTitel.Size = new Size(100, 23);
            workTitel.TabIndex = 0;
            workTitel.Text = "Titel";
            // 
            // estimated_hours
            // 
            estimated_hours.BackColor = Color.Black;
            estimated_hours.ForeColor = Color.White;
            estimated_hours.Location = new Point(113, 208);
            estimated_hours.Name = "estimated_hours";
            estimated_hours.Size = new Size(100, 23);
            estimated_hours.TabIndex = 4;
            estimated_hours.Text = "50";
            // 
            // employeeBox
            // 
            employeeBox.BackColor = Color.Black;
            employeeBox.ForeColor = Color.White;
            employeeBox.FormattingEnabled = true;
            employeeBox.Location = new Point(113, 85);
            employeeBox.Name = "employeeBox";
            employeeBox.Size = new Size(121, 23);
            employeeBox.TabIndex = 7;
            // 
            // clientBox
            // 
            clientBox.BackColor = Color.Black;
            clientBox.ForeColor = Color.White;
            clientBox.FormattingEnabled = true;
            clientBox.Location = new Point(113, 248);
            clientBox.Name = "clientBox";
            clientBox.Size = new Size(121, 23);
            clientBox.TabIndex = 8;
            // 
            // serviceBox
            // 
            serviceBox.BackColor = Color.Black;
            serviceBox.ForeColor = Color.White;
            serviceBox.FormattingEnabled = true;
            serviceBox.Location = new Point(113, 289);
            serviceBox.Name = "serviceBox";
            serviceBox.Size = new Size(121, 23);
            serviceBox.TabIndex = 9;
            // 
            // createCaseBtn
            // 
            createCaseBtn.BackColor = Color.Black;
            createCaseBtn.ForeColor = Color.White;
            createCaseBtn.Location = new Point(420, 288);
            createCaseBtn.Name = "createCaseBtn";
            createCaseBtn.Size = new Size(75, 23);
            createCaseBtn.TabIndex = 10;
            createCaseBtn.Text = "Opret";
            createCaseBtn.UseVisualStyleBackColor = false;
            createCaseBtn.Click += createCaseBtn_Click;
            // 
            // endDateCal
            // 
            endDateCal.Location = new Point(570, 46);
            endDateCal.Name = "endDateCal";
            endDateCal.TabIndex = 11;
            // 
            // startDateCal
            // 
            startDateCal.Location = new Point(313, 46);
            startDateCal.Name = "startDateCal";
            startDateCal.TabIndex = 12;
            // 
            // CreateCase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1065, 655);
            Controls.Add(startDateCal);
            Controls.Add(endDateCal);
            Controls.Add(createCaseBtn);
            Controls.Add(serviceBox);
            Controls.Add(clientBox);
            Controls.Add(employeeBox);
            Controls.Add(estimated_hours);
            Controls.Add(workTitel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreateCase";
            Text = "CreateCase";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox workTitel;
        private TextBox estimated_hours;
        private ComboBox employeeBox;
        private ComboBox clientBox;
        private ComboBox serviceBox;
        private Button createCaseBtn;
        private MonthCalendar endDateCal;
        private MonthCalendar startDateCal;
    }
}