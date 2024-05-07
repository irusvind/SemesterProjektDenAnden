using BusinessLogic;
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

namespace SemesterProjektDenAnden.ClientFroms
{
    public partial class MyPage : Form
    {
        ClientBL clientBL;
        Client client;
        public MyPage(ClientMDI clientMdi, int clientId)
        {
            InitializeComponent();

            clientBL = new ClientBL();
            GetClientData(clientId);

        }

        public async void GetClientData(int clientId)
        {
            client = await clientBL.GetAsync(clientId);
            FNameTxt.Text = client.FirstName;
            LNameTxt.Text = client.LastName;
            MailTxt.Text = client.Mail;
            PhoneTxt.Text = client.Phone.ToString();
            AddressTxt.Text = client.ClAddress;
            if(client.Subscriber)
            {
                SubscribtionStatusLbl.Text = "Abonnent";
            }
            else
            {
                SubscribtionStatusLbl.Text = "Ikke abonnent";
            }
        }
    }
}
