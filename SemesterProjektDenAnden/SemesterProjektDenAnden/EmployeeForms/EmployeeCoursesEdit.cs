using BusinessLogic;
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
    public partial class EmployeeCoursesEdit : Form
    {
        EmployeeMdi employeeMdi;
        int employeeId;
        EmployeeBL employeeBL = new EmployeeBL();
        CourseBL courseBL = new CourseBL();
        List<Course> possibleCourses;
        List<Course> selectedCourses; 
        public EmployeeCoursesEdit(EmployeeMdi employeeMdi, int employeeId)
        {
            InitializeComponent();

            this.employeeMdi = employeeMdi;
            this.employeeId = employeeId;

            DGVData();
        }


        private async void DGVData()
        {
            selectedCourses = await employeeBL.GetSpecificCoursesAsync(employeeId);
            List<Course> courses = await courseBL.GetAllAsync();
            possibleCourses = await courseBL.GetAllAsync();

            foreach (Course p in courses)
            {
                foreach(Course s in selectedCourses)
                {
                    if(p.CourseId == s.CourseId)
                    {
                        possibleCourses.Remove(p);
                    }
                }
            }

            BindingSource selectedSource = new BindingSource();
            selectedSource.DataSource = selectedCourses;
            chosenCoursesDGV.DataSource = selectedSource;

            BindingSource possibleSource = new BindingSource();
            possibleSource.DataSource = possibleCourses;
            possibleCoursesDGV.DataSource = possibleSource;
        }

        private void PossibleCoursesDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ChosenCoursesDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            EmployeeSpec employeeSpec = new EmployeeSpec(employeeMdi, employeeId);
            employeeMdi.FormOpener(employeeSpec);
        }
    }
}
