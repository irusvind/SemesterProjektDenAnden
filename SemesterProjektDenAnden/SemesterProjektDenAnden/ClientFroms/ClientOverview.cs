using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SemesterProjektDenAnden.Tools;

namespace SemesterProjektDenAnden.ClientFroms
{
    public partial class ClientOverview : Form
    {
        ClientMDI clientMdi;
        MyPage myPage;
        MyCases myCases;
        int clientId;
        public ClientOverview(ClientMDI clientMdi, int clientId)
        {
            InitializeComponent();

            this.clientMdi = clientMdi;
            this.clientId = clientId;
        }

        private void OverviewMyPagebtn_Click(object sender, EventArgs e)
        {
            myPage = new MyPage(clientMdi, clientId);
            clientMdi.FormOpener(myPage);
        }

        private void OverviewMyCasesbtn_Click(object sender, EventArgs e)
        {
            myCases = new MyCases(clientMdi);
            clientMdi.FormOpener(myCases);
        }

        private void overviewToolsbtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
