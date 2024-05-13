using BusinessLogic;
using BusinessLogic.BLInterfaces;
using DataAcces;
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


        public CaseSpec(EmployeeMdi employeeMdi, int CaseId)
        {
            InitializeComponent();
            this.employeeMdi = employeeMdi;
            this.caseId = CaseId;
            SetData();
        }
        private async void SetData()
        {
            Case @case = new Case();
            @case = await caseBL.GetAsync(this.caseId);

            Client client = new Client();
            client = await clientBL.GetAsync(this.caseId);

            Employee employee = new Employee();
            employee = await employeeBL.GetAsync(this.caseId);

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
            //usedHoursbox.Text = toDO 
            kmBox.Text = transport.KmDriven.ToString();

        }
    }
    
}
