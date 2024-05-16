namespace SemesterProjektDenAnden.EmployeeForms
{
    partial class Clients
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
            clientsDgv = new DataGridView();
            clientsLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)clientsDgv).BeginInit();
            SuspendLayout();
            // 
            // clientsDgv
            // 
            clientsDgv.AllowUserToAddRows = false;
            clientsDgv.AllowUserToDeleteRows = false;
            clientsDgv.AllowUserToResizeColumns = false;
            clientsDgv.AllowUserToResizeRows = false;
            clientsDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            clientsDgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            clientsDgv.BackgroundColor = Color.Black;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            clientsDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            clientsDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            clientsDgv.DefaultCellStyle = dataGridViewCellStyle2;
            clientsDgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            clientsDgv.EnableHeadersVisualStyles = false;
            clientsDgv.GridColor = Color.DimGray;
            clientsDgv.Location = new Point(67, 145);
            clientsDgv.Name = "clientsDgv";
            clientsDgv.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Black;
            dataGridViewCellStyle3.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            clientsDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            clientsDgv.RowTemplate.Height = 25;
            clientsDgv.SelectionMode = DataGridViewSelectionMode.CellSelect;
            clientsDgv.Size = new Size(930, 370);
            clientsDgv.TabIndex = 4;
            clientsDgv.CellDoubleClick += clientsDgv_CellDoubleClick;
            // 
            // clientsLbl
            // 
            clientsLbl.AutoSize = true;
            clientsLbl.Font = new Font("High Tower Text", 36F, FontStyle.Regular, GraphicsUnit.Point);
            clientsLbl.ForeColor = Color.Black;
            clientsLbl.Location = new Point(65, 67);
            clientsLbl.Name = "clientsLbl";
            clientsLbl.Size = new Size(187, 57);
            clientsLbl.TabIndex = 3;
            clientsLbl.Text = "Klienter";
            // 
            // Clients
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1065, 655);
            Controls.Add(clientsDgv);
            Controls.Add(clientsLbl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Clients";
            Text = "Clients";
            ((System.ComponentModel.ISupportInitialize)clientsDgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView clientsDgv;
        private Label clientsLbl;
    }
}