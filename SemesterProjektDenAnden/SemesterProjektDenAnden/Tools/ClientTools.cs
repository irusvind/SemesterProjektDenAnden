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

namespace SemesterProjektDenAnden.Tools
{
    public partial class ClientTools : Form
    {
        ClientMDI clientMDI;
        Calculator calculator;
        public ClientTools(ClientMDI clientMDI)
        {
            InitializeComponent();
            this.clientMDI = clientMDI;

        }

        private void Calculator_Click(object sender, EventArgs e)
        {
            calculator = new Calculator(clientMDI);
            
            clientMDI.FormOpener(calculator);
            
            
        }

        private void Formular1_Click(object sender, EventArgs e)
        {
            CaseForm caseForm = new CaseForm();
            clientMDI.FormOpener(caseForm);
        }

        private void Tools_Load(object sender, EventArgs e)
        {
            
        }
    }
}
