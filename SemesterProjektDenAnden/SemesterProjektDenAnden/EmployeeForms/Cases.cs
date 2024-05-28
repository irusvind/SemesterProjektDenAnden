using BusinessLogic;
using Models;
using System.Data.SqlClient;

namespace SemesterProjektDenAnden.EmployeeForms
{
    public partial class Cases : Form
    {
        EmployeeMdi employeeMdi;
        
        CaseBL CaseBL = new CaseBL();
        public Cases(EmployeeMdi employeeMdi)
        {
            InitializeComponent();
            this.employeeMdi = employeeMdi;

            CasesDGVData();
        }

        private void sagerDgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            int row = e.RowIndex;
            if (row >= 0)
            {
                DataGridViewRow temp = dgv.Rows[row];

                int id = (int)temp.Cells[0].Value;

                CaseSpec caseSpec = new CaseSpec(employeeMdi, id);
                employeeMdi.FormOpener(caseSpec);
            }

        }

        private void OpretSagBtn_Click(object sender, EventArgs e)
        {
            CreateCase createCase = new CreateCase(employeeMdi);
            this.employeeMdi.FormOpener(createCase);
        }
        private async void CasesDGVData()
        {
            try
            {
                List<Case> cases = await CaseBL.GetAllAsync();
                BindingSource caseSource = new BindingSource();
                caseSource.DataSource = cases;
                sagerDgv.DataSource = caseSource;
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
    }
}
