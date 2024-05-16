using DataAcces;
using SemesterProjektDenAnden.ClientFroms;
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

namespace SemesterProjektDenAnden.Tools
{
    public partial class EmployeeTools : Form
    {
        EmployeeMdi employeeMdi;
        public EmployeeTools(EmployeeMdi employeeMdi)
        {
            InitializeComponent();

            this.employeeMdi = employeeMdi;
        }

        private void Formular1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CaseForm caseForm = new CaseForm();
            employeeMdi.FormOpener(caseForm);
        }

        private void Formular2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CaseForm caseForm = new CaseForm();
            employeeMdi.FormOpener(caseForm);
        }

        private void CalculatorBtn_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator(employeeMdi);
            employeeMdi.FormOpener(calculator);
        }
    }
}
