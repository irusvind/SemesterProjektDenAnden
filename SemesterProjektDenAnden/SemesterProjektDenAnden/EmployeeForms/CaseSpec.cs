﻿using BusinessLogic;
using Models;
using SemesterProjektDenAnden.ClientFroms;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;

namespace SemesterProjektDenAnden.EmployeeForms
{
    public partial class CaseSpec : Form
    {
        int caseId;
        EmployeeMdi employeeMdi;
        CaseBL caseBL = new CaseBL();
        ClientBL clientBL = new ClientBL();
        TransportLogBL transportLogBL = new TransportLogBL();
        EmployeeBL employeeBL = new EmployeeBL();
        ServiceBL serviceBL = new ServiceBL();
        WorkLogBL workLogBL = new WorkLogBL();

        public CaseSpec(EmployeeMdi employeeMdi, int CaseId)
        {
            InitializeComponent();
            this.employeeMdi = employeeMdi;
            this.caseId = CaseId;
            SetData();
            AddToServiceCombobox();
            ServincesDGVData();
            AddToLogServiceCombobox();
        }

        private async void SetData()
        {
            try
            {
                Case @case = new Case();
                @case = await caseBL.GetAsync(this.caseId);

                Client client = new Client();
                client = await clientBL.GetAsync(@case.ClientId);

                Employee employee = new Employee();
                employee = await employeeBL.GetAsync(@case.EmployeeId);

                TransportLog transport = new TransportLog();
                transport = await transportLogBL.GetAsync(this.caseId);

                sagsNavnNrLbl.Text = @case.CaseTitle + " " + @case.CaseId;
                clientNamebox.Text = client.FirstName + " " + client.LastName;
                clientMailbox.Text = client.Mail;
                clientPhoneBox.Text = client.Phone.ToString();
                employeeIdBox.Text = employee.Id.ToString();
                employeeNameBox.Text = employee.FirstName + " " + employee.LastName;
                startDataBox.Text = @case.StartDate.ToString();
                exhourBox.Text = @case.EstHours.ToString();
                endDateBox.Text = @case.ExEndDate.ToString();
                trandDisc.Text = "Hvad har du lavet?";
                totalHours.Text = @case.UsedHours.ToString();
                if (@case.Done)
                {
                    openCloseCaseBtn.Text = "Åben sag";
                    exhourBox.Enabled = false;
                    endDateBox.Enabled = false;
                    usedHoursbox.Enabled = false;
                    logYdelsecomboBox.Enabled = false;
                    trandDisc.Enabled = false;
                    comboCaseYdelse.Visible = false;
                    addServiceBtn.Visible = false;
                    transportBtn.Visible = false;
                    updateBtn.Visible = false;

                }
                else
                {
                    openCloseCaseBtn.Text = "Luk sag";
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




        private async void AddToServiceCombobox()
        {
            try
            {
                List<Service> services = await serviceBL.GetAllAsync();
                foreach (Service service in services)
                {
                    comboCaseYdelse.Items.Add(service.ServiceId + " : " + service.ServiceName);
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

        private async void AddToLogServiceCombobox()
        {
            try
            {
                List<Service> services = await serviceBL.GetSpecificCaseServiceAsync(caseId);
                foreach (Service service in services)
                {
                    logYdelsecomboBox.Items.Add(service.ServiceId + ": " + service.ServiceName);
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

        private async void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Case newcase = new Case();
                newcase = await caseBL.GetAsync(this.caseId);
                newcase.EstHours = int.Parse(exhourBox.Text);
                int usedHours = newcase.UsedHours;
                usedHours += int.Parse(usedHoursbox.Text);
                newcase.UsedHours = usedHours;
                newcase.ExEndDate = DateTime.Parse(endDateBox.Text);

                Employee employee = new Employee();
                employee = await employeeBL.GetAsync(this.caseId);
                employee.Id = int.Parse(employeeIdBox.Text);
                employee = await employeeBL.GetAsync(int.Parse(employeeIdBox.Text));
                employeeNameBox.Text = employee.FirstName + " " + employee.LastName;
                newcase.EmployeeId = int.Parse(employeeIdBox.Text);
                await caseBL.UpdateAsync(newcase);
                WorkLog newWorkLog = new WorkLog();
                newWorkLog.StartDate = DateTime.Now;
                newWorkLog.EndDate = DateTime.Now.AddHours(double.Parse(usedHoursbox.Text));
                newWorkLog.CaseId = caseId;

                string[] idString = new string[2];
                idString = logYdelsecomboBox.Items[logYdelsecomboBox.SelectedIndex].ToString().Split(':');
                int id = int.Parse(idString[0]);
                newWorkLog.ServiceId = id;
                newWorkLog.WorkDescription = trandDisc.Text;
                
                var context = new ValidationContext(newWorkLog, serviceProvider: null, items: null);
                bool isValid = Validator.TryValidateObject(newWorkLog, context, null, true);

                if (isValid)
                {
                    bool createResult = await workLogBL.CreateAsync(newWorkLog);
                    if (createResult)
                    {
                        MessageBox.Show("Sag Opdateret", "Sag Opdateret");
                        EmployeeOverview overview = new EmployeeOverview(employeeMdi);
                        employeeMdi.FormOpener(overview);
                        CaseSpec newCasePage = new CaseSpec(employeeMdi, caseId);
                        employeeMdi.FormOpener(newCasePage);
                    }
                    else
                    {
                        MessageBox.Show("Fejl: Sag blev ikke opdateret", "Fejl");
                    }
                }
                else { MessageBox.Show("Fejl: Sag blev ikke opdateret", " info ikke valid"); };


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


        private async void AddServiceBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string[] idString = comboCaseYdelse.Items[comboCaseYdelse.SelectedIndex].ToString().Split(':');
                int id = int.Parse(idString[0]);
                await serviceBL.UpdateAsync(id, caseId);
                EmployeeOverview overview = new EmployeeOverview(employeeMdi);
                employeeMdi.FormOpener(overview);
                CaseSpec newCasePage = new CaseSpec(employeeMdi, caseId);
                employeeMdi.FormOpener(newCasePage);
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
        private async void ServincesDGVData()
        {
            try
            {
                List<Service> services = await serviceBL.GetSpecificCaseServiceAsync(caseId);

                BindingSource servinceSource = new BindingSource();
                servinceSource.DataSource = services;
                ydelserDgv.DataSource = servinceSource;
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

        private void transportBtn_Click(object sender, EventArgs e)
        {

            Transport transport = new Transport(caseId);
            transport.Show();

        }

        private async void openCloseCaseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Case chosenCase = await caseBL.GetAsync(caseId);
                if (chosenCase.Done)
                {

                    DialogResult result = MessageBox.Show("Er du sikker på at du vil åbne denne sag igen?", "Åben sag", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        chosenCase.Done = false;
                        await caseBL.UpdateAsync(chosenCase);
                        CaseSpec caseSpec = new CaseSpec(employeeMdi, caseId);
                        employeeMdi.FormOpener(caseSpec);
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("Er du sikker på at du vil lukke denne sag", "Luk sag", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        chosenCase.Done = true;
                        await caseBL.UpdateAsync(chosenCase);
                        CaseSpec caseSpec = new CaseSpec(employeeMdi, caseId);
                        employeeMdi.FormOpener(caseSpec);
                    }
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
