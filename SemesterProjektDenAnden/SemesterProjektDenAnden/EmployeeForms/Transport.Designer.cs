namespace SemesterProjektDenAnden.EmployeeForms
{
    partial class Transport
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
            serviceCombo = new ComboBox();
            kilometerBox = new TextBox();
            transDesBox = new TextBox();
            addTransport = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // serviceCombo
            // 
            serviceCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            serviceCombo.FormattingEnabled = true;
            serviceCombo.Location = new Point(151, 46);
            serviceCombo.Name = "serviceCombo";
            serviceCombo.Size = new Size(121, 23);
            serviceCombo.TabIndex = 0;
            // 
            // kilometerBox
            // 
            kilometerBox.Location = new Point(151, 85);
            kilometerBox.Name = "kilometerBox";
            kilometerBox.Size = new Size(100, 23);
            kilometerBox.TabIndex = 1;
            // 
            // transDesBox
            // 
            transDesBox.Location = new Point(151, 130);
            transDesBox.Name = "transDesBox";
            transDesBox.Size = new Size(100, 23);
            transDesBox.TabIndex = 2;
            // 
            // addTransport
            // 
            addTransport.Location = new Point(151, 178);
            addTransport.Name = "addTransport";
            addTransport.Size = new Size(75, 23);
            addTransport.TabIndex = 3;
            addTransport.Text = "Tilføj";
            addTransport.UseVisualStyleBackColor = true;
            addTransport.Click += addTransport_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 49);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 4;
            label1.Text = "Ydelse";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 88);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 5;
            label2.Text = "Km kørt";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 133);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 6;
            label3.Text = "Hvor har du været?";
            // 
            // Transport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(506, 347);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(addTransport);
            Controls.Add(transDesBox);
            Controls.Add(kilometerBox);
            Controls.Add(serviceCombo);
            Name = "Transport";
            Text = "Transport";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox serviceCombo;
        private TextBox kilometerBox;
        private TextBox transDesBox;
        private Button addTransport;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}