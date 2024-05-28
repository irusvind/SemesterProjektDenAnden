using SemesterProjektDenAnden.EmployeeForms;

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
            Calculator calculator = new Calculator();
            employeeMdi.FormOpener(calculator);
        }
    }
}
