using BusinessLogic;
using Models;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;

namespace SemesterProjektDenAnden.ClientFroms
{
    public partial class MyPage : Form
    {
        ClientBL clientBL;
        Client client;
        ClientMDI clientMdi;
        SubscribeForm subscribeForm;
        int clientId;
        public MyPage(ClientMDI clientMdi, int clientId)
        {
            InitializeComponent();

            clientBL = new ClientBL();
            GetClientData(clientId);
            this.clientMdi = clientMdi;
            this.clientId = clientId;

        }

        private async void GetClientData(int clientId)
        {
            try
            {
                client = await clientBL.GetAsync(clientId);
            }
            catch (SqlException)
            {
                MessageBox.Show("Fejl, Operation stoppet: Kunne ikke hente fra Database", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fejl, Operation stoppet: Program fejl", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            FNameTxt.Text = client.FirstName;
            LNameTxt.Text = client.LastName;
            MailTxt.Text = client.Mail;
            PhoneTxt.Text = client.Phone.ToString();
            AddressTxt.Text = client.ClAddress;

            if (client.Subscriber)
            {
                SubscribtionStatusLbl.Text = "Abonnent";
                SubscribeBtn.Text = "Opsig abonnement";
                lblDato.Visible = true;
                lblDatoen.Visible = true;
                lblDatoen.Text = DateOnly.FromDateTime((DateTime)client.SubEndDate).ToString();
                lblPris.Visible = true;
                lblPrisen.Text = client.SubPrice.ToString() + " kr.";
                lblPrisen.Visible = true;
            }
            else
            {
                SubscribtionStatusLbl.Text = "Ikke abonnent";
                SubscribeBtn.Text = "Start abonnement";
                lblDato.Visible = false;
                lblDatoen.Visible = false;
                lblPris.Visible = false;
                lblPrisen.Visible = false;
            }
        }

        private async void safeChangesbtn_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Er du sikker på du vil opdatere denne klients oplysnigner?", "Opdater klient", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Client updateClient = await clientBL.GetAsync(clientId);
                    updateClient.FirstName = FNameTxt.Text;
                    updateClient.LastName = LNameTxt.Text;
                    updateClient.Phone = int.Parse(PhoneTxt.Text);
                    updateClient.Mail = MailTxt.Text;
                    updateClient.ClAddress = AddressTxt.Text;

                    var context = new ValidationContext(updateClient, serviceProvider: null, items: null);
                    bool isValid = Validator.TryValidateObject(updateClient, context, null, true);

                    if (isValid)
                    {
                        bool updateResult = await clientBL.UpdateAsync(updateClient);
                        if (updateResult)
                        {
                            MessageBox.Show("Klient opdateret", "Klient opdateret");
                        }
                        else
                        {
                            MessageBox.Show("Fejl: Klient ikke opdateret", "Fejl");
                        }
                    }
                    else { MessageBox.Show("Fejl: Klient ikke opdateret", " info ikke valid"); };
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

        private async void SubscribeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Client updateClient = await clientBL.GetAsync(clientId);
                if (updateClient.Subscriber)
                {
                    DialogResult result = MessageBox.Show("Er du sikker på du vil opsige dit abonnement?", "Opsig Abonnement", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        updateClient.Subscriber = false;
                        updateClient.SubEndDate = null;
                        await clientBL.UpdateAsync(updateClient);
                        MyPage newMyPage = new MyPage(clientMdi, clientId);
                        clientMdi.FormOpener(newMyPage);
                    }
                }
                else
                {
                    subscribeForm = new SubscribeForm(clientMdi, clientId);
                    subscribeForm.ShowDialog();
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
