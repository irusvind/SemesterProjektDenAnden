﻿using BusinessLogic;
using Models;
using SemesterProjektDenAnden.EmployeeForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterProjektDenAnden.ClientFroms
{
    public partial class ClientCaseSpec : Form
    {
        int caseId;
        ClientMDI clientMid;
        CaseBL caseBL = new CaseBL();
        ClientBL clientBL = new ClientBL();
        TransportLogBL transportLogBL = new TransportLogBL();
        EmployeeBL employeeBL = new EmployeeBL();
        ServiceBL serviceBL = new ServiceBL();

        public ClientCaseSpec(ClientMDI clientMDI, int CaseId)
        {
            InitializeComponent();
            this.clientMid = clientMDI;
            this.caseId = CaseId;

            SetData();
            ServincesDGVData();

        }

        private async void SetData()
        {
            Case _case = new Case();
            _case = await caseBL.GetAsync(this.caseId);

            Client client = new Client();
            client = await clientBL.GetAsync(_case.ClientId);

            Employee employee = new Employee();
            employee = await employeeBL.GetAsync(_case.EmployeeId);

            TransportLog transport = new TransportLog();
            transport = await transportLogBL.GetAsync(this.caseId);

            sagsNavnNrLbl.Text = _case.CaseTitle + " " + _case.CaseId;
            clientName.Text = client.FirstName + " " + client.LastName;
            clientMail.Text = client.Mail;
            clientNr.Text = client.Phone.ToString();
            employeeNr.Text = employee.PhoneNumber.ToString();
            employeeName.Text = employee.FirstName + " " + employee.LastName;
            employeeMail.Text = employee.Email;
            startDate.Text = _case.StartDate.ToString();
            expectedHour.Text = _case.EstHours.ToString();
            endData.Text = _case.ExEndDate.ToString();

        }

        private async void ServincesDGVData()
        {
            List<Service> services = await serviceBL.GetSpecificCaseServiceAsync(caseId);

            BindingSource servinceSource = new BindingSource();
            servinceSource.DataSource = services;
            ydelserDgv.DataSource = servinceSource;

        }


        private void sagsNavnNrLbl_Click(object sender, EventArgs e)
        {

        }

        private void ydelserDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void ReportBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel File|*.xlsx";
            saveFileDialog.Title = "Save an Excel File";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                string path = saveFileDialog.FileName;
                caseBL.printRapport(caseId,path);
                MessageBox.Show("Rapporten er nu gemt i " + saveFileDialog.FileName);
            }
            //caseBL.printRapport(caseId);
            //MessageBox.Show("Rapporten er nu gemt i bin mappen");
        }
    }
}
