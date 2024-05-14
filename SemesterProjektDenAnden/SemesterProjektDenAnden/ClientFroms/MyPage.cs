using BusinessLogic;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            client = await clientBL.GetAsync(clientId);
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
                lblPris.Visible = true;
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

        }

        private async void SubscribeBtn_Click(object sender, EventArgs e)
        {
            
            Client updateClient = await clientBL.GetAsync(clientId);
            if (updateClient.Subscriber)
            {
                DialogResult result = MessageBox.Show("Er du sikker på du vil opsige dit abonnement?", "Opsig Abonnement", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    updateClient.Subscriber = false;
                    updateClient.SubEndDate = DateTime.Now;
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

        /*private async void AddMonthsToDate()
        { 
            Form SubcribeForm = new Form();
            SubcribeForm.showdialog();
            
            DateOnly date = DateOnly.FromDateTime(DateTime.Now);
            if ()
            {
                date.AddMonths(1);
            }
            else if ()
            {
                date.AddMonths(3);
            }
            else if()
            {
                date.AddMonths(6);
            }
            else if ()
            {
                date.AddMonths(12);
            }
                

        }*/
    }
}
