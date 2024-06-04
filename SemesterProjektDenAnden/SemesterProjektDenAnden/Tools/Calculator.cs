using SemesterProjektDenAnden.ClientFroms;
using SemesterProjektDenAnden.EmployeeForms;

namespace SemesterProjektDenAnden.Tools
{
    public partial class Calculator : Form
    {
        public Calculator()
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
                 
                double amountPYear = CalculateFinalValue(G, r, amountYear);
                amountpyear = amountPYear / perYear;
                amountPYear = Math.Round(amountPYear, 2);
                amountpyear = Math.Round(amountpyear, 2);
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
            try
            {
                if (interestRate < 0)
                {

                    throw new ArgumentException("Interest rate must be greater than or equal to 0");
                    return 0;
                }
                else { }
                double r = interestRate / 100.0;


                double finalValue = initialInvestment * r / (1 - Math.Pow(1 + r, -numCompoundingPeriods));
                return finalValue;
            }
            

            catch (Exception ex)
            {
                MessageBox.Show("Fejl, Operation stoppet: Program fejl", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            
        }
           

        private void clearAllBtn_Click(object sender, EventArgs e)
        {
            sizeBox.Text = string.Empty;
            rateBox.Text = string.Empty;
            paymentPYearBox.Text = string.Empty;
            yearsBox.Text = string.Empty;
            paymentAmount.Text = string.Empty;
            paymentPYear.Text = string.Empty;
        }
    }
}
