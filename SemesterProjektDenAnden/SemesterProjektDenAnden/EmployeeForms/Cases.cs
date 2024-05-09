using BusinessLogic;
using BusinessLogic.BLInterfaces;
using DataAcces;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterProjektDenAnden.EmployeeForms
{
    public partial class Cases : Form
    {
        EmployeeMdi employeeMdi;
        
        ICaseBL CaseBL = new CaseBL();
        public Cases(EmployeeMdi employeeMdi)
        {
            InitializeComponent();
            this.employeeMdi = employeeMdi;

            CasesDGVData();
        }

        private void sagerDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            int row = e.RowIndex;
            try { 
            DataGridViewRow temp = dgv.Rows[row];

                int id = (int)temp.Cells[0].Value;

                CaseSpec caseSpec = new CaseSpec(employeeMdi, id);
                employeeMdi.FormOpener(caseSpec);

            }
            catch (Exception ex)
            {
                this.Show();
            }
        }

        private void OpretSagBtn_Click(object sender, EventArgs e)
        {
            CreateCase createCase = new CreateCase(employeeMdi);
            this.employeeMdi.FormOpener(createCase);
        }
        private async void CasesDGVData()
        {
            List<Case> cases = await CaseBL.GetAllAsync();

            BindingSource caseSource = new BindingSource();
            caseSource.DataSource = cases;
            sagerDgv.DataSource = caseSource;

        }
    }
}
