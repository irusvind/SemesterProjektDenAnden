using BusinessLogic;
using DataAcces;
using DataAcces.DAInterfaces;
using Models;
using SemesterProjektDenAnden.ClientFroms;
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
        EmployeeMdi employeeMdi;
        EmployeeBL employeeBL = new EmployeeBL();
        public EmployeeLogIn()
        {
            InitializeComponent();

            AddToCombobox();
        }

        private async void AddToCombobox()
        {
            List<Employee> employees = await employeeBL.GetAllAsync();
            foreach (Employee employee in employees)
            {
                EmployeeCB.Items.Add(employee.Id + ": " + employee.FirstName + " " + employee.LastName);
            }
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            if (EmployeeCB.Text.Length > 0)
            {
                string[] idString = EmployeeCB.Items[EmployeeCB.SelectedIndex].ToString().Split(':');
                int id = int.Parse(idString[0]);
                employeeMdi = new EmployeeMdi(id);
                employeeMdi.Show();
                this.Close();
            }
        }
    }
}
