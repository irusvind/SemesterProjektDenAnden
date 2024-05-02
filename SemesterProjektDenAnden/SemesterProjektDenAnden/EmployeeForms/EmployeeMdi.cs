using SemesterProjektDenAnden.ClientFroms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterProjektDenAnden.EmployeeForms
{
    public partial class EmployeeMdi : Form
    {
        ClientOverview clientOverview;
        MyPage myPage;
        MyCases myCases;

        public EmployeeMdi()
        {
            InitializeComponent();

            clientOverview = new ClientOverview();
            this.FormOpener(clientOverview);
        }
        private void FormCloser()
        {
            foreach (Form forms in this.MdiChildren)
            {
                forms.Hide();
            }
        }


        private void FormOpener(Form form)
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
            clientOverview = new ClientOverview();
            this.FormOpener(clientOverview);
        }

        private void myPagebtn_Click(object sender, EventArgs e)
        {
            myPage = new MyPage();
            this.FormOpener(myPage);
        }

        private void myCasesbtn_Click(object sender, EventArgs e)
        {
            myCases = new MyCases();
            this.FormOpener(myCases);
        }

        private void ClientMDI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms[0].Close();
        }
    }
}
