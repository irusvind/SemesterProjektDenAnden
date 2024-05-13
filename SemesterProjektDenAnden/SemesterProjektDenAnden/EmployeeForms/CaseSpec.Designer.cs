namespace SemesterProjektDenAnden.EmployeeForms
{
    partial class CaseSpec
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            sagsNavnNrLbl = new Label();
            ydelserDgv = new DataGridView();
            ydelserlbl = new Label();
            clientNamelbl = new Label();
            clientNrLbl = new Label();
            clientMailLbl = new Label();
            StartDateLbl = new Label();
            expectedHoursLbl = new Label();
            endDateLbl = new Label();
            UsedHoursLbl = new Label();
            kmlbl = new Label();
            clientInfolbl = new Label();
            caseInfoLbl = new Label();
            startDataBox = new TextBox();
            clientPhoneBox = new TextBox();
            clientNamebox = new TextBox();
            exhourBox = new TextBox();
            kmBox = new TextBox();
            usedHoursbox = new TextBox();
            endDateBox = new TextBox();
            clientMailbox = new TextBox();
            employeeNameBox = new TextBox();
            employeeIdBox = new TextBox();
            EmployeeInfolbl = new Label();
            EmployeeNrLbl = new Label();
            advocatNameLbl = new Label();
            updateBtn = new Button();
            comboCaseYdelse = new ComboBox();
            addServiceBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)ydelserDgv).BeginInit();
            SuspendLayout();
            // 
            // sagsNavnNrLbl
            // 
            sagsNavnNrLbl.AutoSize = true;
            sagsNavnNrLbl.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point);
            sagsNavnNrLbl.ForeColor = Color.Black;
            sagsNavnNrLbl.Location = new Point(67, 61);
            sagsNavnNrLbl.Name = "sagsNavnNrLbl";
            sagsNavnNrLbl.Size = new Size(308, 55);
            sagsNavnNrLbl.TabIndex = 0;
            sagsNavnNrLbl.Text = "Sagsnavn nr.";
            // 
            // ydelserDgv
            // 
            ydelserDgv.BackgroundColor = Color.Black;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ydelserDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ydelserDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ydelserDgv.Location = new Point(83, 164);
            ydelserDgv.Name = "ydelserDgv";
            ydelserDgv.RowTemplate.Height = 25;
            ydelserDgv.Size = new Size(372, 150);
            ydelserDgv.TabIndex = 1;
            // 
            // ydelserlbl
            // 
            ydelserlbl.AutoSize = true;
            ydelserlbl.BackColor = Color.Transparent;
            ydelserlbl.Font = new Font("Microsoft Sans Serif", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            ydelserlbl.ForeColor = Color.Black;
            ydelserlbl.Location = new Point(83, 133);
            ydelserlbl.Name = "ydelserlbl";
            ydelserlbl.Size = new Size(87, 26);
            ydelserlbl.TabIndex = 2;
            ydelserlbl.Text = "Ydelser";
            // 
            // clientNamelbl
            // 
            clientNamelbl.AutoSize = true;
            clientNamelbl.Font = new Font("Microsoft Sans Serif", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            clientNamelbl.Location = new Point(612, 164);
            clientNamelbl.Name = "clientNamelbl";
            clientNamelbl.Size = new Size(44, 18);
            clientNamelbl.TabIndex = 3;
            clientNamelbl.Text = "Klient";
            // 
            // clientNrLbl
            // 
            clientNrLbl.AutoSize = true;
            clientNrLbl.Font = new Font("Microsoft Sans Serif", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            clientNrLbl.Location = new Point(612, 194);
            clientNrLbl.Name = "clientNrLbl";
            clientNrLbl.Size = new Size(59, 18);
            clientNrLbl.TabIndex = 4;
            clientNrLbl.Text = "Klient tlf";
            // 
            // clientMailLbl
            // 
            clientMailLbl.AutoSize = true;
            clientMailLbl.Font = new Font("Microsoft Sans Serif", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            clientMailLbl.Location = new Point(612, 224);
            clientMailLbl.Name = "clientMailLbl";
            clientMailLbl.Size = new Size(75, 18);
            clientMailLbl.TabIndex = 5;
            clientMailLbl.Text = "Klient mail";
            // 
            // StartDateLbl
            // 
            StartDateLbl.AutoSize = true;
            StartDateLbl.Font = new Font("Microsoft Sans Serif", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            StartDateLbl.Location = new Point(84, 391);
            StartDateLbl.Name = "StartDateLbl";
            StartDateLbl.Size = new Size(72, 18);
            StartDateLbl.TabIndex = 6;
            StartDateLbl.Text = "Start dato";
            // 
            // expectedHoursLbl
            // 
            expectedHoursLbl.AutoSize = true;
            expectedHoursLbl.Font = new Font("Microsoft Sans Serif", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            expectedHoursLbl.Location = new Point(84, 418);
            expectedHoursLbl.Name = "expectedHoursLbl";
            expectedHoursLbl.Size = new Size(149, 18);
            expectedHoursLbl.TabIndex = 7;
            expectedHoursLbl.Text = "Forventet timeforbrug";
            // 
            // endDateLbl
            // 
            endDateLbl.AutoSize = true;
            endDateLbl.Font = new Font("Microsoft Sans Serif", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            endDateLbl.Location = new Point(84, 448);
            endDateLbl.Name = "endDateLbl";
            endDateLbl.Size = new Size(66, 18);
            endDateLbl.TabIndex = 8;
            endDateLbl.Text = "Slut dato";
            // 
            // UsedHoursLbl
            // 
            UsedHoursLbl.AutoSize = true;
            UsedHoursLbl.Font = new Font("Microsoft Sans Serif", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            UsedHoursLbl.Location = new Point(83, 478);
            UsedHoursLbl.Name = "UsedHoursLbl";
            UsedHoursLbl.Size = new Size(169, 18);
            UsedHoursLbl.TabIndex = 9;
            UsedHoursLbl.Text = "Akkumuleret timeforbrug";
            // 
            // kmlbl
            // 
            kmlbl.AutoSize = true;
            kmlbl.Font = new Font("Microsoft Sans Serif", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            kmlbl.Location = new Point(84, 508);
            kmlbl.Name = "kmlbl";
            kmlbl.Size = new Size(109, 18);
            kmlbl.TabIndex = 10;
            kmlbl.Text = "Kørte kilometer";
            // 
            // clientInfolbl
            // 
            clientInfolbl.AutoSize = true;
            clientInfolbl.Font = new Font("Microsoft Sans Serif", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            clientInfolbl.Location = new Point(612, 131);
            clientInfolbl.Name = "clientInfolbl";
            clientInfolbl.Size = new Size(108, 26);
            clientInfolbl.TabIndex = 11;
            clientInfolbl.Text = "Klient info";
            // 
            // caseInfoLbl
            // 
            caseInfoLbl.AutoSize = true;
            caseInfoLbl.Font = new Font("Microsoft Sans Serif", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            caseInfoLbl.Location = new Point(83, 357);
            caseInfoLbl.Name = "caseInfoLbl";
            caseInfoLbl.Size = new Size(103, 26);
            caseInfoLbl.TabIndex = 12;
            caseInfoLbl.Text = "Sags info";
            // 
            // startDataBox
            // 
            startDataBox.Location = new Point(259, 385);
            startDataBox.Name = "startDataBox";
            startDataBox.Size = new Size(196, 24);
            startDataBox.TabIndex = 14;
            // 
            // clientPhoneBox
            // 
            clientPhoneBox.Location = new Point(743, 191);
            clientPhoneBox.Name = "clientPhoneBox";
            clientPhoneBox.Size = new Size(196, 24);
            clientPhoneBox.TabIndex = 15;
            // 
            // clientNamebox
            // 
            clientNamebox.Location = new Point(743, 161);
            clientNamebox.Name = "clientNamebox";
            clientNamebox.Size = new Size(196, 24);
            clientNamebox.TabIndex = 16;
            // 
            // exhourBox
            // 
            exhourBox.Location = new Point(259, 415);
            exhourBox.Name = "exhourBox";
            exhourBox.Size = new Size(196, 24);
            exhourBox.TabIndex = 17;
            // 
            // kmBox
            // 
            kmBox.Location = new Point(259, 505);
            kmBox.Name = "kmBox";
            kmBox.Size = new Size(196, 24);
            kmBox.TabIndex = 18;
            // 
            // usedHoursbox
            // 
            usedHoursbox.Location = new Point(259, 475);
            usedHoursbox.Name = "usedHoursbox";
            usedHoursbox.Size = new Size(196, 24);
            usedHoursbox.TabIndex = 19;
            // 
            // endDateBox
            // 
            endDateBox.Location = new Point(259, 445);
            endDateBox.Name = "endDateBox";
            endDateBox.Size = new Size(196, 24);
            endDateBox.TabIndex = 20;
            // 
            // clientMailbox
            // 
            clientMailbox.Location = new Point(743, 221);
            clientMailbox.Name = "clientMailbox";
            clientMailbox.Size = new Size(196, 24);
            clientMailbox.TabIndex = 21;
            // 
            // employeeNameBox
            // 
            employeeNameBox.Location = new Point(743, 385);
            employeeNameBox.Name = "employeeNameBox";
            employeeNameBox.Size = new Size(196, 24);
            employeeNameBox.TabIndex = 27;
            // 
            // employeeIdBox
            // 
            employeeIdBox.Location = new Point(743, 415);
            employeeIdBox.Name = "employeeIdBox";
            employeeIdBox.Size = new Size(196, 24);
            employeeIdBox.TabIndex = 26;
            // 
            // EmployeeInfolbl
            // 
            EmployeeInfolbl.AutoSize = true;
            EmployeeInfolbl.Font = new Font("Microsoft Sans Serif", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            EmployeeInfolbl.Location = new Point(612, 357);
            EmployeeInfolbl.Name = "EmployeeInfolbl";
            EmployeeInfolbl.Size = new Size(132, 26);
            EmployeeInfolbl.TabIndex = 25;
            EmployeeInfolbl.Text = "Advokat info";
            // 
            // EmployeeNrLbl
            // 
            EmployeeNrLbl.AutoSize = true;
            EmployeeNrLbl.Font = new Font("Microsoft Sans Serif", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            EmployeeNrLbl.Location = new Point(612, 418);
            EmployeeNrLbl.Name = "EmployeeNrLbl";
            EmployeeNrLbl.Size = new Size(111, 18);
            EmployeeNrLbl.TabIndex = 23;
            EmployeeNrLbl.Text = "Medarbejder nr.";
            // 
            // advocatNameLbl
            // 
            advocatNameLbl.AutoSize = true;
            advocatNameLbl.Font = new Font("Microsoft Sans Serif", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            advocatNameLbl.Location = new Point(612, 388);
            advocatNameLbl.Name = "advocatNameLbl";
            advocatNameLbl.Size = new Size(61, 18);
            advocatNameLbl.TabIndex = 22;
            advocatNameLbl.Text = "Advokat";
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(259, 553);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(75, 23);
            updateBtn.TabIndex = 28;
            updateBtn.Text = "Opdater";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // comboCaseYdelse
            // 
            comboCaseYdelse.FormattingEnabled = true;
            comboCaseYdelse.Location = new Point(259, 320);
            comboCaseYdelse.Name = "comboCaseYdelse";
            comboCaseYdelse.Size = new Size(121, 25);
            comboCaseYdelse.TabIndex = 29;
            // 
            // addServiceBtn
            // 
            addServiceBtn.Location = new Point(386, 322);
            addServiceBtn.Name = "addServiceBtn";
            addServiceBtn.Size = new Size(75, 23);
            addServiceBtn.TabIndex = 30;
            addServiceBtn.Text = "Tiltøj";
            addServiceBtn.UseVisualStyleBackColor = true;
            addServiceBtn.Click += addServiceBtn_Click;
            // 
            // CaseSpec
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1065, 655);
            Controls.Add(addServiceBtn);
            Controls.Add(comboCaseYdelse);
            Controls.Add(updateBtn);
            Controls.Add(employeeNameBox);
            Controls.Add(employeeIdBox);
            Controls.Add(EmployeeInfolbl);
            Controls.Add(EmployeeNrLbl);
            Controls.Add(advocatNameLbl);
            Controls.Add(clientMailbox);
            Controls.Add(endDateBox);
            Controls.Add(usedHoursbox);
            Controls.Add(kmBox);
            Controls.Add(exhourBox);
            Controls.Add(clientNamebox);
            Controls.Add(clientPhoneBox);
            Controls.Add(startDataBox);
            Controls.Add(caseInfoLbl);
            Controls.Add(clientInfolbl);
            Controls.Add(kmlbl);
            Controls.Add(UsedHoursLbl);
            Controls.Add(endDateLbl);
            Controls.Add(expectedHoursLbl);
            Controls.Add(StartDateLbl);
            Controls.Add(clientMailLbl);
            Controls.Add(clientNrLbl);
            Controls.Add(clientNamelbl);
            Controls.Add(ydelserlbl);
            Controls.Add(ydelserDgv);
            Controls.Add(sagsNavnNrLbl);
            Font = new Font("Microsoft Sans Serif", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CaseSpec";
            Text = "CaseSpec";
            ((System.ComponentModel.ISupportInitialize)ydelserDgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label sagsNavnNrLbl;
        private DataGridView ydelserDgv;
        private Label ydelserlbl;
        private Label clientNamelbl;
        private Label clientNrLbl;
        private Label clientMailLbl;
        private Label StartDateLbl;
        private Label expectedHoursLbl;
        private Label endDateLbl;
        private Label UsedHoursLbl;
        private Label kmlbl;
        private Label clientInfolbl;
        private Label caseInfoLbl;
        private TextBox startDataBox;
        private TextBox clientPhoneBox;
        private TextBox clientNamebox;
        private TextBox exhourBox;
        private TextBox kmBox;
        private TextBox usedHoursbox;
        private TextBox endDateBox;
        private TextBox clientMailbox;
        private TextBox textBox9;
        private TextBox employeeNameBox;
        private TextBox employeeIdBox;
        private Label EmployeeInfolbl;
        private Label label2;
        private Label EmployeeNrLbl;
        private Label advocatNameLbl;
        private Button updateBtn;
        private ComboBox comboCaseYdelse;
        private Button addServiceBtn;
    }
}