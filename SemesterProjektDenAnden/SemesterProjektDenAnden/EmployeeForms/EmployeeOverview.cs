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
    public partial class EmployeeOverview : Form
    {
        public EmployeeOverview(EmployeeMdi employeeMdi)
        {
            InitializeComponent();

            sagerBtn.Click += employeeMdi.Sagerbtn_Click;
            toolsBtn.Click += employeeMdi.Toolsbtn_Click;
            employeeBtn.Click += employeeMdi.Employeesbtn_Click;
            clientBtn.Click += employeeMdi.Clientsbtn_Click;

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
