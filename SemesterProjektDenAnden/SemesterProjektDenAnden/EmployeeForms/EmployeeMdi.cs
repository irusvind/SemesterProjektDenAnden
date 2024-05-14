using SemesterProjektDenAnden.ClientFroms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterProjektDenAnden.EmployeeForms
{
    public partial class EmployeeMdi : Form
    {
        EmployeeOverview employeeOverview;
        Cases cases;
        //Tools tools;
        Employees employees;
        Clients clients;


        public EmployeeMdi(int employeeId)
        {
            InitializeComponent();


            employeeOverview = new EmployeeOverview(this);
            this.FormOpener(employeeOverview);

            ButtonClickColor(overviewbtn);
        }

        private void FormCloser()
        {
            foreach (Form forms in this.MdiChildren)
            {
                forms.Hide();
            }
        }


        public void FormOpener(Form form)
        {
            if (this.MdiChildren.Length == 0 || this.MdiChildren[0] != form)
            {
                this.FormCloser();
                form.FormClosed += FormClosed;
                form.MdiParent = this;
                form.Dock = DockStyle.Fill;
                form.Show();
            }
            else
            {
                form.Activate();
            }

            void FormClosed(object sender, FormClosedEventArgs e)
            {
                form = null;
            }
        }

        private void overviewbtn_Click(object sender, EventArgs e)
        {
            ButtonClickColor(overviewbtn);
            employeeOverview = new EmployeeOverview(this);
            this.FormOpener(employeeOverview);
        }

        public void Sagerbtn_Click(object sender, EventArgs e)
        {
            ButtonClickColor(Sagerbtn);
            cases = new Cases(this);
            this.FormOpener(cases);
        }

        public void Toolsbtn_Click(object sender, EventArgs e)
        {
            //ButtonClickColor(Toolsbtn);
            //tools = new Tools();
            //this.FormOpener(tools);
        }

        public void Employeesbtn_Click(object sender, EventArgs e)
        {
            ButtonClickColor(Employeesbtn);
            employees = new Employees(this);
            this.FormOpener(employees);
        }

        public void Clientsbtn_Click(object sender, EventArgs e)
        {
            ButtonClickColor(Clientsbtn);
            clients = new Clients(this);
            this.FormOpener(clients);
        }

        private void EmployeeMdi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms[0].Show();
        }

        private void LogOutbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void employeeHelpBtn_Click(object sender, EventArgs e)
        {

        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if(btn.BackColor == Color.Black)
            {
                btn.BackColor = Color.DimGray;
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if(btn.BackColor == Color.DimGray)
            {
                btn.BackColor = Color.Black;
            }
        }

        public void ButtonClickColor(Button btn)
        {
            overviewbtn.BackColor = Color.Black;
            Sagerbtn.BackColor = Color.Black;
            Toolsbtn.BackColor = Color.Black;
            Employeesbtn.BackColor = Color.Black;
            Clientsbtn.BackColor = Color.Black;
            btn.BackColor = Color.Gray;
        }
    }
}
