using BusinessLogic;
using Models;
using SemesterProjektDenAnden.LogInForms;
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
    public partial class Employees : Form
    {
        EmployeeMdi employeeMdi;
        EmployeeSignUp employeeSignUp;
        EmployeeBL employeeBL;
        public Employees(EmployeeMdi employeeMdi)
        {
            InitializeComponent();
            this.employeeMdi = employeeMdi;

            //DGVData();
        }

        private async void employeesDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            int row = e.RowIndex;
            try
            {
                DataGridViewRow temp = dgv.Rows[row];

                int id = (int)temp.Cells[0].Value;

                employeeBL = new EmployeeBL();
                Employee employee = await employeeBL.GetAsync(id);
            }
            catch (Exception ex)
            {
                this.Show();
            }
            
        }

        private void OpretEmployeeBtn_Click(object sender, EventArgs e)
        {
            employeeSignUp = new EmployeeSignUp(employeeMdi);
            employeeMdi.FormOpener(employeeSignUp);
        }

        private async void DGVData()
        {
            List<Employee> employees = await employeeBL.GetAllAsync();

            BindingSource employeeSource = new BindingSource();
            employeeSource.DataSource = employees;
            employeesDgv.DataSource = employeeSource;
        }
    }
}
