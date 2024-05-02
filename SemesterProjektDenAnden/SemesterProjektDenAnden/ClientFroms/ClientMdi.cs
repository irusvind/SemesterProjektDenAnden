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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SemesterProjektDenAnden.ClientFroms
{
    public partial class ClientMDI : Form
    {
        ClientOverview clientOverview;
        MyPage myPage;
        MyCases myCases;
        Tools.ClientTools tools;
        

        public ClientMDI()
        {
            InitializeComponent();

            clientOverview = new ClientOverview(this);
            this.FormOpener(clientOverview);
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
            clientOverview = new ClientOverview(this);
            this.FormOpener(clientOverview);
        }

        private void myPagebtn_Click(object sender, EventArgs e)
        {
            myPage = new MyPage(this);
            this.FormOpener(myPage);
        }

        private void myCasesbtn_Click(object sender, EventArgs e)
        {
            myCases = new MyCases(this);
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



        //private void overviewbtn_Click(object sender, EventArgs e)
        //{


        //    if (clientOverview == null)
        //    {
        //        this.FormCloser();
        //        clientOverview = new ClientOverview();
        //        clientOverview.FormClosed += clientOverview_FormClosed;
        //        clientOverview.MdiParent = this;
        //        clientOverview.Show();
        //    }
        //    else
        //    {
        //        clientOverview.Activate();
        //    }

        //}

        //private void clientOverview_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    clientOverview = null;
        //}

        //private void myPagebtn_Click(object sender, EventArgs e)
        //{


        //    if (myPage == null)
        //    {
        //        this.FormCloser();
        //        myPage = new MyPage();
        //        myPage.FormClosed += myPage_FormClosed;
        //        myPage.MdiParent = this;
        //        myPage.Show();
        //    }
        //    else
        //    {
        //        myPage.Activate();
        //    }

        //}

        //private void myPage_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    myPage = null;
        //}

        //private void myCasesbtn_Click(object sender, EventArgs e)
        //{


        //    if (myCases == null)
        //    {
        //        this.FormCloser();
        //        myCases = new MyCases();
        //        myCases.FormClosed += myCases_FormClosed;
        //        myCases.MdiParent = this;
        //        myCases.Show();
        //    }
        //    else
        //    {
        //        myCases.Activate();
        //    }
        //}



        //private void myCases_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    myCases = null;
        //}
    }
}
