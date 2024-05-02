using SemesterProjektDenAnden.EmployeeForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterProjektDenAnden.LogInForms
{
    public partial class EmployeeLogIn : Form
    {
        EmployeeOverview employeeOverview = new EmployeeOverview();
        public EmployeeLogIn()
        {
            InitializeComponent();
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            employeeOverview.Show();
            this.Hide();
        }
    }
}
