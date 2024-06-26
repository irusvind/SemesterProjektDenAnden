﻿using BusinessLogic;
using Models;
using SemesterProjektDenAnden.EmployeeForms;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;

namespace SemesterProjektDenAnden.LogInForms
{
    public partial class EmployeeSignUp : Form
    {
        EmployeeMdi employeeMdi;
        EmployeeBL employeeBL = new EmployeeBL();
        public EmployeeSignUp(EmployeeMdi employeeMdi)
        {
            InitializeComponent();
            this.employeeMdi = employeeMdi;
        }

        private async void CreateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string message = "Er du sikker på du vil oprette en bruger med de indtastede værdier?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, "Opret Bruger", buttons);
                if (result == DialogResult.Yes)
                {
                    Employee newEmployee = new Employee();
                    newEmployee.FirstName = FnameTxt.Text;
                    newEmployee.LastName = LnameTxt.Text;
                    newEmployee.PhoneNumber = int.Parse(PhoneTxt.Text);
                    newEmployee.Email = MailTxt.Text;
                    newEmployee.Address = AddressTxt.Text;
                    newEmployee.JobTitle = JobTitleCB.Text;
                    ValidationContext context = new ValidationContext(newEmployee, serviceProvider: null, items: null);
                    bool isValid = Validator.TryValidateObject(newEmployee, context, null, true);

                    if (isValid)
                    {
                        bool createResult = await employeeBL.CreateAsync(newEmployee);
                        if (createResult)
                        {
                            MessageBox.Show("Ansat oprettet", "Ansat oprettet");
                            Employees employees = new Employees(employeeMdi);
                            employeeMdi.FormOpener(employees);
                        }
                        else
                        {
                            MessageBox.Show("Fejl: Ansat ikke oprettet", "Fejl");
                        }
                    }
                    else { MessageBox.Show("Fejl: Ansat ikke oprettet", " info ikke valid"); };

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
    }
}
