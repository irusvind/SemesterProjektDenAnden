using BusinessLogic;
using DataAcces;
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

        }

        private async void btnPay_Click(object sender, EventArgs e)
        {

            if (CB12mdr.Checked)
            {
                DialogResult result = MessageBox.Show("Velkommen til LawHouse!\nTryk ja for at acceptere dit abonnement på 12 måneder.", "Start Abonnement", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //Kunne godt være en metode for sig selv, det samme med alle dem nedenunder
                    UpdateSubscriber(12);
                    this.Close();
                }

            }
            else if (CB6mdr.Checked)
            {
                DialogResult result = MessageBox.Show("Velkommen til LawHouse!\nTryk ja for at acceptere dit abonnement på 6 måneder.", "Start Abonnement", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    UpdateSubscriber(6);
                    this.Close();
                }
            }
            else if (CB3mdr.Checked)
            {
                DialogResult result = MessageBox.Show("Velkommen til LawHouse!\nTryk ja for at acceptere dit abonnement på 3 måneder.", "Start Abonnement", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    UpdateSubscriber(3);
                    this.Close();
                }
            }
            else if (CB1mdr.Checked)
            {
                DialogResult result = MessageBox.Show("Velkommen til LawHouse!\nTryk ja for at acceptere dit abonnement på 1 måneder.", "Start Abonnement", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    UpdateSubscriber(1);
                    this.Close();
                }
            }
            else
            {
                btnPay.Enabled = false;
            }
        }

        private async void UpdateSubscriber(int months)
        {
            Client updateClient = await clientBL.GetAsync(clientId);
            DateTime date = DateTime.Now;
            updateClient.Subscriber = true;
            updateClient.SubEndDate = date.AddMonths(12);
            await clientBL.UpdateAsync(updateClient);
            MyPage myPage = new MyPage(clientMdi, clientId);
            clientMdi.FormOpener(myPage);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
