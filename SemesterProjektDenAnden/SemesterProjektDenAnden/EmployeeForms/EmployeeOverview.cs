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
    public partial class EmployeeOverview : Form
    {
        Cases cases;
        //Tools tools;
        Employees employees;
        Clients clients;
        EmployeeMdi employeeMdi;
        public EmployeeOverview(EmployeeMdi employeeMdi)
        {
            InitializeComponent();
            this.employeeMdi = employeeMdi;
        }

        private void sagerBtn_Click(object sender, EventArgs e)
        {
            cases = new Cases(employeeMdi);
            employeeMdi.FormOpener(cases);
        }

        private void toolsBtn_Click(object sender, EventArgs e)
        {

        }

        private void employeeBtn_Click(object sender, EventArgs e)
        {
            employees = new Employees(employeeMdi);
            employeeMdi.FormOpener(employees);
        }

        private void clientBtn_Click(object sender, EventArgs e)
        {
            clients = new Clients(employeeMdi);
            employeeMdi.FormOpener(clients);
        }
    }
}
