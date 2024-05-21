using BusinessLogic;
using DataAcces;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterProjektDenAnden.EmployeeForms
{
    public partial class Transport : Form
    {

        int caseId;
        EmployeeMdi employeeMdi;
        CaseBL caseBL = new CaseBL();
        TransportLogBL transportLogBL = new TransportLogBL();
        EmployeeBL employeeBL = new EmployeeBL();
        ServiceBL serviceBL = new ServiceBL();
        public Transport(int CaseId)
        {
            InitializeComponent();
            this.caseId = CaseId;
            AddToServiceCombobox();
            
        }

        

        private async void addTransport_Click(object sender, EventArgs e)
        {
            try
            {
                TransportLog transportLog = new TransportLog();
                transportLog.KmDriven = int.Parse(kilometerBox.Text);
                transportLog.LogDescription = transDesBox.Text;
                transportLog.CaseId = caseId;
                transportLog.ServiceId = serviceCombo.SelectedIndex;

                await transportLogBL.CreateAsync(transportLog);
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
                List<Service> services = await serviceBL.GetSpecificCaseServiceAsync(caseId);
                foreach (Service service in services)
                {
                    serviceCombo.Items.Add(service.ServiceId + " : " + service.ServiceName);
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
