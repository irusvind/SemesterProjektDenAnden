namespace SemesterProjektDenAnden.EmployeeForms
{
    partial class EmployeeCoursesEdit
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
            lblCourses = new Label();
            possibleCoursesDGV = new DataGridView();
            chosenCoursesDGV = new DataGridView();
            OKBtn = new Button();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)possibleCoursesDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chosenCoursesDGV).BeginInit();
            SuspendLayout();
            // 
            // lblCourses
            // 
            lblCourses.AutoSize = true;
            lblCourses.Font = new Font("High Tower Text", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblCourses.Location = new Point(65, 67);
            lblCourses.Name = "lblCourses";
            lblCourses.Size = new Size(160, 57);
            lblCourses.TabIndex = 0;
            lblCourses.Text = "Kurser";
            // 
            // possibleCoursesDGV
            // 
            possibleCoursesDGV.AllowUserToAddRows = false;
            possibleCoursesDGV.AllowUserToDeleteRows = false;
            possibleCoursesDGV.AllowUserToResizeColumns = false;
            possibleCoursesDGV.AllowUserToResizeRows = false;
            possibleCoursesDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            possibleCoursesDGV.BackgroundColor = Color.Black;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            possibleCoursesDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            possibleCoursesDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            possibleCoursesDGV.DefaultCellStyle = dataGridViewCellStyle2;
            possibleCoursesDGV.EditMode = DataGridViewEditMode.EditProgrammatically;
            possibleCoursesDGV.EnableHeadersVisualStyles = false;
            possibleCoursesDGV.GridColor = Color.DimGray;
            possibleCoursesDGV.Location = new Point(86, 168);
            possibleCoursesDGV.MultiSelect = false;
            possibleCoursesDGV.Name = "possibleCoursesDGV";
            possibleCoursesDGV.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Black;
            dataGridViewCellStyle3.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            possibleCoursesDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            possibleCoursesDGV.RowHeadersVisible = false;
            possibleCoursesDGV.RowTemplate.Height = 25;
            possibleCoursesDGV.SelectionMode = DataGridViewSelectionMode.CellSelect;
            possibleCoursesDGV.Size = new Size(300, 200);
            possibleCoursesDGV.TabIndex = 1;
            possibleCoursesDGV.CellDoubleClick += PossibleCoursesDGV_CellDoubleClick;
            // 
            // chosenCoursesDGV
            // 
            chosenCoursesDGV.AllowUserToAddRows = false;
            chosenCoursesDGV.AllowUserToDeleteRows = false;
            chosenCoursesDGV.AllowUserToResizeColumns = false;
            chosenCoursesDGV.AllowUserToResizeRows = false;
            chosenCoursesDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            chosenCoursesDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            chosenCoursesDGV.BackgroundColor = Color.Black;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Black;
            dataGridViewCellStyle4.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            chosenCoursesDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            chosenCoursesDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.Black;
            dataGridViewCellStyle5.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            chosenCoursesDGV.DefaultCellStyle = dataGridViewCellStyle5;
            chosenCoursesDGV.EditMode = DataGridViewEditMode.EditProgrammatically;
            chosenCoursesDGV.EnableHeadersVisualStyles = false;
            chosenCoursesDGV.GridColor = Color.DimGray;
            chosenCoursesDGV.Location = new Point(581, 168);
            chosenCoursesDGV.MultiSelect = false;
            chosenCoursesDGV.Name = "chosenCoursesDGV";
            chosenCoursesDGV.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.Black;
            dataGridViewCellStyle6.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            chosenCoursesDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            chosenCoursesDGV.RowHeadersVisible = false;
            chosenCoursesDGV.RowTemplate.Height = 25;
            chosenCoursesDGV.SelectionMode = DataGridViewSelectionMode.CellSelect;
            chosenCoursesDGV.Size = new Size(300, 200);
            chosenCoursesDGV.TabIndex = 2;
            chosenCoursesDGV.CellDoubleClick += ChosenCoursesDGV_CellDoubleClick;
            // 
            // OKBtn
            // 
            OKBtn.BackColor = Color.Black;
            OKBtn.Font = new Font("High Tower Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            OKBtn.ForeColor = Color.White;
            OKBtn.Location = new Point(706, 451);
            OKBtn.Name = "OKBtn";
            OKBtn.Size = new Size(175, 41);
            OKBtn.TabIndex = 4;
            OKBtn.Text = "Godkend ændringer";
            OKBtn.UseVisualStyleBackColor = false;
            OKBtn.Click += OKBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("High Tower Text", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(86, 146);
            label2.Name = "label2";
            label2.Size = new Size(130, 22);
            label2.TabIndex = 5;
            label2.Text = "Mulige Kurser";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("High Tower Text", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(581, 146);
            label3.Name = "label3";
            label3.Size = new Size(118, 22);
            label3.TabIndex = 6;
            label3.Text = "Valgte kurser";
            // 
            // EmployeeCoursesEdit
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1065, 655);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(OKBtn);
            Controls.Add(chosenCoursesDGV);
            Controls.Add(possibleCoursesDGV);
            Controls.Add(lblCourses);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeeCoursesEdit";
            Text = "EmployeeCoursesEdit";
            ((System.ComponentModel.ISupportInitialize)possibleCoursesDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)chosenCoursesDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCourses;
        private DataGridView possibleCoursesDGV;
        private DataGridView chosenCoursesDGV;
        private Button OKBtn;
        private Label label2;
        private Label label3;
    }
}