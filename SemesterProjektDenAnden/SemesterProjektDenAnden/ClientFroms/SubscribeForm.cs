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
                    
                    await UpdateSubscriber(12, 5555);
                    this.Close();
                }

            }
            else if (CB6mdr.Checked)
            {
                DialogResult result = MessageBox.Show("Velkommen til LawHouse!\nTryk ja for at acceptere dit abonnement på 6 måneder.", "Start Abonnement", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    await UpdateSubscriber(6, 3299);
                    this.Close();
                }
            }
            else if (CB3mdr.Checked)
            {
                DialogResult result = MessageBox.Show("Velkommen til LawHouse!\nTryk ja for at acceptere dit abonnement på 3 måneder.", "Start Abonnement", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    await UpdateSubscriber(3, 1749);
                    this.Close();
                }
            }
            else if (CB1mdr.Checked)
            {
                DialogResult result = MessageBox.Show("Velkommen til LawHouse!\nTryk ja for at acceptere dit abonnement på 1 måneder.", "Start Abonnement", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    await UpdateSubscriber(1, 999);
                    this.Close();
                }
            }
            else
            {
                btnPay.Enabled = false;
            }
        }

        private async Task<bool> UpdateSubscriber(int months, int price)
        {
            Client updateClient = await clientBL.GetAsync(clientId);
            DateTime date = DateTime.Now.AddMonths(months);
            updateClient.Subscriber = true;
            updateClient.SubEndDate = date;
            updateClient.SubPrice = price;
            await clientBL.UpdateAsync(updateClient);
            MyPage myPage = new MyPage(clientMdi, clientId);
            clientMdi.FormOpener(myPage);
            return true;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
