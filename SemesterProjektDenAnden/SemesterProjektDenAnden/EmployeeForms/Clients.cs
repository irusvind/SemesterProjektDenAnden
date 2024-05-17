using BusinessLogic;
using Models;

namespace SemesterProjektDenAnden.EmployeeForms
{
    public partial class Clients : Form
    {
        EmployeeMdi employeeMdi;
        ClientBL clientBL = new ClientBL();
        public Clients(EmployeeMdi employeeMdi)
        {
            InitializeComponent();
            this.employeeMdi = employeeMdi;

            ClientsData();
        }



        private async void ClientsData()
        {
            List<Client> clients = await clientBL.GetAllAsync();

            BindingSource clientSource = new BindingSource();
            clientSource.DataSource = clients;
            clientsDgv.DataSource = clientSource;
        }

        private void clientsDgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int row = e.RowIndex;
            if (row >= 0)
            {
                DataGridViewRow temp = dgv.Rows[row];
                int id = (int)temp.Cells[0].Value;

                ClientSpec clientSpec = new ClientSpec(employeeMdi, id);
                employeeMdi.FormOpener(clientSpec);
            }
        }
    }
}
