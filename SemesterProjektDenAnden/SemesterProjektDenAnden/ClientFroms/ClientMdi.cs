using Microsoft.VisualBasic.ApplicationServices;
using SemesterProjektDenAnden.EmployeeForms;
using SemesterProjektDenAnden.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SemesterProjektDenAnden.ClientFroms
{
    public partial class ClientMDI : Form
    {
        ClientOverview clientOverview;
        MyPage myPage;
        MyCases myCases;
        Tools.ClientTools tools;
        int clientId;

        string path = "Åbne liste.pdf"; 

        public ClientMDI(int clientId)
        {
            InitializeComponent();

            clientOverview = new ClientOverview(this, clientId);
            this.FormOpener(clientOverview);

            this.clientId = clientId;
        }


        private void FormCloser()
        {
            foreach (Form forms in this.MdiChildren)
            {
                forms.Hide();
            }
        }


        public void FormOpener(Form form)
        {
            if (this.MdiChildren.Length == 0 || this.MdiChildren[0] != form)
            {
                this.FormCloser();
                form.FormClosed += FormClosed;
                form.MdiParent = this;
                form.Dock = DockStyle.Fill;
                form.Show();
            }
            else
            {
                form.Activate();
            }

            void FormClosed(object sender, FormClosedEventArgs e)
            {
                form = null;
            }
        }

        private void overviewbtn_Click(object sender, EventArgs e)
        {
            clientOverview = new ClientOverview(this, clientId);
            this.FormOpener(clientOverview);
        }

        private void myPagebtn_Click(object sender, EventArgs e)
        {
            myPage = new MyPage(this, clientId);
            this.FormOpener(myPage);
        }

        private void myCasesbtn_Click(object sender, EventArgs e)
        {
            myCases = new MyCases(this,clientId);
            this.FormOpener(myCases);
        }

        private void ClientMDI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms[0].Show();
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Toolsbtn_Click(object sender, EventArgs e)
        {
            tools = new ClientTools(this);
            this.FormOpener(tools);
        }

        private void clientHelpBtn_Click(object sender, EventArgs e)
        {
            //File.Open(path, FileMode.Open);

            //System.Diagnostics.Process.Start(path);

        }
    }
}
