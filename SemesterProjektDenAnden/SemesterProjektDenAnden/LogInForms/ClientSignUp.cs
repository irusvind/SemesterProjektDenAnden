using BusinessLogic;
using BusinessLogic.BLInterfaces;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterProjektDenAnden.LogInForms
{
    public partial class ClientSignUp : Form
    {
        ClientLogIn clientLogIn;
        IClientBL ClientBL = new ClientBL();
        public ClientSignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clientLogIn = new ClientLogIn();
            clientLogIn.Show();
            this.Close();
        }

        private void ClientSignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms[0].Show();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            Client newClient = new Client();
            newClient.FirstName = FnameTxt.Text;
            newClient.LastName = LnameTxt.Text;
            newClient.Phone = int.Parse(PhoneTxt.Text);
            newClient.Mail = MailTxt.Text;
            newClient.ClAddress = AddressTxt.Text;
            newClient.Subscriber = SubscribeCB.Checked;
            ClientBL.CreateAsync(newClient);

        }
    }
}
