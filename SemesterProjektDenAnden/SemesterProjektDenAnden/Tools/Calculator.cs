using SemesterProjektDenAnden.ClientFroms;
using SemesterProjektDenAnden.EmployeeForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterProjektDenAnden.Tools
{
    public partial class Calculator : Form
    {
        public Calculator(ClientMDI clientMDI)
        {
            InitializeComponent();
        }

        public Calculator(EmployeeMdi employeeMdi)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int G = int.Parse(sizeBox.Text);
                double r = Convert.ToDouble(rateBox.Text);
                int perYear = int.Parse(paymentPYearBox.Text);
                int amountYear = int.Parse(yearsBox.Text);
                int n = perYear * amountYear;

                double amountpyear = 0;
                amountpyear = CalculateFinalValue(G, r, n);
                double amountPYear = CalculateFinalValue (G, r, amountYear);
                amountPYear = Math.Round(amountPYear,2);
                amountpyear = Math.Round(amountpyear,2);
                paymentAmount.Text = amountpyear.ToString();
                paymentPYear.Text = amountPYear.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fejl, Operation stoppet: Program fejl", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static double CalculateFinalValue(double initialInvestment, double interestRate, int numCompoundingPeriods)
        {
            
            double r = interestRate / 100.0;

            
            double finalValue = initialInvestment * r / (1 - Math.Pow(1 + r, -numCompoundingPeriods));

            return finalValue;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void paymentAmount_Click(object sender, EventArgs e)
        {

        }
    }
}
