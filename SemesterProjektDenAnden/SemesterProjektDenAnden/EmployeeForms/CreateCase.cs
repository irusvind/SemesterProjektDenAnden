using BusinessLogic;
using Models;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;

namespace SemesterProjektDenAnden.EmployeeForms
{
    public partial class CreateCase : Form
    {
        EmployeeMdi employeeMdi;
        CaseBL CaseBL = new CaseBL();
        ClientBL ClientBL = new ClientBL();
        EmployeeBL EmployeeBL = new EmployeeBL();
        ServiceBL ServiceBL = new ServiceBL();


        public CreateCase(EmployeeMdi employeeMdi)
        {
            InitializeComponent();

            this.employeeMdi = employeeMdi;

            try
            {
                AddToClientCombobox();

                AddToemployeeCombobox();
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

        private async void AddToClientCombobox()
        {

            List<Client> clients = await ClientBL.GetAllAsync();
            foreach (Client client in clients)
            {
                clientBox.Items.Add(client.ClientId + ": " + client.FirstName);
            }
        }

        private async void AddToemployeeCombobox()
        {
            List<Employee> employees = await EmployeeBL.GetAllAsync();
            foreach (Employee employee in employees)
            {
                employeeBox.Items.Add(employee.Id + ": " + employee.FirstName);
            }

        }

        private async void createCaseBtn_Click(object sender, EventArgs e)
        {
            try
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
                    string[] client = clientBox.Items[clientBox.SelectedIndex].ToString().Split(':');
                    newCase.ClientId = int.Parse(client[0]);
                    string[] employeeId = employeeBox.Items[employeeBox.SelectedIndex].ToString().Split(':');
                    newCase.EmployeeId = int.Parse(employeeId[0]);
                    newCase.Done = false;


                    ValidationContext context = new ValidationContext(newCase, serviceProvider: null, items: null);
                    bool isValid = Validator.TryValidateObject(newCase, context, null, true);

                    if (isValid)
                    {
                        bool createResult = await CaseBL.CreateAsync(newCase);
                        if (createResult)
                        {
                            MessageBox.Show("Sag oprettet", "Sag oprettet");
                            Cases newCases = new Cases(employeeMdi);
                            employeeMdi.FormOpener(newCases);
                        }
                        else
                        {
                            MessageBox.Show("Fejl: Sag ikke oprettet", "Fejl");
                        }
                    }
                    else { MessageBox.Show("Fejl: Sag ikke oprettet", " info ikke valid"); };
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
