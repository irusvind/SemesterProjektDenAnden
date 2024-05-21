using BusinessLogic;
using Models;
using SemesterProjektDenAnden.ClientFroms;
using System.Data.SqlClient;

namespace SemesterProjektDenAnden.LogInForms
{
    public partial class ClientLogIn : Form
    {
        ClientMDI clientMDI;
        ClientSignUp clientSignUp;
        ClientBL clientBL = new ClientBL();

        public ClientLogIn()
        {
            InitializeComponent();

            AddToCombobox();
        }

        private async void AddToCombobox()
        {
            try
            {
                List<Client> clients = await clientBL.GetAllAsync();
                foreach (Client client in clients)
                {
                    ClientCB.Items.Add(client.ClientId + ": " + client.FirstName + " " + client.LastName);
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

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ClientCB.Text.Length > 0)
                {
                    string[] idString = ClientCB.Items[ClientCB.SelectedIndex].ToString().Split(':');
                    int id = int.Parse(idString[0]);
                    clientMDI = new ClientMDI(id);
                    clientMDI.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fejl, Operation stoppet: Program fejl", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SignUpbtn_Click(object sender, EventArgs e)
        {
            try
            {
                clientSignUp = new ClientSignUp();
                clientSignUp.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fejl, Operation stoppet: Program fejl", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ClientLogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.Count == 2)
            {
                Application.OpenForms[0].Show();
            }

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
