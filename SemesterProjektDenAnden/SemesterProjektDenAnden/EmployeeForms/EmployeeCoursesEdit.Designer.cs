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
            label1 = new Label();
            possibleCoursesDGV = new DataGridView();
            chosenCoursesDGV = new DataGridView();
            OKBtn = new Button();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)possibleCoursesDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chosenCoursesDGV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("High Tower Text", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(86, 56);
            label1.Name = "label1";
            label1.Size = new Size(133, 57);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // possibleCoursesDGV
            // 
            possibleCoursesDGV.AllowUserToAddRows = false;
            possibleCoursesDGV.AllowUserToDeleteRows = false;
            possibleCoursesDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            possibleCoursesDGV.BackgroundColor = Color.Black;
            possibleCoursesDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            possibleCoursesDGV.Location = new Point(86, 168);
            possibleCoursesDGV.MultiSelect = false;
            possibleCoursesDGV.Name = "possibleCoursesDGV";
            possibleCoursesDGV.RowTemplate.Height = 25;
            possibleCoursesDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            possibleCoursesDGV.Size = new Size(300, 200);
            possibleCoursesDGV.TabIndex = 1;
            possibleCoursesDGV.CellDoubleClick += PossibleCoursesDGV_CellDoubleClick;
            // 
            // chosenCoursesDGV
            // 
            chosenCoursesDGV.AllowUserToAddRows = false;
            chosenCoursesDGV.AllowUserToDeleteRows = false;
            chosenCoursesDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            chosenCoursesDGV.BackgroundColor = Color.Black;
            chosenCoursesDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            chosenCoursesDGV.Location = new Point(581, 168);
            chosenCoursesDGV.MultiSelect = false;
            chosenCoursesDGV.Name = "chosenCoursesDGV";
            chosenCoursesDGV.RowTemplate.Height = 25;
            chosenCoursesDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            chosenCoursesDGV.Size = new Size(300, 200);
            chosenCoursesDGV.TabIndex = 2;
            chosenCoursesDGV.CellDoubleClick += ChosenCoursesDGV_CellDoubleClick;
            // 
            // OKBtn
            // 
            OKBtn.Font = new Font("High Tower Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            OKBtn.Location = new Point(581, 483);
            OKBtn.Name = "OKBtn";
            OKBtn.Size = new Size(75, 23);
            OKBtn.TabIndex = 4;
            OKBtn.Text = "OK";
            OKBtn.UseVisualStyleBackColor = true;
            OKBtn.Click += OKBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("High Tower Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(86, 146);
            label2.Name = "label2";
            label2.Size = new Size(103, 19);
            label2.TabIndex = 5;
            label2.Text = "Mulige Kurser";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("High Tower Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(581, 146);
            label3.Name = "label3";
            label3.Size = new Size(99, 19);
            label3.TabIndex = 6;
            label3.Text = "Valgte kurser";
            // 
            // EmployeeCoursesEdit
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1065, 655);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(OKBtn);
            Controls.Add(chosenCoursesDGV);
            Controls.Add(possibleCoursesDGV);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeeCoursesEdit";
            Text = "EmployeeCoursesEdit";
            ((System.ComponentModel.ISupportInitialize)possibleCoursesDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)chosenCoursesDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView possibleCoursesDGV;
        private DataGridView chosenCoursesDGV;
        private Button OKBtn;
        private Label label2;
        private Label label3;
    }
}