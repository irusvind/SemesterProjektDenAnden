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
        CaseSpec caseSpec;
        public Cases(EmployeeMdi employeeMdi)
        {
            InitializeComponent();
            this.employeeMdi = employeeMdi;
        }

        private void sagerDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            int row = e.RowIndex;
        
            DataGridViewRow temp = dgv.Rows[row];
            int caseId = (int)temp.Cells[nameof(Case.CaseId)].Value;

            caseSpec = new CaseSpec(employeeMdi, caseId);
            employeeMdi.FormOpener(caseSpec);
        }
    }
}
