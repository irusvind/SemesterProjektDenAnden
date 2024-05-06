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
            employeeNrLbl = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            employeesLbl = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            maillbl = new Label();
            casesLbl = new Label();
            coursesLbl = new Label();
            label5 = new Label();
            LnameLbl = new Label();
            nameLbl = new Label();
            dataGridView2 = new DataGridView();
            textBox5 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(238, 154);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(203, 24);
            textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Black;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(108, 409);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(333, 150);
            dataGridView1.TabIndex = 2;
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
            // textBox2
            // 
            textBox2.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(238, 241);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(203, 24);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(238, 183);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(203, 24);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(238, 212);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(203, 24);
            textBox4.TabIndex = 6;
            // 
            // maillbl
            // 
            maillbl.AutoSize = true;
            maillbl.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            maillbl.Location = new Point(108, 272);
            maillbl.Name = "maillbl";
            maillbl.Size = new Size(35, 18);
            maillbl.TabIndex = 7;
            maillbl.Text = "Mail";
            // 
            // casesLbl
            // 
            casesLbl.AutoSize = true;
            casesLbl.Font = new Font("High Tower Text", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            casesLbl.Location = new Point(618, 370);
            casesLbl.Name = "casesLbl";
            casesLbl.Size = new Size(54, 22);
            casesLbl.TabIndex = 8;
            casesLbl.Text = "Sager";
            // 
            // coursesLbl
            // 
            coursesLbl.AutoSize = true;
            coursesLbl.Font = new Font("High Tower Text", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            coursesLbl.Location = new Point(108, 370);
            coursesLbl.Name = "coursesLbl";
            coursesLbl.Size = new Size(64, 22);
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
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.Black;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Black;
            dataGridViewCellStyle3.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Black;
            dataGridViewCellStyle4.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView2.Location = new Point(618, 409);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(333, 150);
            dataGridView2.TabIndex = 13;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(238, 270);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(203, 24);
            textBox5.TabIndex = 14;
            // 
            // EmployeeSpec
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1065, 655);
            Controls.Add(textBox5);
            Controls.Add(dataGridView2);
            Controls.Add(nameLbl);
            Controls.Add(LnameLbl);
            Controls.Add(label5);
            Controls.Add(coursesLbl);
            Controls.Add(casesLbl);
            Controls.Add(maillbl);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(employeesLbl);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(employeeNrLbl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeeSpec";
            Text = "EmployeeSpec";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label employeeNrLbl;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Label employeesLbl;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label maillbl;
        private Label casesLbl;
        private Label coursesLbl;
        private Label label5;
        private Label LnameLbl;
        private Label nameLbl;
        private DataGridView dataGridView2;
        private TextBox textBox5;
    }
}