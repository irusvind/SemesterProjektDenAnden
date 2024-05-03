namespace SemesterProjektDenAnden.EmployeeForms
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
            sagerLbl = new Label();
            sagerDgv = new DataGridView();
            OpretSagBtn = new Button();
            clientCB = new ComboBox();
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
            sagerDgv.BackgroundColor = Color.Black;
            sagerDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            sagerDgv.DefaultCellStyle = dataGridViewCellStyle1;
            sagerDgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            sagerDgv.Enabled = false;
            sagerDgv.GridColor = Color.White;
            sagerDgv.Location = new Point(65, 151);
            sagerDgv.Name = "sagerDgv";
            sagerDgv.RowTemplate.Height = 25;
            sagerDgv.Size = new Size(930, 370);
            sagerDgv.TabIndex = 1;
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
            // 
            // clientCB
            // 
            clientCB.BackColor = Color.White;
            clientCB.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            clientCB.ForeColor = Color.Black;
            clientCB.FormattingEnabled = true;
            clientCB.Location = new Point(666, 570);
            clientCB.Name = "clientCB";
            clientCB.Size = new Size(138, 24);
            clientCB.TabIndex = 3;
            // 
            // Cases
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1065, 655);
            Controls.Add(clientCB);
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
        private ComboBox clientCB;
    }
}