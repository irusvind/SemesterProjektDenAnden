using BusinessLogic;
using BusinessLogic.BLInterfaces;
using Models;
using SemesterProjektDenAnden.ClientFroms;
using SemesterProjektDenAnden.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterProjektDenAnden.EmployeeForms
{
    public partial class CreateCase : Form
    {
        EmployeeMdi employeeMdi;
        CreateCase createCase;
        ICaseBL CaseBL = new CaseBL();
        public CreateCase()
        {
            InitializeComponent();

        }

        private async void createCaseBtn_Click(object sender, EventArgs e)
        {
            {
                string message = "Er du sikker på du vil oprette en case med de indtastede værdier?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, "Opret case", buttons);
                if (result == DialogResult.Yes)
                {


                    Case newCase = new Case();
                    newCase.CaseTitle = workTitel.Text;
                    newCase.StartDate = startDateCal.SelectionStart;
                    newCase.ExEndDate = endDateCal.SelectionStart;
                    newCase.EstHours = Convert.ToInt32(estimated_hours.Text);
                    newCase.ServiceId = serviceBox.s,; //find sign up for service id
                    newCase.ServiceId = serviceBox.SelectedIndex + 1;
                    newCase.EmployeeId = serviceBox.SelectedIndex + 1;
                    newCase.ClientId = serviceBox.SelectedIndex + 1;
                    newCase.IsClosed = false;
                    
                    var context = new ValidationContext(newCase, serviceProvider: null, items: null);
                    bool isValid = Validator.TryValidateObject(newCase, context, null, true);

                    if (isValid)
                    {
                        bool createResult = await CaseBL.Create(newCase);
                        if (createResult)
                        {
                            MessageBox.Show("Bruger oprettet", "Bruger oprettet");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Fejl: Bruger ikke oprettet", "Fejl");
                        }
                    }
                    else { MessageBox.Show("Fejl: Bruger ikke oprettet", " info ikke valid"); };




                }

            }
        }
    }
}
