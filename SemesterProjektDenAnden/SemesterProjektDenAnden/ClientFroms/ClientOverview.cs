
namespace SemesterProjektDenAnden.ClientFroms
{
    public partial class ClientOverview : Form
    {

        public ClientOverview(ClientMDI clientMdi)
        {
            InitializeComponent();

            OverviewMyPagebtn.Click += clientMdi.myPagebtn_Click;
            OverviewMyCasesbtn.Click += clientMdi.myCasesbtn_Click;
            overviewToolsbtn.Click += clientMdi.Toolsbtn_Click;

        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackColor == Color.Black)
            {
                btn.BackColor = Color.DimGray;
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackColor == Color.DimGray)
            {
                btn.BackColor = Color.Black;
            }
        }
    }
}
