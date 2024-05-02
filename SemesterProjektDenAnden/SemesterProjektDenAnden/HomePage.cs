using SemesterProjektDenAnden.ClientFroms;
using SemesterProjektDenAnden.LogInForms;

namespace SemesterProjektDenAnden
{
    public partial class HomePage : Form
    {

        ClientLogIn clientLogIn;
        EmployeeLogIn employeeLogIn;
        public HomePage()
        {
            InitializeComponent();


            //hej hej

            //Bitch
            //hej igen
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clientLogIn = new ClientLogIn();
            clientLogIn.Show();
            this.Hide();
        }

        private void Employeebtn_Click(object sender, EventArgs e)
        {
            employeeLogIn = new EmployeeLogIn();
            employeeLogIn.Show();
            this.Hide();


        }
    }
}
