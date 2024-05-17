using BusinessLogic;
using Models;
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
    public partial class CaseSpec : Form
    {
        int caseId;
        EmployeeMdi employeeMdi;
        CaseBL caseBL = new CaseBL();
        ClientBL clientBL = new ClientBL();
        TransportLogBL transportLogBL = new TransportLogBL();
        EmployeeBL employeeBL = new EmployeeBL();
        ServiceBL serviceBL = new ServiceBL();

        public CaseSpec(EmployeeMdi employeeMdi, int CaseId)
        {
            InitializeComponent();
            this.employeeMdi = employeeMdi;
            this.caseId = CaseId;
            SetData();
            AddToServiceCombobox();
            ServincesDGVData();
        }

        private async void SetData()
        {
            Case @case = new Case();
            @case = await caseBL.GetAsync(this.caseId);

            Client client = new Client();
            client = await clientBL.GetAsync(@case.ClientId);

            Employee employee = new Employee();
            employee = await employeeBL.GetAsync(@case.EmployeeId);

            TransportLog transport = new TransportLog();
            transport = await transportLogBL.GetAsync(this.caseId);


            clientNamebox.Text = client.FirstName + " " + client.LastName;
            clientMailbox.Text = client.Mail;
            clientPhoneBox.Text = client.Phone.ToString();
            employeeIdBox.Text = employee.Id.ToString();
            employeeNameBox.Text = employee.FirstName + " " + employee.LastName;
            startDataBox.Text = @case.StartDate.ToString();
            exhourBox.Text = @case.EstHours.ToString();
            endDateBox.Text = @case.ExEndDate.ToString();
            usedHoursbox.Text = @case.UsedHours.ToString();
            kmBox.Text = transport.KmDriven.ToString();
        }

        private async void AddToServiceCombobox()
        {
            List<Service> services = await serviceBL.GetAllAsync();
            foreach (Service service in services)
            {
                comboCaseYdelse.Items.Add(service.ServiceId + " : " + service.ServiceName);
            }
        }

        private async void updateBtn_Click(object sender, EventArgs e)
        {
            Case newcase = new Case();
            newcase = await caseBL.GetAsync(this.caseId);
            newcase.EstHours = int.Parse(exhourBox.Text);
            newcase.UsedHours = int.Parse(usedHoursbox.Text);
            newcase.ExEndDate = DateTime.Parse(endDateBox.Text);



            Employee employee = new Employee();
            employee = await employeeBL.GetAsync(this.caseId);
            employee.Id = int.Parse(employeeIdBox.Text);
            employee = await employeeBL.GetAsync(int.Parse(employeeIdBox.Text));
            employeeNameBox.Text = employee.FirstName + " " + employee.LastName;
            newcase.EmployeeId = int.Parse(employeeIdBox.Text);
            await caseBL.UpdateAsync(newcase);
            TransportLog transportLog = new TransportLog();
            transportLog.KmDriven = int.Parse(kmBox.Text);
            transportLog.LogDescription = trandDisc.Text;
            transportLog.CaseId = caseId;
            transportLog.ServiceId = caseId; // todo lav getServiceID
            await transportLogBL.CreateAsync(transportLog);

            MessageBox.Show("Case Updated");
        }

        
        private void AddServiceBtn_Click(object sender, EventArgs e)
        {
            string[] idString = comboCaseYdelse.Items[comboCaseYdelse.SelectedIndex].ToString().Split(':');
            int id = int.Parse(idString[0]);
            serviceBL.UpdateAsync(id, caseId);
            ServincesDGVData();

        }

        private async void ServincesDGVData()
        {
            List<Service>services = await serviceBL.GetSpecificCaseServiceAsync(caseId);

            BindingSource servinceSource = new BindingSource();
            servinceSource.DataSource = services;
            ydelserDgv.DataSource = servinceSource;

        }
    }
}
