﻿using BusinessLogic;
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
            this.Close();
        }

        private void ClientSignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            clientLogIn = new ClientLogIn();
            clientLogIn.Show();
        }

        private async void CreateBtn_Click(object sender, EventArgs e)
        {
            string message = "Er du sikker på du vil oprette en bruger med de indtastede værdier?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, "Opret Bruger", buttons);
            if(result == DialogResult.Yes)
            {

                Client newClient = new Client();
                newClient.FirstName = FnameTxt.Text;
                newClient.LastName = LnameTxt.Text;
                newClient.Phone = int.Parse(PhoneTxt.Text);
                newClient.Mail = MailTxt.Text;
                newClient.ClAddress = AddressTxt.Text;
                newClient.Subscriber = SubscribeCB.Checked;
                bool createResult = await ClientBL.CreateAsync(newClient);
                if(createResult == true)
                {
                    MessageBox.Show("Bruger oprettet", "Bruger oprettet");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Fejl: Bruger ikke oprettet", "Fejl");
                }

            }

        }
    }
}
