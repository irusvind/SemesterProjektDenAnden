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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            employeesDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            employeesDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeesDgv.Enabled = false;
            employeesDgv.Location = new Point(65, 151);
            employeesDgv.Name = "employeesDgv";
            employeesDgv.RowTemplate.Height = 25;
            employeesDgv.Size = new Size(930, 370);
            employeesDgv.TabIndex = 1;
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