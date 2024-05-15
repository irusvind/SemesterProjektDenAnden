namespace SemesterProjektDenAnden.ClientFroms
{
    partial class MyCases
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
            MycasesLbl = new Label();
            casesDgv = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)casesDgv).BeginInit();
            SuspendLayout();
            // 
            // MycasesLbl
            // 
            MycasesLbl.AutoSize = true;
            MycasesLbl.Font = new Font("High Tower Text", 36F, FontStyle.Regular, GraphicsUnit.Point);
            MycasesLbl.Location = new Point(65, 67);
            MycasesLbl.Margin = new Padding(2, 0, 2, 0);
            MycasesLbl.Name = "MycasesLbl";
            MycasesLbl.Size = new Size(245, 57);
            MycasesLbl.TabIndex = 0;
            MycasesLbl.Text = "Mine sager";
            // 
            // casesDgv
            // 
            casesDgv.AllowUserToAddRows = false;
            casesDgv.AllowUserToDeleteRows = false;
            casesDgv.AllowUserToResizeColumns = false;
            casesDgv.AllowUserToResizeRows = false;
            casesDgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            casesDgv.BackgroundColor = Color.Black;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            casesDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            casesDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            casesDgv.DefaultCellStyle = dataGridViewCellStyle2;
            casesDgv.Enabled = false;
            casesDgv.EnableHeadersVisualStyles = false;
            casesDgv.GridColor = Color.DimGray;
            casesDgv.Location = new Point(65, 166);
            casesDgv.Name = "casesDgv";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Black;
            dataGridViewCellStyle3.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            casesDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            casesDgv.RowTemplate.Height = 25;
            casesDgv.Size = new Size(932, 394);
            casesDgv.TabIndex = 1;
            // 
            // MyCases
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1065, 655);
            Controls.Add(casesDgv);
            Controls.Add(MycasesLbl);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "MyCases";
            Text = "MyCases";
            ((System.ComponentModel.ISupportInitialize)casesDgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MycasesLbl;
        private DataGridView casesDgv;
    }
}