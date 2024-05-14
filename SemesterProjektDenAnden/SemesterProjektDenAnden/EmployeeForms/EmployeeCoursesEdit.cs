using BusinessLogic;
using Models;

namespace SemesterProjektDenAnden.EmployeeForms
{
    //mangler async 
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
            possibleCourses = await courseBL.GetAllAsync();


            foreach (Course s in selectedCourses)
            {
                possibleCourses.RemoveAll(p => p.CourseId == s.CourseId);

            }

            UpdateDGV();
        }

        private void PossibleCoursesDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Course changedCourse = possibleCourses[e.RowIndex];
            possibleCourses.RemoveAt(e.RowIndex);
            selectedCourses.Add(changedCourse);
            UpdateDGV();
        }

        private void ChosenCoursesDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Course changedCourse = selectedCourses[e.RowIndex];
            selectedCourses.RemoveAt(e.RowIndex);
            possibleCourses.Add(changedCourse);
            UpdateDGV();
        }

        private void UpdateDGV() 
        {
            BindingSource selectedSource = new BindingSource();
            List<Course> sortetSelected = selectedCourses.OrderBy(s => s.CourseId).ToList();
            selectedSource.DataSource = sortetSelected;
            chosenCoursesDGV.DataSource = selectedSource;

            BindingSource possibleSource = new BindingSource();
            List<Course> sortetPossible = possibleCourses.OrderBy(p => p.CourseId).ToList();
            possibleSource.DataSource = sortetPossible;
            possibleCoursesDGV.DataSource = possibleSource;
        }

        private async void OKBtn_Click(object sender, EventArgs e)
        {
            await employeeBL.UpdateCoursesAsync(selectedCourses, employeeId);
            EmployeeSpec employeeSpec = new EmployeeSpec(employeeMdi, employeeId);
            employeeMdi.FormOpener(employeeSpec);
        }
    }
}
