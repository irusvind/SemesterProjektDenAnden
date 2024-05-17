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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            transDescrpt = new Label();
            trandDisc = new TextBox();
            addServiceBtn = new Button();
            comboCaseYdelse = new ComboBox();
            updateBtn = new Button();
            employeeNameBox = new TextBox();
            employeeIdBox = new TextBox();
            EmployeeInfolbl = new Label();
            EmployeeNrLbl = new Label();
            advocatNameLbl = new Label();
            clientMailbox = new TextBox();
            endDateBox = new TextBox();
            usedHoursbox = new TextBox();
            kmBox = new TextBox();
            exhourBox = new TextBox();
            clientNamebox = new TextBox();
            clientPhoneBox = new TextBox();
            startDataBox = new TextBox();
            caseInfoLbl = new Label();
            clientInfolbl = new Label();
            kmlbl = new Label();
            UsedHoursLbl = new Label();
            endDateLbl = new Label();
            expectedHoursLbl = new Label();
            StartDateLbl = new Label();
            clientMailLbl = new Label();
            clientNrLbl = new Label();
            clientNamelbl = new Label();
            ydelserlbl = new Label();
            ydelserDgv = new DataGridView();
            sagsNavnNrLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)ydelserDgv).BeginInit();
            SuspendLayout();
            // 
            // transDescrpt
            // 
            transDescrpt.AutoSize = true;
            transDescrpt.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            transDescrpt.Location = new Point(98, 535);
            transDescrpt.Name = "transDescrpt";
            transDescrpt.Size = new Size(125, 18);
            transDescrpt.TabIndex = 63;
            transDescrpt.Text = "Kørsels beskrivelse";
            // 
            // trandDisc
            // 
            trandDisc.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            trandDisc.Location = new Point(274, 532);
            trandDisc.Name = "trandDisc";
            trandDisc.Size = new Size(196, 24);
            trandDisc.TabIndex = 62;
            // 
            // addServiceBtn
            // 
            addServiceBtn.BackColor = Color.Black;
            addServiceBtn.Font = new Font("High Tower Text", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            addServiceBtn.ForeColor = Color.White;
            addServiceBtn.Location = new Point(373, 317);
            addServiceBtn.Name = "addServiceBtn";
            addServiceBtn.Size = new Size(96, 25);
            addServiceBtn.TabIndex = 61;
            addServiceBtn.Text = "Tilføj";
            addServiceBtn.UseVisualStyleBackColor = false;
            addServiceBtn.Click += addServiceBtn_Click;
            // 
            // comboCaseYdelse
            // 
            comboCaseYdelse.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            comboCaseYdelse.FormattingEnabled = true;
            comboCaseYdelse.Location = new Point(246, 317);
            comboCaseYdelse.Name = "comboCaseYdelse";
            comboCaseYdelse.Size = new Size(121, 24);
            comboCaseYdelse.TabIndex = 60;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.Black;
            updateBtn.Font = new Font("High Tower Text", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            updateBtn.ForeColor = Color.White;
            updateBtn.Location = new Point(365, 562);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(105, 28);
            updateBtn.TabIndex = 59;
            updateBtn.Text = "Opdater";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // employeeNameBox
            // 
            employeeNameBox.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            employeeNameBox.Location = new Point(778, 384);
            employeeNameBox.Name = "employeeNameBox";
            employeeNameBox.Size = new Size(196, 24);
            employeeNameBox.TabIndex = 58;
            // 
            // employeeIdBox
            // 
            employeeIdBox.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            employeeIdBox.Location = new Point(778, 414);
            employeeIdBox.Name = "employeeIdBox";
            employeeIdBox.Size = new Size(196, 24);
            employeeIdBox.TabIndex = 57;
            // 
            // EmployeeInfolbl
            // 
            EmployeeInfolbl.AutoSize = true;
            EmployeeInfolbl.Font = new Font("High Tower Text", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            EmployeeInfolbl.Location = new Point(626, 354);
            EmployeeInfolbl.Name = "EmployeeInfolbl";
            EmployeeInfolbl.Size = new Size(118, 22);
            EmployeeInfolbl.TabIndex = 56;
            EmployeeInfolbl.Text = "Advokat info";
            // 
            // EmployeeNrLbl
            // 
            EmployeeNrLbl.AutoSize = true;
            EmployeeNrLbl.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            EmployeeNrLbl.Location = new Point(626, 418);
            EmployeeNrLbl.Name = "EmployeeNrLbl";
            EmployeeNrLbl.Size = new Size(107, 18);
            EmployeeNrLbl.TabIndex = 55;
            EmployeeNrLbl.Text = "Medarbejder nr.";
            // 
            // advocatNameLbl
            // 
            advocatNameLbl.AutoSize = true;
            advocatNameLbl.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            advocatNameLbl.Location = new Point(627, 385);
            advocatNameLbl.Name = "advocatNameLbl";
            advocatNameLbl.Size = new Size(58, 18);
            advocatNameLbl.TabIndex = 54;
            advocatNameLbl.Text = "Advokat";
            // 
            // clientMailbox
            // 
            clientMailbox.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            clientMailbox.Location = new Point(778, 218);
            clientMailbox.Name = "clientMailbox";
            clientMailbox.Size = new Size(196, 24);
            clientMailbox.TabIndex = 53;
            // 
            // endDateBox
            // 
            endDateBox.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            endDateBox.Location = new Point(274, 442);
            endDateBox.Name = "endDateBox";
            endDateBox.Size = new Size(196, 24);
            endDateBox.TabIndex = 52;
            // 
            // usedHoursbox
            // 
            usedHoursbox.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            usedHoursbox.Location = new Point(274, 472);
            usedHoursbox.Name = "usedHoursbox";
            usedHoursbox.Size = new Size(196, 24);
            usedHoursbox.TabIndex = 51;
            // 
            // kmBox
            // 
            kmBox.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            kmBox.Location = new Point(274, 502);
            kmBox.Name = "kmBox";
            kmBox.Size = new Size(196, 24);
            kmBox.TabIndex = 50;
            // 
            // exhourBox
            // 
            exhourBox.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            exhourBox.Location = new Point(274, 412);
            exhourBox.Name = "exhourBox";
            exhourBox.Size = new Size(196, 24);
            exhourBox.TabIndex = 49;
            // 
            // clientNamebox
            // 
            clientNamebox.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            clientNamebox.Location = new Point(778, 157);
            clientNamebox.Name = "clientNamebox";
            clientNamebox.Size = new Size(196, 24);
            clientNamebox.TabIndex = 48;
            // 
            // clientPhoneBox
            // 
            clientPhoneBox.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            clientPhoneBox.Location = new Point(778, 188);
            clientPhoneBox.Name = "clientPhoneBox";
            clientPhoneBox.Size = new Size(196, 24);
            clientPhoneBox.TabIndex = 47;
            // 
            // startDataBox
            // 
            startDataBox.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            startDataBox.Location = new Point(274, 382);
            startDataBox.Name = "startDataBox";
            startDataBox.Size = new Size(196, 24);
            startDataBox.TabIndex = 46;
            // 
            // caseInfoLbl
            // 
            caseInfoLbl.AutoSize = true;
            caseInfoLbl.Font = new Font("High Tower Text", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            caseInfoLbl.Location = new Point(98, 354);
            caseInfoLbl.Name = "caseInfoLbl";
            caseInfoLbl.Size = new Size(85, 22);
            caseInfoLbl.TabIndex = 45;
            caseInfoLbl.Text = "Sags info";
            // 
            // clientInfolbl
            // 
            clientInfolbl.AutoSize = true;
            clientInfolbl.Font = new Font("High Tower Text", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            clientInfolbl.Location = new Point(626, 130);
            clientInfolbl.Name = "clientInfolbl";
            clientInfolbl.Size = new Size(100, 22);
            clientInfolbl.TabIndex = 44;
            clientInfolbl.Text = "Klient info";
            // 
            // kmlbl
            // 
            kmlbl.AutoSize = true;
            kmlbl.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            kmlbl.Location = new Point(98, 505);
            kmlbl.Name = "kmlbl";
            kmlbl.Size = new Size(104, 18);
            kmlbl.TabIndex = 43;
            kmlbl.Text = "Kørte kilometer";
            // 
            // UsedHoursLbl
            // 
            UsedHoursLbl.AutoSize = true;
            UsedHoursLbl.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            UsedHoursLbl.Location = new Point(98, 475);
            UsedHoursLbl.Name = "UsedHoursLbl";
            UsedHoursLbl.Size = new Size(160, 18);
            UsedHoursLbl.TabIndex = 42;
            UsedHoursLbl.Text = "Akkumuleret timeforbrug";
            // 
            // endDateLbl
            // 
            endDateLbl.AutoSize = true;
            endDateLbl.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            endDateLbl.Location = new Point(98, 445);
            endDateLbl.Name = "endDateLbl";
            endDateLbl.Size = new Size(59, 18);
            endDateLbl.TabIndex = 41;
            endDateLbl.Text = "Slut dato";
            // 
            // expectedHoursLbl
            // 
            expectedHoursLbl.AutoSize = true;
            expectedHoursLbl.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            expectedHoursLbl.Location = new Point(98, 418);
            expectedHoursLbl.Name = "expectedHoursLbl";
            expectedHoursLbl.Size = new Size(141, 18);
            expectedHoursLbl.TabIndex = 40;
            expectedHoursLbl.Text = "Forventet timeforbrug";
            // 
            // StartDateLbl
            // 
            StartDateLbl.AutoSize = true;
            StartDateLbl.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            StartDateLbl.Location = new Point(98, 388);
            StartDateLbl.Name = "StartDateLbl";
            StartDateLbl.Size = new Size(65, 18);
            StartDateLbl.TabIndex = 39;
            StartDateLbl.Text = "Start dato";
            // 
            // clientMailLbl
            // 
            clientMailLbl.AutoSize = true;
            clientMailLbl.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            clientMailLbl.Location = new Point(626, 222);
            clientMailLbl.Name = "clientMailLbl";
            clientMailLbl.Size = new Size(70, 18);
            clientMailLbl.TabIndex = 38;
            clientMailLbl.Text = "Klient mail";
            // 
            // clientNrLbl
            // 
            clientNrLbl.AutoSize = true;
            clientNrLbl.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            clientNrLbl.Location = new Point(626, 192);
            clientNrLbl.Name = "clientNrLbl";
            clientNrLbl.Size = new Size(59, 18);
            clientNrLbl.TabIndex = 37;
            clientNrLbl.Text = "Klient tlf";
            // 
            // clientNamelbl
            // 
            clientNamelbl.AutoSize = true;
            clientNamelbl.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            clientNamelbl.Location = new Point(626, 161);
            clientNamelbl.Name = "clientNamelbl";
            clientNamelbl.Size = new Size(43, 18);
            clientNamelbl.TabIndex = 36;
            clientNamelbl.Text = "Klient";
            // 
            // ydelserlbl
            // 
            ydelserlbl.AutoSize = true;
            ydelserlbl.BackColor = Color.Transparent;
            ydelserlbl.Font = new Font("High Tower Text", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            ydelserlbl.ForeColor = Color.Black;
            ydelserlbl.Location = new Point(98, 130);
            ydelserlbl.Name = "ydelserlbl";
            ydelserlbl.Size = new Size(72, 22);
            ydelserlbl.TabIndex = 35;
            ydelserlbl.Text = "Ydelser";
            // 
            // ydelserDgv
            // 
            ydelserDgv.AllowUserToAddRows = false;
            ydelserDgv.AllowUserToDeleteRows = false;
            ydelserDgv.AllowUserToResizeColumns = false;
            ydelserDgv.AllowUserToResizeRows = false;
            ydelserDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            ydelserDgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            ydelserDgv.BackgroundColor = Color.Black;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ydelserDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ydelserDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            ydelserDgv.DefaultCellStyle = dataGridViewCellStyle2;
            ydelserDgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            ydelserDgv.EnableHeadersVisualStyles = false;
            ydelserDgv.GridColor = Color.DimGray;
            ydelserDgv.Location = new Point(98, 161);
            ydelserDgv.Name = "ydelserDgv";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Black;
            dataGridViewCellStyle3.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            ydelserDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            ydelserDgv.RowTemplate.Height = 25;
            ydelserDgv.SelectionMode = DataGridViewSelectionMode.CellSelect;
            ydelserDgv.Size = new Size(372, 150);
            ydelserDgv.TabIndex = 34;
            // 
            // sagsNavnNrLbl
            // 
            sagsNavnNrLbl.AutoSize = true;
            sagsNavnNrLbl.Font = new Font("High Tower Text", 36F, FontStyle.Regular, GraphicsUnit.Point);
            sagsNavnNrLbl.ForeColor = Color.Black;
            sagsNavnNrLbl.Location = new Point(90, 64);
            sagsNavnNrLbl.Name = "sagsNavnNrLbl";
            sagsNavnNrLbl.Size = new Size(277, 57);
            sagsNavnNrLbl.TabIndex = 33;
            sagsNavnNrLbl.Text = "Sagsnavn nr.";
            // 
            // CaseSpec
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1065, 655);
            Controls.Add(transDescrpt);
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "CaseSpec";
            Text = "CaseSpec";
            ((System.ComponentModel.ISupportInitialize)servicesDgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label transDescrpt;
        private TextBox trandDisc;
        private Button addServiceBtn;
        private ComboBox comboCaseYdelse;
        private Button updateBtn;
        private TextBox employeeNameBox;
        private TextBox employeeIdBox;
        private Label EmployeeInfolbl;
        private Label EmployeeNrLbl;
        private Label advocatNameLbl;
        private TextBox clientMailbox;
        private TextBox endDateBox;
        private TextBox usedHoursbox;
        private TextBox kmBox;
        private TextBox exhourBox;
        private TextBox clientNamebox;
        private TextBox clientPhoneBox;
        private TextBox startDataBox;
        private Label caseInfoLbl;
        private Label clientInfolbl;
        private Label kmlbl;
        private Label UsedHoursLbl;
        private Label endDateLbl;
        private Label expectedHoursLbl;
        private Label StartDateLbl;
        private Label clientMailLbl;
        private Label clientNrLbl;
        private Label clientNamelbl;
        private Label ydelserlbl;
        private DataGridView ydelserDgv;
        private Label sagsNavnNrLbl;
    }
}