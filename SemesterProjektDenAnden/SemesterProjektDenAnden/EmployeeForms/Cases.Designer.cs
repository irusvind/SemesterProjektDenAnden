﻿namespace SemesterProjektDenAnden.EmployeeForms
{
    partial class Cases
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
            sagerLbl = new Label();
            sagerDgv = new DataGridView();
            OpretSagBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)sagerDgv).BeginInit();
            SuspendLayout();
            // 
            // sagerLbl
            // 
            sagerLbl.AutoSize = true;
            sagerLbl.Font = new Font("High Tower Text", 36F, FontStyle.Regular, GraphicsUnit.Point);
            sagerLbl.ForeColor = Color.Black;
            sagerLbl.Location = new Point(65, 67);
            sagerLbl.Name = "sagerLbl";
            sagerLbl.Size = new Size(136, 57);
            sagerLbl.TabIndex = 0;
            sagerLbl.Text = "Sager";
            // 
            // sagerDgv
            // 
            sagerDgv.AllowUserToAddRows = false;
            sagerDgv.AllowUserToDeleteRows = false;
            sagerDgv.AllowUserToResizeColumns = false;
            sagerDgv.AllowUserToResizeRows = false;
            sagerDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            sagerDgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            sagerDgv.BackgroundColor = Color.Black;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            sagerDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            sagerDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            sagerDgv.DefaultCellStyle = dataGridViewCellStyle2;
            sagerDgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            sagerDgv.EnableHeadersVisualStyles = false;
            sagerDgv.GridColor = Color.DimGray;
            sagerDgv.Location = new Point(65, 151);
            sagerDgv.MultiSelect = false;
            sagerDgv.Name = "sagerDgv";
            sagerDgv.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Black;
            dataGridViewCellStyle3.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            sagerDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            sagerDgv.RowHeadersVisible = false;
            sagerDgv.RowTemplate.Height = 25;
            sagerDgv.SelectionMode = DataGridViewSelectionMode.CellSelect;
            sagerDgv.Size = new Size(930, 370);
            sagerDgv.TabIndex = 1;
            sagerDgv.CellDoubleClick += sagerDgv_CellDoubleClick;
            // 
            // OpretSagBtn
            // 
            OpretSagBtn.BackColor = Color.Black;
            OpretSagBtn.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            OpretSagBtn.ForeColor = Color.White;
            OpretSagBtn.Location = new Point(829, 560);
            OpretSagBtn.Name = "OpretSagBtn";
            OpretSagBtn.Size = new Size(166, 40);
            OpretSagBtn.TabIndex = 2;
            OpretSagBtn.Text = "Opret ny sag";
            OpretSagBtn.UseVisualStyleBackColor = false;
            OpretSagBtn.Click += OpretSagBtn_Click;
            // 
            // Cases
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1065, 655);
            Controls.Add(OpretSagBtn);
            Controls.Add(sagerDgv);
            Controls.Add(sagerLbl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Cases";
            Text = "Cases";
            ((System.ComponentModel.ISupportInitialize)sagerDgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label sagerLbl;
        private DataGridView sagerDgv;
        private Button OpretSagBtn;
    }
}