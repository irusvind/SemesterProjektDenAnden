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
        ClientMDI clientMDI = new ClientMDI();
        ClientSignUp clientSignUp;

        public ClientLogIn()
        {
            InitializeComponent();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            clientMDI.Show();
            this.Close();
        }

        private void SignUpbtn_Click(object sender, EventArgs e)
        {
            clientSignUp = new ClientSignUp();
            clientSignUp.Show();
            this.Close();

        }
    }
}
