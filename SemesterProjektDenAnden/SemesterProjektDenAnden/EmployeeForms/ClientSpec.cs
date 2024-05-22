using BusinessLogic;
using Models;
using System.Data.SqlClient;

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
            try
            {
                Client client = await clientBl.GetAsync(this.clientId);
                clientLbl.Text = client.FirstName + " " + client.LastName + " " + clientId;
                clientIdTxt.Text = client.ClientId.ToString();
                clientFnameTxt.Text = client.FirstName;
                clientLnameTxt.Text = client.LastName;
                clientPhoneTxt.Text = client.Phone.ToString();
                clientMailTxt.Text = client.Mail;
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

        private async void DGVData()
        {
            try
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
            catch (SqlException)
            {
                MessageBox.Show("Fejl, Operation stoppet: Kunne ikke skrive til Database", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fejl, Operation stoppet: Program fejl", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clientCasesDGV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int id = 0;
            int row = e.RowIndex;
            if (row >= 0)
            {
                DataGridViewRow temp = dgv.Rows[row];
                id = (int)temp.Cells[0].Value;
            }

            CaseSpec caseSpec = new CaseSpec(employeeMdi, id);
            employeeMdi.FormOpener(caseSpec);
        }

        private async void updateClientbtn_Click(object sender, EventArgs e)
        {
            try { 
            Client newClient = new Client();
            newClient = await clientBl.GetAsync(clientId);

            newClient.Phone = int.Parse(clientPhoneTxt.Text);
            newClient.FirstName = clientFnameTxt.Text;
            newClient.LastName = clientLnameTxt.Text;
            newClient.Mail = clientMailTxt.Text;
            await clientBl.UpdateAsync(newClient);
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
