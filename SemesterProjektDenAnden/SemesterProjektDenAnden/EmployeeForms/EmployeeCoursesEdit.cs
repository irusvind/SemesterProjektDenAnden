using BusinessLogic;
using Models;
using System.Data.SqlClient;

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


            try
            {
                DGVData();
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


        private async void DGVData()
        {
            selectedCourses = await employeeBL.GetSpecificCoursesAsync(employeeId);
            possibleCourses = await courseBL.GetAllAsync();


            foreach (Course s in selectedCourses)
            {
                possibleCourses.RemoveAll(p => p.CourseId == s.CourseId);

            }

            UpdateDGV();
        }

        private void PossibleCoursesDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    Course changedCourse = possibleCourses[e.RowIndex];
                    possibleCourses.RemoveAt(e.RowIndex);
                    selectedCourses.Add(changedCourse);
                    UpdateDGV();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fejl, Operation stoppet: Program fejl", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ChosenCoursesDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    Course changedCourse = selectedCourses[e.RowIndex];
                    selectedCourses.RemoveAt(e.RowIndex);
                    possibleCourses.Add(changedCourse);
                    UpdateDGV();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fejl, Operation stoppet: Program fejl", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateDGV()
        {
            selectedCourses = selectedCourses.OrderBy(s => s.CourseId).ToList();
            chosenCoursesDGV.DataSource = selectedCourses;

            possibleCourses = possibleCourses.OrderBy(p => p.CourseId).ToList();
            possibleCoursesDGV.DataSource = possibleCourses;
        }

        private async void OKBtn_Click(object sender, EventArgs e)
        {
            try
            {
                await employeeBL.UpdateCoursesAsync(selectedCourses, employeeId);
                EmployeeSpec employeeSpec = new EmployeeSpec(employeeMdi, employeeId);
                employeeMdi.FormOpener(employeeSpec);
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
