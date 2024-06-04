using BusinessLogic;
using Models;
using System.Data.SqlClient;

namespace SemesterProjektDenAnden.ClientFroms
{
    public partial class SubscribeForm : Form
    {
        ClientMDI clientMdi;
        ClientBL clientBL = new ClientBL();
        int clientId;
        public SubscribeForm(ClientMDI clientMdi, int clientId)
        {
            InitializeComponent();
            this.clientId = clientId;
            this.clientMdi = clientMdi;
            CB1mdr.CheckedChanged += CB1mdr_CheckedChanged;
            CB3mdr.CheckedChanged += CB3mdr_CheckedChanged;
            CB6mdr.CheckedChanged += CB6mdr_CheckedChanged;
            CB12mdr.CheckedChanged += CB12mdr_CheckedChanged;


        }

      

        private async void btnPay_Click(object sender, EventArgs e)
        {

            if (CB12mdr.Checked)
            {
                DialogResult result = MessageBox.Show("Velkommen til LawHouse!\nTryk ja for at acceptere dit abonnement på 12 måneder.", "Start Abonnement", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    await UpdateSubscriber(12, 5555);
                }

            }
            else if (CB6mdr.Checked)
            {
                DialogResult result = MessageBox.Show("Velkommen til LawHouse!\nTryk ja for at acceptere dit abonnement på 6 måneder.", "Start Abonnement", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    await UpdateSubscriber(6, 3299);
                }
            }
            else if (CB3mdr.Checked)
            {
                DialogResult result = MessageBox.Show("Velkommen til LawHouse!\nTryk ja for at acceptere dit abonnement på 3 måneder.", "Start Abonnement", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    await UpdateSubscriber(3, 1749);
                }
            }
            else if (CB1mdr.Checked)
            {
                DialogResult result = MessageBox.Show("Velkommen til LawHouse!\nTryk ja for at acceptere dit abonnement på 1 måneder.", "Start Abonnement", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    await UpdateSubscriber(1, 999);
                }
            }
            else
            {
                btnPay.Enabled = false;
            }
        }

        private async Task UpdateSubscriber(int months, int price)
        {
            try
            {
                Client updateClient = await clientBL.GetAsync(clientId);
                DateTime date = DateTime.Now.AddMonths(months);
                updateClient.Subscriber = true;
                updateClient.SubEndDate = date;
                updateClient.SubPrice = price;
                await clientBL.UpdateAsync(updateClient);
                ClientOverview overview = new ClientOverview(clientMdi);
                clientMdi.FormOpener(overview);
                MyPage myPage = new MyPage(clientMdi, clientId);
                clientMdi.FormOpener(myPage);
                this.Close();
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


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void CB1mdr_CheckedChanged(object? sender, EventArgs e)
        {
            CB3mdr.Checked = false;
            CB6mdr.Checked = false;
            CB12mdr.Checked = false;
        }
        private void CB3mdr_CheckedChanged(object sender, EventArgs e)
        { 
            CB1mdr.Checked = false;
            CB6mdr.Checked = false;
            CB12mdr.Checked = false;
        }
        private void CB6mdr_CheckedChanged(object? sender, EventArgs e)
        {
            CB1mdr.Checked = false;
            CB3mdr.Checked = false;
            CB12mdr.Checked = false;
        }

        private void CB12mdr_CheckedChanged(object? sender, EventArgs e)
        {
            CB1mdr.Checked = false;
            CB3mdr.Checked = false;
            CB6mdr.Checked = false;
        }

    }
}
