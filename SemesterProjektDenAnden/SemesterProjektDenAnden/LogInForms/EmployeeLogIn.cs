using BusinessLogic;
using Models;
using SemesterProjektDenAnden.EmployeeForms;
using System.Data.SqlClient;

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
            try
            {
                List<Employee> employees = await employeeBL.GetAllAsync();
                foreach (Employee employee in employees)
                {
                    EmployeeCB.Items.Add(employee.Id + ": " + employee.FirstName + " " + employee.LastName);
                }
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

        private void logInBtn_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Fejl, Operation stoppet: Program fejl", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EmployeeLogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.Count == 2)
            {
                Application.OpenForms[0].Show();
            }

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
