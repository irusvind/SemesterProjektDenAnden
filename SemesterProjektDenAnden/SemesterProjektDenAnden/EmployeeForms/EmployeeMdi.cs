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


        public EmployeeMdi()
        {
            InitializeComponent();


            employeeOverview = new EmployeeOverview(this);
            this.FormOpener(employeeOverview);
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

            employeeOverview = new EmployeeOverview(this);
            this.FormOpener(employeeOverview);
        }

        private void Sagerbtn_Click(object sender, EventArgs e)
        {
            cases = new Cases(this);
            this.FormOpener(cases);



        }

        private void Toolsbtn_Click(object sender, EventArgs e)
        {

            //tools = new Tools();
            //this.FormOpener(tools);



        }

        private void Employeesbtn_Click(object sender, EventArgs e)
        {

            employees = new Employees(this);
            this.FormOpener(employees);



        }

        private void Clientsbtn_Click(object sender, EventArgs e)
        {
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
    }
}
