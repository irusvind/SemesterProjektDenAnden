using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using SemesterProjektDenAnden.EmployeeForms;
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

            OverviewMyPagebtn.Click += clientMdi.myPagebtn_Click;
            OverviewMyCasesbtn.Click += clientMdi.myCasesbtn_Click;
            overviewToolsbtn.Click += clientMdi.Toolsbtn_Click;

        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackColor == Color.Black)
            {
                btn.BackColor = Color.DimGray;
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackColor == Color.DimGray)
            {
                btn.BackColor = Color.Black;
            }
        }
    }
}
