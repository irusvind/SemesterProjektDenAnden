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

namespace SemesterProjektDenAnden.LogInForms
{
    public partial class ClientLogIn : Form
    {
        ClientMDI clientMDI;
        ClientSignUp clientSignUp;

        public ClientLogIn()
        {
            InitializeComponent();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            clientMDI = new ClientMDI();
            clientMDI.Show();
            this.Close();
        }

        private void SignUpbtn_Click(object sender, EventArgs e)
        {
            clientSignUp = new ClientSignUp();
            clientSignUp.Show();
            this.Close();

        }

        private void ClientLogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Application.OpenForms.Count == 2)
            {
                Application.OpenForms[0].Show();
            }

        }
    }
}
