﻿using BusinessLogic;
using Models;
using SemesterProjektDenAnden.ClientFroms;
using System.Data.SqlClient;

namespace SemesterProjektDenAnden.Tools
{
    public partial class ClientTools : Form
    {

        ClientMDI clientMDI;
        Calculator calculator;
        ClientBL clientBL = new ClientBL();
        Client client;
        int clientId;

        public ClientTools(ClientMDI clientMDI, int id)
        {
            InitializeComponent();
            this.clientMDI = clientMDI;
            this.clientId = id;
            ClientData();
            if (clientMDI.Formular1Bought) { BuyForm1Btn.Visible = false; }
            if (clientMDI.Formular2Bought) { BuyForm2Btn.Visible = false; }

        }

        private async void ClientData()
        {
            try
            {
                client = await clientBL.GetAsync(clientId);
                if (client.Subscriber)
                {
                    BuyForm1Btn.Visible = false;
                    BuyForm2Btn.Visible = false;
                    CalculatorLabel.Visible = false;
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

        private void Calculator_Click(object sender, EventArgs e)
        {
            if (client.Subscriber)
            {
                calculator = new Calculator();
                clientMDI.FormOpener(calculator);
            }
        }

        private void Formular1_Click(object sender, EventArgs e)
        {
            if (client.Subscriber || clientMDI.Formular1Bought)
            {
                CaseForm caseForm = new CaseForm();
                clientMDI.FormOpener(caseForm);
            }
        }

        private void Formular2_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (client.Subscriber || clientMDI.Formular2Bought)
            {
                CaseForm caseForm = new CaseForm();
                clientMDI.FormOpener(caseForm);
            }
        }

        private void BuyForm1Btn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Er du sikker på du vil købe formular 1?", "Formular køb", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    clientMDI.Formular1Bought = true;
                    BuyForm1Btn.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fejl, Operation stoppet: Program fejl", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuyForm2Btn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Er du sikker på du vil købe formular 2?", "Formular køb", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    clientMDI.Formular2Bought = true;
                    BuyForm2Btn.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fejl, Operation stoppet: Program fejl", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
