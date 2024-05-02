using SemesterProjektDenAnden.ClientFroms;
using SemesterProjektDenAnden.LogInForms;

namespace SemesterProjektDenAnden
{
    public partial class HomePage : Form
    {

        ClientLogIn clientLogIn;
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


    }
}
