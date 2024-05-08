using BusinessLogic;
using Models;
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
    public partial class EmployeeSpec : Form
    {

        EmployeeBL employeeBL = new EmployeeBL();
        int employeeId;
        public EmployeeSpec(int employeeId)

        {
            InitializeComponent();

            this.employeeId = employeeId;
            EmployeeData();
        }

        public async void EmployeeData()
        {
            Employee employee = await employeeBL.GetAsync(employeeId);
            employeesLbl.Text = employee.FirstName + " " + employee.LastName;
            employeeIdTxt.Text = employee.Id.ToString();
            FnameTxt.Text = employee.FirstName;
            LnameTxt.Text = employee.LastName;
            PhoneTxt.Text = employee.PhoneNumber.ToString();
            MailTxt.Text = employee.Email;
        }
    }
}
