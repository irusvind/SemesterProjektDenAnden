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
            sagsNavnNrLbl = new Label();
            servicesDgv = new DataGridView();
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
            trandDisc = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)servicesDgv).BeginInit();
            SuspendLayout();
            // 
            // sagsNavnNrLbl
            // 
            sagsNavnNrLbl.AutoSize = true;
            sagsNavnNrLbl.Font = new Font("High Tower Text", 36F, FontStyle.Regular, GraphicsUnit.Point);
            sagsNavnNrLbl.ForeColor = Color.Black;
            sagsNavnNrLbl.Location = new Point(76, 67);
            sagsNavnNrLbl.Name = "sagsNavnNrLbl";
            sagsNavnNrLbl.Size = new Size(277, 57);
            sagsNavnNrLbl.TabIndex = 0;
            sagsNavnNrLbl.Text = "Sagsnavn nr.";
            // 
            // servicesDgv
            // 
            servicesDgv.AllowUserToAddRows = false;
            servicesDgv.AllowUserToDeleteRows = false;
            servicesDgv.AllowUserToResizeColumns = false;
            servicesDgv.AllowUserToResizeRows = false;
            servicesDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            servicesDgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            servicesDgv.BackgroundColor = Color.Black;
            //.Alignment = DataGridViewContentAlignment.MiddleLeft;
            //dataGridViewCellStyle1.BackColor = Color.Black;
            //dataGridViewCellStyle1.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            //dataGridViewCellStyle1.ForeColor = Color.White;
            //dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
            //dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            //dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            //ydelserDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            //ydelserDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            //dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            //dataGridViewCellStyle2.BackColor = Color.Black;
            //dataGridViewCellStyle2.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            //dataGridViewCellStyle2.ForeColor = Color.White;
            //dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            //dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            //dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            //servicesDgv.DefaultCellStyle = dataGridViewCellStyle2;
            servicesDgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            servicesDgv.EnableHeadersVisualStyles = false;
            servicesDgv.GridColor = Color.DimGray;
            servicesDgv.Location = new Point(84, 164);
            servicesDgv.Name = "servicesDgv";
            //dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            //dataGridViewCellStyle3.BackColor = Color.Black;
            //dataGridViewCellStyle3.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            //dataGridViewCellStyle3.ForeColor = Color.White;
            //dataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption;
            //dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            //dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            //servicesDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            servicesDgv.RowTemplate.Height = 25;
            servicesDgv.SelectionMode = DataGridViewSelectionMode.CellSelect;
            servicesDgv.Size = new Size(372, 150);
            servicesDgv.TabIndex = 1;
            // 
            // ydelserlbl
            // 
            ydelserlbl.AutoSize = true;
            ydelserlbl.BackColor = Color.Transparent;
            ydelserlbl.Font = new Font("High Tower Text", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            ydelserlbl.ForeColor = Color.Black;
            ydelserlbl.Location = new Point(84, 133);
            ydelserlbl.Name = "ydelserlbl";
            ydelserlbl.Size = new Size(72, 22);
            ydelserlbl.TabIndex = 2;
            ydelserlbl.Text = "Ydelser";
            // 
            // clientNamelbl
            // 
            clientNamelbl.AutoSize = true;
            clientNamelbl.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            clientNamelbl.Location = new Point(612, 164);
            clientNamelbl.Name = "clientNamelbl";
            clientNamelbl.Size = new Size(43, 18);
            clientNamelbl.TabIndex = 3;
            clientNamelbl.Text = "Klient";
            // 
            // clientNrLbl
            // 
            clientNrLbl.AutoSize = true;
            clientNrLbl.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            clientNrLbl.Location = new Point(612, 195);
            clientNrLbl.Name = "clientNrLbl";
            clientNrLbl.Size = new Size(59, 18);
            clientNrLbl.TabIndex = 4;
            clientNrLbl.Text = "Klient tlf";
            // 
            // clientMailLbl
            // 
            clientMailLbl.AutoSize = true;
            clientMailLbl.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            clientMailLbl.Location = new Point(612, 225);
            clientMailLbl.Name = "clientMailLbl";
            clientMailLbl.Size = new Size(70, 18);
            clientMailLbl.TabIndex = 5;
            clientMailLbl.Text = "Klient mail";
            // 
            // StartDateLbl
            // 
            StartDateLbl.AutoSize = true;
            StartDateLbl.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            StartDateLbl.Location = new Point(84, 391);
            StartDateLbl.Name = "StartDateLbl";
            StartDateLbl.Size = new Size(65, 18);
            StartDateLbl.TabIndex = 6;
            StartDateLbl.Text = "Start dato";
            // 
            // expectedHoursLbl
            // 
            expectedHoursLbl.AutoSize = true;
            expectedHoursLbl.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            expectedHoursLbl.Location = new Point(84, 421);
            expectedHoursLbl.Name = "expectedHoursLbl";
            expectedHoursLbl.Size = new Size(141, 18);
            expectedHoursLbl.TabIndex = 7;
            expectedHoursLbl.Text = "Forventet timeforbrug";
            // 
            // endDateLbl
            // 
            endDateLbl.AutoSize = true;
            endDateLbl.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            endDateLbl.Location = new Point(84, 448);
            endDateLbl.Name = "endDateLbl";
            endDateLbl.Size = new Size(59, 18);
            endDateLbl.TabIndex = 8;
            endDateLbl.Text = "Slut dato";
            // 
            // UsedHoursLbl
            // 
            UsedHoursLbl.AutoSize = true;
            UsedHoursLbl.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            UsedHoursLbl.Location = new Point(84, 478);
            UsedHoursLbl.Name = "UsedHoursLbl";
            UsedHoursLbl.Size = new Size(160, 18);
            UsedHoursLbl.TabIndex = 9;
            UsedHoursLbl.Text = "Akkumuleret timeforbrug";
            // 
            // kmlbl
            // 
            kmlbl.AutoSize = true;
            kmlbl.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            kmlbl.Location = new Point(84, 508);
            kmlbl.Name = "kmlbl";
            kmlbl.Size = new Size(104, 18);
            kmlbl.TabIndex = 10;
            kmlbl.Text = "Kørte kilometer";
            // 
            // clientInfolbl
            // 
            clientInfolbl.AutoSize = true;
            clientInfolbl.Font = new Font("High Tower Text", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            clientInfolbl.Location = new Point(612, 133);
            clientInfolbl.Name = "clientInfolbl";
            clientInfolbl.Size = new Size(100, 22);
            clientInfolbl.TabIndex = 11;
            clientInfolbl.Text = "Klient info";
            // 
            // caseInfoLbl
            // 
            caseInfoLbl.AutoSize = true;
            caseInfoLbl.Font = new Font("High Tower Text", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            caseInfoLbl.Location = new Point(84, 357);
            caseInfoLbl.Name = "caseInfoLbl";
            caseInfoLbl.Size = new Size(85, 22);
            caseInfoLbl.TabIndex = 12;
            caseInfoLbl.Text = "Sags info";
            // 
            // startDataBox
            // 
            startDataBox.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            startDataBox.Location = new Point(260, 385);
            startDataBox.Name = "startDataBox";
            startDataBox.Size = new Size(196, 24);
            startDataBox.TabIndex = 14;
            // 
            // clientPhoneBox
            // 
            clientPhoneBox.Font = new Font("Microsoft Sans Serif", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            clientPhoneBox.Location = new Point(764, 191);
            clientPhoneBox.Name = "clientPhoneBox";
            clientPhoneBox.Size = new Size(196, 24);
            clientPhoneBox.TabIndex = 15;
            // 
            // clientNamebox
            // 
            clientNamebox.Font = new Font("Microsoft Sans Serif", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            clientNamebox.Location = new Point(764, 160);
            clientNamebox.Name = "clientNamebox";
            clientNamebox.Size = new Size(196, 24);
            clientNamebox.TabIndex = 16;
            // 
            // exhourBox
            // 
            exhourBox.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            exhourBox.Location = new Point(260, 415);
            exhourBox.Name = "exhourBox";
            exhourBox.Size = new Size(196, 24);
            exhourBox.TabIndex = 17;
            // 
            // kmBox
            // 
            kmBox.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            kmBox.Location = new Point(260, 505);
            kmBox.Name = "kmBox";
            kmBox.Size = new Size(196, 24);
            kmBox.TabIndex = 18;
            // 
            // usedHoursbox
            // 
            usedHoursbox.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            usedHoursbox.Location = new Point(260, 475);
            usedHoursbox.Name = "usedHoursbox";
            usedHoursbox.Size = new Size(196, 24);
            usedHoursbox.TabIndex = 19;
            // 
            // endDateBox
            // 
            endDateBox.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            endDateBox.Location = new Point(260, 445);
            endDateBox.Name = "endDateBox";
            endDateBox.Size = new Size(196, 24);
            endDateBox.TabIndex = 20;
            // 
            // clientMailbox
            // 
            clientMailbox.Font = new Font("Microsoft Sans Serif", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            clientMailbox.Location = new Point(764, 221);
            clientMailbox.Name = "clientMailbox";
            clientMailbox.Size = new Size(196, 24);
            clientMailbox.TabIndex = 21;
            // 
            // employeeNameBox
            // 
            employeeNameBox.Font = new Font("Microsoft Sans Serif", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            employeeNameBox.Location = new Point(764, 387);
            employeeNameBox.Name = "employeeNameBox";
            employeeNameBox.Size = new Size(196, 24);
            employeeNameBox.TabIndex = 27;
            // 
            // employeeIdBox
            // 
            employeeIdBox.Font = new Font("Microsoft Sans Serif", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            employeeIdBox.Location = new Point(764, 417);
            employeeIdBox.Name = "employeeIdBox";
            employeeIdBox.Size = new Size(196, 24);
            employeeIdBox.TabIndex = 26;
            // 
            // EmployeeInfolbl
            // 
            EmployeeInfolbl.AutoSize = true;
            EmployeeInfolbl.Font = new Font("High Tower Text", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            EmployeeInfolbl.Location = new Point(612, 357);
            EmployeeInfolbl.Name = "EmployeeInfolbl";
            EmployeeInfolbl.Size = new Size(118, 22);
            EmployeeInfolbl.TabIndex = 25;
            EmployeeInfolbl.Text = "Advokat info";
            // 
            // EmployeeNrLbl
            // 
            EmployeeNrLbl.AutoSize = true;
            EmployeeNrLbl.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            EmployeeNrLbl.Location = new Point(612, 421);
            EmployeeNrLbl.Name = "EmployeeNrLbl";
            EmployeeNrLbl.Size = new Size(107, 18);
            EmployeeNrLbl.TabIndex = 23;
            EmployeeNrLbl.Text = "Medarbejder nr.";
            // 
            // advocatNameLbl
            // 
            advocatNameLbl.AutoSize = true;
            advocatNameLbl.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            advocatNameLbl.Location = new Point(613, 388);
            advocatNameLbl.Name = "advocatNameLbl";
            advocatNameLbl.Size = new Size(58, 18);
            advocatNameLbl.TabIndex = 22;
            advocatNameLbl.Text = "Advokat";
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.Black;
            updateBtn.Font = new Font("High Tower Text", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            updateBtn.ForeColor = Color.White;
            updateBtn.Location = new Point(351, 565);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(105, 28);
            updateBtn.TabIndex = 28;
            updateBtn.Text = "Opdater";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // comboCaseYdelse
            // 
            comboCaseYdelse.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            comboCaseYdelse.FormattingEnabled = true;
            comboCaseYdelse.Location = new Point(232, 320);
            comboCaseYdelse.Name = "comboCaseYdelse";
            comboCaseYdelse.Size = new Size(121, 24);
            comboCaseYdelse.TabIndex = 29;
            // 
            // addServiceBtn
            // 
            addServiceBtn.BackColor = Color.Black;
            addServiceBtn.Font = new Font("High Tower Text", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            addServiceBtn.ForeColor = Color.White;
            addServiceBtn.Location = new Point(359, 320);
            addServiceBtn.Name = "addServiceBtn";
            addServiceBtn.Size = new Size(96, 25);
            addServiceBtn.TabIndex = 30;
            addServiceBtn.Text = "Tilføj";
            addServiceBtn.UseVisualStyleBackColor = false;
            addServiceBtn.Click += AddServiceBtn_Click;
            // 
            // trandDisc
            // 
            trandDisc.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            trandDisc.Location = new Point(260, 535);
            trandDisc.Name = "trandDisc";
            trandDisc.Size = new Size(196, 24);
            trandDisc.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(84, 538);
            label1.Name = "label1";
            label1.Size = new Size(125, 18);
            label1.TabIndex = 32;
            label1.Text = "Kørsels beskrivelse";
            // 
            // CaseSpec
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1065, 655);
            Controls.Add(label1);
            Controls.Add(trandDisc);
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
            Controls.Add(servicesDgv);
            Controls.Add(sagsNavnNrLbl);
            Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CaseSpec";
            Text = "CaseSpec";
            ((System.ComponentModel.ISupportInitialize)servicesDgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label sagsNavnNrLbl;
        private DataGridView servicesDgv;
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
        private TextBox trandDisc;
        private Label label1;
    }
}