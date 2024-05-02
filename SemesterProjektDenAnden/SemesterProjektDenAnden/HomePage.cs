using SemesterProjektDenAnden.ClientFroms;
using SemesterProjektDenAnden.LogInForms;

namespace SemesterProjektDenAnden
{
    public partial class HomePage : Form
    {

        ClientLogIn clientLogIn = new ClientLogIn();
        EmployeeLogIn employeeLogIn = new EmployeeLogIn();
        public HomePage()
        {
            InitializeComponent();


            //hej hej

            //Bitch
            //hej igen
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clientLogIn.Show();
            this.Hide();
        }

        private void Employeebtn_Click(object sender, EventArgs e)
        {
            employeeLogIn.Show();
            this.Hide();


        }
    }
}
