using BusinessLogic;
using Models;
using System.Data.SqlClient;

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
            try
            {
                List<Client> clients = await clientBL.GetAllAsync();

                BindingSource clientSource = new BindingSource();
                clientSource.DataSource = clients;
                clientsDgv.DataSource = clientSource;
            }
            catch (SqlException)
            {
                MessageBox.Show("Fejl, Operation stoppet: Kunne ikke skrive til Database", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fejl, Operation stoppet: Program fejl", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
