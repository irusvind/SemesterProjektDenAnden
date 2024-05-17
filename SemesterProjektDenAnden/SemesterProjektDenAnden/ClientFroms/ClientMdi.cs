using Microsoft.VisualBasic.ApplicationServices;
using SemesterProjektDenAnden.EmployeeForms;
using SemesterProjektDenAnden.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterProjektDenAnden.ClientFroms
{
    public partial class ClientMDI : Form
    {
        ClientOverview clientOverview;
        MyPage myPage;
        MyCases myCases;
        Tools.ClientTools tools;
        int clientId;
        public bool Formular1Bought = false;
        public bool Formular2Bought = false;

        string path = "Åbne liste.pdf"; 

        public ClientMDI(int clientId)
        {
            InitializeComponent();

            clientOverview = new ClientOverview(this, clientId);
            this.FormOpener(clientOverview);

            this.clientId = clientId;
            ButtonClickColor(overviewbtn);
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
            ButtonClickColor(overviewbtn);
            clientOverview = new ClientOverview(this, clientId);
            this.FormOpener(clientOverview);
        }

        public void myPagebtn_Click(object sender, EventArgs e)
        {
            ButtonClickColor(myPagebtn);
            myPage = new MyPage(this, clientId);
            this.FormOpener(myPage);
        }

        public void myCasesbtn_Click(object sender, EventArgs e)
        {
            ButtonClickColor(myCasesbtn);
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

        public void Toolsbtn_Click(object sender, EventArgs e)
        {
            ButtonClickColor(Toolsbtn);
            tools = new ClientTools(this, clientId);
            this.FormOpener(tools);
        }

        private void clientHelpBtn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo process = new ProcessStartInfo(@"..\..\..\Resources\LawHouse-DMVE231-v1.pdf");
            {
                process.UseShellExecute = true;
            }
            try
            {
                Process.Start(process);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fejl, Operation stoppet: Kunne ikke åbne fil", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

        public void ButtonClickColor(Button btn)
        {
            overviewbtn.BackColor = Color.Black;
            myPagebtn.BackColor = Color.Black;
            myCasesbtn.BackColor = Color.Black;
            Toolsbtn.BackColor = Color.Black;
            btn.BackColor = Color.Gray;
        }
    }
}
