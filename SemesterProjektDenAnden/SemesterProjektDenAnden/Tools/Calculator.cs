using SemesterProjektDenAnden.ClientFroms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void button1_Click(object sender, EventArgs e)
        {
            int G = int.Parse(sizeBox.Text);
            double r = Convert.ToDouble(rateBox.Text) / 100;
            int perYear = int.Parse(paymentPYearBox.Text);
            int amountYear = int.Parse(yearsBox.Text);
            double n = perYear * amountYear;

            double amountpyear = 0;

            double temp;
            double temp2 = (1 + r);

            //temp = G * r / (1 - (1 + r));

            temp = Math.Pow(temp2, n);

            amountpyear = G * (r / (1 + temp));

            paymentAmount.Text = amountpyear.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void paymentAmount_Click(object sender, EventArgs e)
        {

        }
    }
}
