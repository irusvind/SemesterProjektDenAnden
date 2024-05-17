using BusinessLogic;
using Models;
using SemesterProjektDenAnden.LogInForms;

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

            DGVData();
        }

        private void employeesDgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
