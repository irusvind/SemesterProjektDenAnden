namespace SemesterProjektDenAnden.EmployeeForms
{
    partial class EmployeeSpec
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            employeeNrLbl = new Label();
            coursesDGV = new DataGridView();
            employeesLbl = new Label();
            PhoneTxt = new TextBox();
            FnameTxt = new TextBox();
            LnameTxt = new TextBox();
            maillbl = new Label();
            casesLbl = new Label();
            coursesLbl = new Label();
            label5 = new Label();
            LnameLbl = new Label();
            nameLbl = new Label();
            CasesDGV = new DataGridView();
            MailTxt = new TextBox();
            UpdateEmployeeBtn = new Button();
            addressTxt = new TextBox();
            label1 = new Label();
            changeCoursesBtn = new Button();
            employeeIdLb = new Label();
            ((System.ComponentModel.ISupportInitialize)coursesDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CasesDGV).BeginInit();
            SuspendLayout();
            // 
            // employeeNrLbl
            // 
            employeeNrLbl.AutoSize = true;
            employeeNrLbl.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            employeeNrLbl.Location = new Point(108, 157);
            employeeNrLbl.Name = "employeeNrLbl";
            employeeNrLbl.Size = new Size(111, 18);
            employeeNrLbl.TabIndex = 0;
            employeeNrLbl.Text = "Medarbejder nr. ";
            // 
            // coursesDGV
            // 
            coursesDGV.AllowUserToAddRows = false;
            coursesDGV.AllowUserToDeleteRows = false;
            coursesDGV.AllowUserToResizeColumns = false;
            coursesDGV.AllowUserToResizeRows = false;
            coursesDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            coursesDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            coursesDGV.BackgroundColor = Color.Black;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            coursesDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            coursesDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            coursesDGV.DefaultCellStyle = dataGridViewCellStyle2;
            coursesDGV.EditMode = DataGridViewEditMode.EditProgrammatically;
            coursesDGV.EnableHeadersVisualStyles = false;
            coursesDGV.GridColor = Color.DimGray;
            coursesDGV.Location = new Point(107, 409);
            coursesDGV.Name = "coursesDGV";
            coursesDGV.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Black;
            dataGridViewCellStyle3.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            coursesDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            coursesDGV.RowHeadersVisible = false;
            coursesDGV.SelectionMode = DataGridViewSelectionMode.CellSelect;
            coursesDGV.Size = new Size(300, 200);
            coursesDGV.TabIndex = 2;
            // 
            // employeesLbl
            // 
            employeesLbl.AutoSize = true;
            employeesLbl.BackColor = Color.Transparent;
            employeesLbl.Font = new Font("High Tower Text", 36F, FontStyle.Regular, GraphicsUnit.Point);
            employeesLbl.ForeColor = Color.Black;
            employeesLbl.Location = new Point(65, 67);
            employeesLbl.Name = "employeesLbl";
            employeesLbl.Size = new Size(370, 57);
            employeesLbl.TabIndex = 3;
            employeesLbl.Text = "Medarbejdernavn";
            // 
            // PhoneTxt
            // 
            PhoneTxt.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneTxt.Location = new Point(238, 241);
            PhoneTxt.Name = "PhoneTxt";
            PhoneTxt.Size = new Size(203, 24);
            PhoneTxt.TabIndex = 4;
            // 
            // FnameTxt
            // 
            FnameTxt.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            FnameTxt.Location = new Point(238, 183);
            FnameTxt.Name = "FnameTxt";
            FnameTxt.Size = new Size(203, 24);
            FnameTxt.TabIndex = 5;
            // 
            // LnameTxt
            // 
            LnameTxt.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            LnameTxt.Location = new Point(238, 212);
            LnameTxt.Name = "LnameTxt";
            LnameTxt.Size = new Size(203, 24);
            LnameTxt.TabIndex = 6;
            // 
            // maillbl
            // 
            maillbl.AutoSize = true;
            maillbl.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            maillbl.Location = new Point(108, 273);
            maillbl.Name = "maillbl";
            maillbl.Size = new Size(35, 18);
            maillbl.TabIndex = 7;
            maillbl.Text = "Mail";
            // 
            // casesLbl
            // 
            casesLbl.AutoSize = true;
            casesLbl.Font = new Font("High Tower Text", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            casesLbl.Location = new Point(473, 370);
            casesLbl.Name = "casesLbl";
            casesLbl.Size = new Size(64, 26);
            casesLbl.TabIndex = 8;
            casesLbl.Text = "Sager";
            // 
            // coursesLbl
            // 
            coursesLbl.AutoSize = true;
            coursesLbl.Font = new Font("High Tower Text", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            coursesLbl.Location = new Point(107, 370);
            coursesLbl.Name = "coursesLbl";
            coursesLbl.Size = new Size(75, 26);
            coursesLbl.TabIndex = 9;
            coursesLbl.Text = "Kurser";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(108, 244);
            label5.Name = "label5";
            label5.Size = new Size(27, 18);
            label5.TabIndex = 10;
            label5.Text = "Tlf";
            // 
            // LnameLbl
            // 
            LnameLbl.AutoSize = true;
            LnameLbl.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            LnameLbl.ForeColor = Color.Black;
            LnameLbl.Location = new Point(108, 215);
            LnameLbl.Name = "LnameLbl";
            LnameLbl.Size = new Size(66, 18);
            LnameLbl.TabIndex = 11;
            LnameLbl.Text = "Efternavn";
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            nameLbl.Location = new Point(108, 186);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(57, 18);
            nameLbl.TabIndex = 12;
            nameLbl.Text = "Fornavn";
            // 
            // CasesDGV
            // 
            CasesDGV.AllowUserToAddRows = false;
            CasesDGV.AllowUserToDeleteRows = false;
            CasesDGV.AllowUserToResizeColumns = false;
            CasesDGV.AllowUserToResizeRows = false;
            CasesDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            CasesDGV.BackgroundColor = Color.Black;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Black;
            dataGridViewCellStyle4.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            CasesDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            CasesDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.Black;
            dataGridViewCellStyle5.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            CasesDGV.DefaultCellStyle = dataGridViewCellStyle5;
            CasesDGV.EditMode = DataGridViewEditMode.EditProgrammatically;
            CasesDGV.EnableHeadersVisualStyles = false;
            CasesDGV.GridColor = Color.DimGray;
            CasesDGV.Location = new Point(473, 409);
            CasesDGV.Name = "CasesDGV";
            CasesDGV.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.Black;
            dataGridViewCellStyle6.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            CasesDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            CasesDGV.RowHeadersVisible = false;
            CasesDGV.SelectionMode = DataGridViewSelectionMode.CellSelect;
            CasesDGV.Size = new Size(525, 200);
            CasesDGV.TabIndex = 13;
            // 
            // MailTxt
            // 
            MailTxt.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            MailTxt.Location = new Point(238, 270);
            MailTxt.Name = "MailTxt";
            MailTxt.Size = new Size(203, 24);
            MailTxt.TabIndex = 14;
            // 
            // UpdateEmployeeBtn
            // 
            UpdateEmployeeBtn.BackColor = Color.Black;
            UpdateEmployeeBtn.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateEmployeeBtn.ForeColor = Color.White;
            UpdateEmployeeBtn.Location = new Point(766, 258);
            UpdateEmployeeBtn.Name = "UpdateEmployeeBtn";
            UpdateEmployeeBtn.Size = new Size(185, 30);
            UpdateEmployeeBtn.TabIndex = 16;
            UpdateEmployeeBtn.Text = "Opdater Medarbejder";
            UpdateEmployeeBtn.UseVisualStyleBackColor = false;
            UpdateEmployeeBtn.Click += UpdateEmployeeBtn_Click;
            // 
            // addressTxt
            // 
            addressTxt.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            addressTxt.Location = new Point(238, 300);
            addressTxt.Name = "addressTxt";
            addressTxt.Size = new Size(203, 24);
            addressTxt.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(107, 303);
            label1.Name = "label1";
            label1.Size = new Size(58, 18);
            label1.TabIndex = 18;
            label1.Text = "Adresse";
            // 
            // changeCoursesBtn
            // 
            changeCoursesBtn.BackColor = Color.Black;
            changeCoursesBtn.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            changeCoursesBtn.ForeColor = Color.White;
            changeCoursesBtn.Location = new Point(766, 294);
            changeCoursesBtn.Name = "changeCoursesBtn";
            changeCoursesBtn.Size = new Size(185, 30);
            changeCoursesBtn.TabIndex = 19;
            changeCoursesBtn.Text = "Ændre kurser";
            changeCoursesBtn.UseVisualStyleBackColor = false;
            changeCoursesBtn.Click += changeCoursesBtn_Click;
            // 
            // employeeIdLb
            // 
            employeeIdLb.AutoSize = true;
            employeeIdLb.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            employeeIdLb.Location = new Point(238, 160);
            employeeIdLb.Name = "employeeIdLb";
            employeeIdLb.Size = new Size(40, 18);
            employeeIdLb.TabIndex = 20;
            employeeIdLb.Text = "label2";
            // 
            // EmployeeSpec
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1065, 655);
            Controls.Add(employeeIdLb);
            Controls.Add(changeCoursesBtn);
            Controls.Add(label1);
            Controls.Add(addressTxt);
            Controls.Add(UpdateEmployeeBtn);
            Controls.Add(MailTxt);
            Controls.Add(CasesDGV);
            Controls.Add(nameLbl);
            Controls.Add(LnameLbl);
            Controls.Add(label5);
            Controls.Add(coursesLbl);
            Controls.Add(casesLbl);
            Controls.Add(maillbl);
            Controls.Add(LnameTxt);
            Controls.Add(FnameTxt);
            Controls.Add(PhoneTxt);
            Controls.Add(employeesLbl);
            Controls.Add(coursesDGV);
            Controls.Add(employeeNrLbl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeeSpec";
            Text = "EmployeeSpec";
            ((System.ComponentModel.ISupportInitialize)coursesDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)CasesDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label employeeNrLbl;
        private DataGridView coursesDGV;
        private Label employeesLbl;
        private TextBox PhoneTxt;
        private TextBox FnameTxt;
        private TextBox LnameTxt;
        private Label maillbl;
        private Label casesLbl;
        private Label coursesLbl;
        private Label label5;
        private Label LnameLbl;
        private Label nameLbl;
        private DataGridView CasesDGV;
        private TextBox MailTxt;
        private Button UpdateEmployeeBtn;
        private TextBox addressTxt;
        private Label label1;
        private Button changeCoursesBtn;
        private Label employeeIdLb;
    }
}