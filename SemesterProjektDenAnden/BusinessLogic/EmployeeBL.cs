using DataAcces;
using Models;
using Models.Interfaces;

namespace BusinessLogic
{
    public class EmployeeBL : IEmployee
    {
        EmployeeDA employeeDA = new EmployeeDA();

        public async Task<bool> CreateAsync(Employee employee)
        {
            bool result = await employeeDA.CreateAsync(employee);
            return result;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            bool result = await employeeDA.DeleteAsync(id);
            return result;
        }

        public async Task<List<Employee>> GetAllAsync()
        {
            List<Employee> result = await employeeDA.GetAllAsync();
            return result;
        }

        public async Task<Employee> GetAsync(int id)
        {
            Employee employee = await employeeDA.GetAsync(id);
            return employee;
        }

        public async Task<bool> UpdateAsync(Employee employee)
        {
           bool result = await employeeDA.UpdateAsync(employee);
           return result;
        }

        public async Task<List<Course>> GetSpecificCoursesAsync(int employeeId)
        {
            List<Course> courses = await employeeDA.GetSpecificCoursesAsync(employeeId);
            return courses;
        }
        public async Task UpdateCoursesAsync(List<Course> courses, int employeeId)
        {
            await employeeDA.UpdateCoursesAsync(courses, employeeId);
        }
    }
}
