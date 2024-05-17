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
    public partial class MyCases : Form
    {
        ClientMDI clientMdi;
        CaseBL caseBL = new CaseBL();
        int clientId;

        public MyCases(ClientMDI clientMdi, int clientId)
        {
            InitializeComponent();
            this.clientMdi = clientMdi;
            this.clientId = clientId;

            CLientCases(clientId);
        }

        private async void CLientCases(int id)
        {
            List<Case> clientCases = await caseBL.GetCaseWithClientIdAsync(id);

            BindingSource caseSource = new BindingSource();
            caseSource.DataSource = clientCases;
            casesDgv.DataSource = caseSource;
        }

        private void casesDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                DataGridView dgv = (DataGridView)sender;

                int row = e.RowIndex;
                if (row >= 0)
                {
                    DataGridViewRow temp = dgv.Rows[row];

                    int id = (int)temp.Cells[0].Value;

                    ClientCaseSpec caseSpec = new ClientCaseSpec(clientMdi, id);
                    clientMdi.FormOpener(caseSpec);
                }

            }
        }
    }
}