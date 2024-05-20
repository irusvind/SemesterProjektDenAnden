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
            SuspendLayout();
            // 
            // serviceCombo
            // 
            serviceCombo.FormattingEnabled = true;
            serviceCombo.Location = new Point(50, 46);
            serviceCombo.Name = "serviceCombo";
            serviceCombo.Size = new Size(121, 23);
            serviceCombo.TabIndex = 0;
            // 
            // kilometerBox
            // 
            kilometerBox.Location = new Point(50, 97);
            kilometerBox.Name = "kilometerBox";
            kilometerBox.Size = new Size(100, 23);
            kilometerBox.TabIndex = 1;
            // 
            // transDesBox
            // 
            transDesBox.Location = new Point(50, 144);
            transDesBox.Name = "transDesBox";
            transDesBox.Size = new Size(100, 23);
            transDesBox.TabIndex = 2;
            // 
            // addTransport
            // 
            addTransport.Location = new Point(50, 208);
            addTransport.Name = "addTransport";
            addTransport.Size = new Size(75, 23);
            addTransport.TabIndex = 3;
            addTransport.Text = "Tilføj";
            addTransport.UseVisualStyleBackColor = true;
            addTransport.Click += addTransport_Click;
            // 
            // Transport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 347);
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
    }
}