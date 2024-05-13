using BusinessLogic;
using BusinessLogic.BLInterfaces;
using DataAcces;
using Models;
using SemesterProjektDenAnden.ClientFroms;
using SemesterProjektDenAnden.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterProjektDenAnden.EmployeeForms
{
    public partial class CreateCase : Form
    {
        EmployeeMdi employeeMdi;
        CreateCase createCase;
        ICaseBL CaseBL = new CaseBL();
        IClientBL ClientBL = new ClientBL();
        IEmployeeBL EmployeeBL = new EmployeeBL();
        IServiceBL ServiceBL = new ServiceBL();


        public CreateCase(EmployeeMdi employeeMdi)
        {
            InitializeComponent();

            AddToClientCombobox();

            AddToemployeeCombobox();

            AddToServiceCombobox();

        }

        private async void AddToClientCombobox()
        {
            List<Client> clients = await ClientBL.GetAllAsync();
            foreach (Client client in clients)
            {
                clientBox.Items.Add(client.ClientId);
            }
        }

        private async void AddToemployeeCombobox()
        {
            List<Employee> employees = await EmployeeBL.GetAllAsync();
            foreach (Employee employee in employees)
            {
                employeeBox.Items.Add(employee.Id);
            }
        }

        private async void AddToServiceCombobox()
        {
            List<Service> services = await ServiceBL.GetAllAsync();
            foreach (Service service in services)
            {
                serviceBox.Items.Add(service.ServiceId);
            }
        }

        private async void createCaseBtn_Click(object sender, EventArgs e)
        {
            {
                string message = "Er du sikker på du vil oprette en case med de indtastede værdier?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, "Opret case", buttons);
                if (result == DialogResult.Yes)
                {


                    Case newCase = new Case();
                    newCase.CaseTitle = workTitel.Text;
                    newCase.StartDate = startDateCal.SelectionStart;
                    newCase.ExEndDate = endDateCal.SelectionStart;
                    newCase.EstHours = Convert.ToInt32(estimated_hours.Text);
                    string client = clientBox.Text;
                    newCase.ClientId = int.Parse(client);
                    string employeeId = employeeBox.Text;
                    newCase.EmployeeId = int.Parse(employeeId);
                    newCase.Done = false;

                    var context = new ValidationContext(newCase, serviceProvider: null, items: null);
                    bool isValid = Validator.TryValidateObject(newCase, context, null, true);

                    if (isValid)
                    {
                        bool createResult = await CaseBL.CreateAsync(newCase);
                        if (createResult)
                        {
                            MessageBox.Show("Bruger oprettet", "Bruger oprettet");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Fejl: Bruger ikke oprettet", "Fejl");
                        }
                    }
                    else { MessageBox.Show("Fejl: Bruger ikke oprettet", " info ikke valid"); };




                }

            }
        }
    } 
}
