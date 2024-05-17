using BusinessLogic;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterProjektDenAnden.EmployeeForms
{
    public partial class ClientSpec : Form
    {
        int clientId;
        ClientBL clientBl = new ClientBL();
        CaseBL caseBL = new CaseBL();
        EmployeeMdi employeeMdi;
        public ClientSpec(EmployeeMdi employeeMdi, int clientId)
        {
            InitializeComponent();

            this.clientId = clientId;
            this.employeeMdi = employeeMdi;
            SetData();
            DGVData();
        }

        private async void SetData()
        {
            Client client = await clientBl.GetAsync(this.clientId);

            clientLbl.Text = client.FirstName + " " + client.LastName + " " + clientId;
            clientIdTxt.Text = client.ClientId.ToString();
            clientFnameTxt.Text = client.FirstName;
            clientLnameTxt.Text = client.LastName;
            clientPhoneTxt.Text = client.Phone.ToString();
            clientMailTxt.Text = client.Mail;

        }

        private async void DGVData()
        {
            List<Case> allCases = await caseBL.GetAllAsync();
            List<Case> clientCases = new List<Case>();
            foreach (Case Case in allCases)
            {
                if (Case.ClientId == clientId)
                {
                    clientCases.Add(Case);
                }
            }
            BindingSource caseSource = new BindingSource();
            caseSource.DataSource = clientCases;
            clientCasesDGV.DataSource = caseSource;
        }

        private async void clientDeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Er du sikker på du vil slette denne klient?", "Slet klient", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (await clientBl.DeleteAsync(clientId))
                {
                    MessageBox.Show("Klient slettet", "Klient slettet");
                    Clients clients = new Clients(employeeMdi);
                    employeeMdi.FormOpener(clients);
                }
                else
                {
                    MessageBox.Show("Ukendt fejl: Klient ikke slettet", "Fejl");
                }
            }
        }

        private void clientCasesDGV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int row = e.RowIndex;

            DataGridViewRow temp = dgv.Rows[row];
            int id = (int)temp.Cells[0].Value;

            CaseSpec caseSpec = new CaseSpec(employeeMdi, id);
            employeeMdi.FormOpener(caseSpec);
        }
    }
}
