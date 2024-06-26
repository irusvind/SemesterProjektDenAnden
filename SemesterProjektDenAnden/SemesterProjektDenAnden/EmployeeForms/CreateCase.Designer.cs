﻿namespace SemesterProjektDenAnden.EmployeeForms
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
            createCaseBtn = new Button();
            endDateCal = new MonthCalendar();
            startDateCal = new MonthCalendar();
            lblCreateCase = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // workTitel
            // 
            workTitel.BackColor = Color.Black;
            workTitel.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            workTitel.ForeColor = Color.White;
            workTitel.Location = new Point(272, 185);
            workTitel.Name = "workTitel";
            workTitel.Size = new Size(170, 24);
            workTitel.TabIndex = 0;
            workTitel.Text = "Titel";
            // 
            // estimated_hours
            // 
            estimated_hours.BackColor = Color.Black;
            estimated_hours.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            estimated_hours.ForeColor = Color.White;
            estimated_hours.Location = new Point(272, 336);
            estimated_hours.Name = "estimated_hours";
            estimated_hours.Size = new Size(170, 24);
            estimated_hours.TabIndex = 4;
            estimated_hours.Text = "50";
            // 
            // employeeBox
            // 
            employeeBox.BackColor = Color.Black;
            employeeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            employeeBox.FlatStyle = FlatStyle.Popup;
            employeeBox.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            employeeBox.ForeColor = Color.White;
            employeeBox.FormattingEnabled = true;
            employeeBox.Location = new Point(272, 224);
            employeeBox.Name = "employeeBox";
            employeeBox.Size = new Size(170, 24);
            employeeBox.TabIndex = 7;
            // 
            // clientBox
            // 
            clientBox.BackColor = Color.Black;
            clientBox.DropDownStyle = ComboBoxStyle.DropDownList;
            clientBox.FlatStyle = FlatStyle.Popup;
            clientBox.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            clientBox.ForeColor = Color.White;
            clientBox.FormattingEnabled = true;
            clientBox.Location = new Point(272, 376);
            clientBox.Name = "clientBox";
            clientBox.Size = new Size(170, 24);
            clientBox.TabIndex = 8;
            // 
            // createCaseBtn
            // 
            createCaseBtn.BackColor = Color.Black;
            createCaseBtn.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            createCaseBtn.ForeColor = Color.White;
            createCaseBtn.Location = new Point(789, 467);
            createCaseBtn.Name = "createCaseBtn";
            createCaseBtn.Size = new Size(145, 42);
            createCaseBtn.TabIndex = 10;
            createCaseBtn.Text = "Opret";
            createCaseBtn.UseVisualStyleBackColor = false;
            createCaseBtn.Click += createCaseBtn_Click;
            // 
            // endDateCal
            // 
            endDateCal.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            endDateCal.Location = new Point(763, 185);
            endDateCal.Name = "endDateCal";
            endDateCal.TabIndex = 11;
            endDateCal.TitleForeColor = Color.Black;
            endDateCal.TrailingForeColor = Color.DimGray;
            // 
            // startDateCal
            // 
            startDateCal.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            startDateCal.ForeColor = Color.Black;
            startDateCal.Location = new Point(574, 185);
            startDateCal.Name = "startDateCal";
            startDateCal.TabIndex = 12;
            startDateCal.TitleForeColor = Color.Black;
            startDateCal.TrailingForeColor = Color.DimGray;
            // 
            // lblCreateCase
            // 
            lblCreateCase.AutoSize = true;
            lblCreateCase.Font = new Font("High Tower Text", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblCreateCase.Location = new Point(65, 67);
            lblCreateCase.Name = "lblCreateCase";
            lblCreateCase.Size = new Size(219, 57);
            lblCreateCase.TabIndex = 13;
            lblCreateCase.Text = "Opret sag";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(141, 189);
            label1.Name = "label1";
            label1.Size = new Size(36, 18);
            label1.TabIndex = 15;
            label1.Text = "Titel";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(141, 228);
            label2.Name = "label2";
            label2.Size = new Size(58, 18);
            label2.TabIndex = 16;
            label2.Text = "Advokat";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(141, 340);
            label3.Name = "label3";
            label3.Size = new Size(111, 18);
            label3.TabIndex = 17;
            label3.Text = "Forventede timer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(141, 380);
            label4.Name = "label4";
            label4.Size = new Size(43, 18);
            label4.TabIndex = 18;
            label4.Text = "Klient";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("High Tower Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(574, 158);
            label6.Name = "label6";
            label6.Size = new Size(99, 18);
            label6.TabIndex = 20;
            label6.Text = "Vælg start dato";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("High Tower Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(763, 158);
            label7.Name = "label7";
            label7.Size = new Size(152, 18);
            label7.TabIndex = 21;
            label7.Text = "Vælg estimeret slut dato";
            // 
            // CreateCase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1065, 655);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblCreateCase);
            Controls.Add(startDateCal);
            Controls.Add(endDateCal);
            Controls.Add(createCaseBtn);
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
        private Button createCaseBtn;
        private MonthCalendar endDateCal;
        private MonthCalendar startDateCal;
        private Label lblCreateCase;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
    }
}