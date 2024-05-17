using BusinessLogic;
using Models;
using SemesterProjektDenAnden.LogInForms;
using System.Data.SqlClient;

namespace SemesterProjektDenAnden.EmployeeForms
{
    public partial class Employees : Form
    {
        EmployeeMdi employeeMdi;
        EmployeeSignUp employeeSignUp;
        EmployeeBL employeeBL = new EmployeeBL();
        public Employees(EmployeeMdi employeeMdi)
        {
            InitializeComponent();
            this.employeeMdi = employeeMdi;

            try
            {
                DGVData();
            }
            catch (SqlException)
            {
                MessageBox.Show("Fejl, Operation stoppet: Kunne ikke skrive til Database", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fejl, Operation stoppet: Program fejl", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void employeesDgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridView dgv = (DataGridView)sender;

                int row = e.RowIndex;
                if (row >= 0)
                {
                    DataGridViewRow temp = dgv.Rows[row];
                    int id = (int)temp.Cells[0].Value;
                    EmployeeSpec employeeSpec = new EmployeeSpec(employeeMdi, id);
                    employeeMdi.FormOpener(employeeSpec);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fejl, Operation stoppet: Program fejl", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
