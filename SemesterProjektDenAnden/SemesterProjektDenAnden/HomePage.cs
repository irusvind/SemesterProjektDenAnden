using SemesterProjektDenAnden.ClientFroms;

namespace SemesterProjektDenAnden
{
    public partial class HomePage : Form
    {

        ClientMDI CO = new ClientMDI();
        public HomePage()
        {
            InitializeComponent();


            //hej hej

            //Bitch
            //hej igen
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CO.Show();
            this.Hide();
        }
    }
}
