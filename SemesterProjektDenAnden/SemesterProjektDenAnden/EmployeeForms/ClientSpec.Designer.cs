namespace SemesterProjektDenAnden.EmployeeForms
{
    partial class ClientSpec
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
            clientMailTxt = new TextBox();
            nameLbl = new Label();
            LnameLbl = new Label();
            label5 = new Label();
            casesLbl = new Label();
            maillbl = new Label();
            clientLnameTxt = new TextBox();
            clientFnameTxt = new TextBox();
            clientPhoneTxt = new TextBox();
            clientLbl = new Label();
            clientCasesDGV = new DataGridView();
            clientIdTxt = new TextBox();
            ClientNrLbl = new Label();
            updateClientbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)clientCasesDGV).BeginInit();
            SuspendLayout();
            // 
            // clientMailTxt
            // 
            clientMailTxt.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            clientMailTxt.Location = new Point(211, 324);
            clientMailTxt.Name = "clientMailTxt";
            clientMailTxt.Size = new Size(203, 24);
            clientMailTxt.TabIndex = 27;
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            nameLbl.Location = new Point(81, 240);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(57, 18);
            nameLbl.TabIndex = 26;
            nameLbl.Text = "Fornavn";
            // 
            // LnameLbl
            // 
            LnameLbl.AutoSize = true;
            LnameLbl.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            LnameLbl.ForeColor = Color.Black;
            LnameLbl.Location = new Point(81, 269);
            LnameLbl.Name = "LnameLbl";
            LnameLbl.Size = new Size(66, 18);
            LnameLbl.TabIndex = 25;
            LnameLbl.Text = "Efternavn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(81, 298);
            label5.Name = "label5";
            label5.Size = new Size(27, 18);
            label5.TabIndex = 24;
            label5.Text = "Tlf";
            // 
            // casesLbl
            // 
            casesLbl.AutoSize = true;
            casesLbl.Font = new Font("High Tower Text", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            casesLbl.Location = new Point(557, 169);
            casesLbl.Name = "casesLbl";
            casesLbl.Size = new Size(64, 26);
            casesLbl.TabIndex = 23;
            casesLbl.Text = "Sager";
            // 
            // maillbl
            // 
            maillbl.AutoSize = true;
            maillbl.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            maillbl.Location = new Point(81, 326);
            maillbl.Name = "maillbl";
            maillbl.Size = new Size(35, 18);
            maillbl.TabIndex = 22;
            maillbl.Text = "Mail";
            // 
            // clientLnameTxt
            // 
            clientLnameTxt.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            clientLnameTxt.Location = new Point(211, 266);
            clientLnameTxt.Name = "clientLnameTxt";
            clientLnameTxt.Size = new Size(203, 24);
            clientLnameTxt.TabIndex = 21;
            // 
            // clientFnameTxt
            // 
            clientFnameTxt.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            clientFnameTxt.Location = new Point(211, 237);
            clientFnameTxt.Name = "clientFnameTxt";
            clientFnameTxt.Size = new Size(203, 24);
            clientFnameTxt.TabIndex = 20;
            // 
            // clientPhoneTxt
            // 
            clientPhoneTxt.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            clientPhoneTxt.Location = new Point(211, 295);
            clientPhoneTxt.Name = "clientPhoneTxt";
            clientPhoneTxt.Size = new Size(203, 24);
            clientPhoneTxt.TabIndex = 19;
            // 
            // clientLbl
            // 
            clientLbl.AutoSize = true;
            clientLbl.BackColor = Color.Transparent;
            clientLbl.Font = new Font("High Tower Text", 36F, FontStyle.Regular, GraphicsUnit.Point);
            clientLbl.ForeColor = Color.Black;
            clientLbl.Location = new Point(65, 67);
            clientLbl.Name = "clientLbl";
            clientLbl.Size = new Size(310, 57);
            clientLbl.TabIndex = 18;
            clientLbl.Text = "Klientnavn nr.";
            // 
            // clientCasesDGV
            // 
            clientCasesDGV.AllowUserToAddRows = false;
            clientCasesDGV.AllowUserToDeleteRows = false;
            clientCasesDGV.AllowUserToResizeColumns = false;
            clientCasesDGV.AllowUserToResizeRows = false;
            clientCasesDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            clientCasesDGV.BackgroundColor = Color.Black;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            clientCasesDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            clientCasesDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            clientCasesDGV.DefaultCellStyle = dataGridViewCellStyle2;
            clientCasesDGV.EditMode = DataGridViewEditMode.EditProgrammatically;
            clientCasesDGV.EnableHeadersVisualStyles = false;
            clientCasesDGV.GridColor = Color.DimGray;
            clientCasesDGV.Location = new Point(557, 208);
            clientCasesDGV.Name = "clientCasesDGV";
            clientCasesDGV.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Black;
            dataGridViewCellStyle3.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            clientCasesDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            clientCasesDGV.RowHeadersVisible = false;
            clientCasesDGV.SelectionMode = DataGridViewSelectionMode.CellSelect;
            clientCasesDGV.Size = new Size(412, 150);
            clientCasesDGV.TabIndex = 17;
            clientCasesDGV.CellContentDoubleClick += clientCasesDGV_CellContentDoubleClick;
            // 
            // clientIdTxt
            // 
            clientIdTxt.BackColor = Color.White;
            clientIdTxt.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            clientIdTxt.Location = new Point(211, 208);
            clientIdTxt.Name = "clientIdTxt";
            clientIdTxt.ReadOnly = true;
            clientIdTxt.Size = new Size(203, 24);
            clientIdTxt.TabIndex = 16;
            // 
            // ClientNrLbl
            // 
            ClientNrLbl.AutoSize = true;
            ClientNrLbl.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            ClientNrLbl.Location = new Point(81, 211);
            ClientNrLbl.Name = "ClientNrLbl";
            ClientNrLbl.Size = new Size(68, 18);
            ClientNrLbl.TabIndex = 15;
            ClientNrLbl.Text = "Klient nr. ";
            // 
            // updateClientbtn
            // 
            updateClientbtn.BackColor = Color.Black;
            updateClientbtn.Font = new Font("High Tower Text", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            updateClientbtn.ForeColor = Color.White;
            updateClientbtn.Location = new Point(283, 379);
            updateClientbtn.Name = "updateClientbtn";
            updateClientbtn.Size = new Size(131, 30);
            updateClientbtn.TabIndex = 29;
            updateClientbtn.Text = "Opdater klient";
            updateClientbtn.UseVisualStyleBackColor = false;
            updateClientbtn.Click += updateClientbtn_Click;
            // 
            // ClientSpec
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1065, 655);
            Controls.Add(updateClientbtn);
            Controls.Add(clientMailTxt);
            Controls.Add(nameLbl);
            Controls.Add(LnameLbl);
            Controls.Add(label5);
            Controls.Add(casesLbl);
            Controls.Add(maillbl);
            Controls.Add(clientLnameTxt);
            Controls.Add(clientFnameTxt);
            Controls.Add(clientPhoneTxt);
            Controls.Add(clientLbl);
            Controls.Add(clientCasesDGV);
            Controls.Add(clientIdTxt);
            Controls.Add(ClientNrLbl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ClientSpec";
            Text = "ClientSpec";
            ((System.ComponentModel.ISupportInitialize)clientCasesDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox clientMailTxt;
        private Label nameLbl;
        private Label LnameLbl;
        private Label label5;
        private Label casesLbl;
        private Label maillbl;
        private TextBox clientLnameTxt;
        private TextBox clientFnameTxt;
        private TextBox clientPhoneTxt;
        private Label clientLbl;
        private DataGridView clientCasesDGV;
        private TextBox clientIdTxt;
        private Label ClientNrLbl;
        private Button updateClientbtn;
    }
}