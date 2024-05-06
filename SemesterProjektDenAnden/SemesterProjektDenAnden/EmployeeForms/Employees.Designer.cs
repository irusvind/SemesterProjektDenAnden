namespace SemesterProjektDenAnden.EmployeeForms
{
    partial class Employees
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            employeesLbl = new Label();
            employeesDgv = new DataGridView();
            OpretEmployeeBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)employeesDgv).BeginInit();
            SuspendLayout();
            // 
            // employeesLbl
            // 
            employeesLbl.AutoSize = true;
            employeesLbl.BackColor = Color.Transparent;
            employeesLbl.Font = new Font("High Tower Text", 36F, FontStyle.Regular, GraphicsUnit.Point);
            employeesLbl.ForeColor = Color.Black;
            employeesLbl.Location = new Point(65, 67);
            employeesLbl.Name = "employeesLbl";
            employeesLbl.Size = new Size(297, 57);
            employeesLbl.TabIndex = 0;
            employeesLbl.Text = "Medarbejdere";
            // 
            // employeesDgv
            // 
            employeesDgv.BackgroundColor = Color.Black;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Black;
            dataGridViewCellStyle3.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            employeesDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            employeesDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Black;
            dataGridViewCellStyle4.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            employeesDgv.DefaultCellStyle = dataGridViewCellStyle4;
            employeesDgv.Enabled = false;
            employeesDgv.Location = new Point(65, 151);
            employeesDgv.Name = "employeesDgv";
            employeesDgv.RowTemplate.Height = 25;
            employeesDgv.Size = new Size(930, 370);
            employeesDgv.TabIndex = 1;
            employeesDgv.CellContentClick += employeesDgv_CellContentClick;
            // 
            // OpretEmployeeBtn
            // 
            OpretEmployeeBtn.BackColor = Color.Black;
            OpretEmployeeBtn.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            OpretEmployeeBtn.ForeColor = Color.White;
            OpretEmployeeBtn.Location = new Point(815, 568);
            OpretEmployeeBtn.Name = "OpretEmployeeBtn";
            OpretEmployeeBtn.Size = new Size(180, 37);
            OpretEmployeeBtn.TabIndex = 2;
            OpretEmployeeBtn.Text = "Opret ny medarbejder";
            OpretEmployeeBtn.UseVisualStyleBackColor = false;
            OpretEmployeeBtn.Click += OpretEmployeeBtn_Click;
            // 
            // Employees
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1065, 655);
            Controls.Add(OpretEmployeeBtn);
            Controls.Add(employeesDgv);
            Controls.Add(employeesLbl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Employees";
            Text = "Employees";
            ((System.ComponentModel.ISupportInitialize)employeesDgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label employeesLbl;
        private DataGridView employeesDgv;
        private Button OpretEmployeeBtn;
    }
}