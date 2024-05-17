using BusinessLogic;
using BusinessLogic.BLInterfaces;
using DataAcces;
using Models;
using SemesterProjektDenAnden.ClientFroms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterProjektDenAnden.EmployeeForms
{
    public partial class EmployeeSpec : Form
    {

        EmployeeBL employeeBL = new EmployeeBL();
        CaseBL caseBL = new CaseBL();
        CourseBL courseBL = new CourseBL();
        EmployeeMdi employeeMdi;
        int employeeId;
        public EmployeeSpec(EmployeeMdi employeeMdi, int employeeId)

        {
            InitializeComponent();

            this.employeeMdi = employeeMdi;
            this.employeeId = employeeId;
            try
            {
                EmployeeData();
                CoursesDGVData();
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

        public async void EmployeeData()
        {
            Employee employee = await employeeBL.GetAsync(employeeId);
            employeesLbl.Text = employee.JobTitle + ": " + employee.FirstName + " " + employee.LastName;
            employeeIdTxt.Text = employee.Id.ToString();
            FnameTxt.Text = employee.FirstName;
            LnameTxt.Text = employee.LastName;
            PhoneTxt.Text = employee.PhoneNumber.ToString();
            MailTxt.Text = employee.Email;
            addressTxt.Text = employee.Address;

            CasesDGVData();
        }

        private async void CoursesDGVData()
        {
            List<Course> employeeCourses = await employeeBL.GetSpecificCoursesAsync(employeeId);
            BindingSource caseSource = new BindingSource();
            caseSource.DataSource = employeeCourses;
            coursesDGV.DataSource = caseSource;
        }

        private async void CasesDGVData()
        {
            List<Case> allCases = await caseBL.GetAllAsync();
            List<Case> employeeCases = new List<Case>();
            foreach (Case Case in allCases)
            {
                if (Case.EmployeeId == employeeId)
                {
                    employeeCases.Add(Case);
                }
            }
            BindingSource caseSource = new BindingSource();
            caseSource.DataSource = employeeCases;
            CasesDGV.DataSource = caseSource;
        }

        private async void DeleteEmployeeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Er du sikker på du vil slette denne medarbejder?", "Slet medarbejder", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    await employeeBL.DeleteAsync(employeeId);
                    Employees employees = new Employees(employeeMdi);
                    employeeMdi.FormOpener(employees);
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

        private async void UpdateEmployeeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Er du sikker på du vil opdatere denne medarbejders information?", "Opdater medarbejder", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Employee updatedEmployee = await employeeBL.GetAsync(employeeId);

                    updatedEmployee.FirstName = FnameTxt.Text;
                    updatedEmployee.LastName = LnameTxt.Text;
                    updatedEmployee.PhoneNumber = int.Parse(PhoneTxt.Text);
                    updatedEmployee.Email = MailTxt.Text;
                    updatedEmployee.Address = addressTxt.Text;

                    ValidationContext context = new ValidationContext(updatedEmployee, serviceProvider: null, items: null);
                    bool isValid = Validator.TryValidateObject(updatedEmployee, context, null, true);
                    if (isValid)
                    {
                        bool Updateresult = await employeeBL.UpdateAsync(updatedEmployee);
                        if (Updateresult)
                        {
                            MessageBox.Show("Medarbejder opdateret", "Medarbejder opdateret");
                            Employees employees = new Employees(employeeMdi);
                            employeeMdi.FormOpener(employees);
                        }
                        else
                        {
                            MessageBox.Show("Medarbejder ikke oprettet: Ukendt fejl", "Fejl");
                        }
                    }
                    else { MessageBox.Show("Fejl: Medarbejder ikke opdateret, info ikke valid", "Info ikke valid"); };
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

        private void changeCoursesBtn_Click(object sender, EventArgs e)
        {
            EmployeeCoursesEdit employeeCoursesEdit = new EmployeeCoursesEdit(employeeMdi, employeeId);
            employeeMdi.FormOpener(employeeCoursesEdit);
        }
    }
}
