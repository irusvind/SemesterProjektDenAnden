using Models;
using Models.Interfaces;
using System.Configuration;
using System.Data.SqlClient;

namespace DataAcces
{
    public class EmployeeDA : IEmployee
    {
        string connString;

        public EmployeeDA()
        {
            connString = ConfigurationManager
                        .ConnectionStrings["dbconn"]
                        .ToString();
        }
        public async Task<bool> CreateAsync(Employee employee)
        {
            string command = "INSERT INTO EMPLOYEE VALUES(@EmFirstName, @EmLastName, @EmPhone, @EmMail, @EmAddress, @JobTitle)";
            int rowsAffected;
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            sqlCommand.Parameters.AddWithValue("@EmFirstName", employee.FirstName);
            sqlCommand.Parameters.AddWithValue("@EmLastName", employee.LastName);
            sqlCommand.Parameters.AddWithValue("@EmPhone", employee.PhoneNumber);
            sqlCommand.Parameters.AddWithValue("@EmMail", employee.Email);
            sqlCommand.Parameters.AddWithValue("@EmAddress", employee.Address);
            sqlCommand.Parameters.AddWithValue("@JobTitle", employee.JobTitle);

            await dbConn.OpenAsync();
            rowsAffected = await sqlCommand.ExecuteNonQueryAsync();
            await dbConn.CloseAsync();
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public async Task<bool> DeleteAsync(int id)
        {
            string command = "DELETE FROM EMPLOYEE WHERE EmployeeId = @Id";
            int rowsAffected;
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            sqlCommand.Parameters.AddWithValue("@Id", id);

            await dbConn.OpenAsync();
            rowsAffected = await sqlCommand.ExecuteNonQueryAsync();
            await dbConn.CloseAsync();
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<List<Employee>> GetAllAsync()
        {
            string command = "SELECT * FROM EMPLOYEE";
            List<Employee> employees = new List<Employee>();
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(command, dbConn);

            await dbConn.OpenAsync();
            SqlDataReader reader = await sqlCommand.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                Employee employee = new Employee();
                employee.Id = (int)reader["EmployeeId"];
                employee.FirstName = (string)reader["EmFirstName"];
                employee.LastName = (string)reader["EmLastName"];
                employee.PhoneNumber = (int)reader["EmPhone"];
                employee.Email = (string)reader["EmMail"];
                employee.Address = (string)reader["EmAddress"];
                employee.JobTitle = (string)reader["JobTitle"];
                employees.Add(employee);
            }
            await dbConn.CloseAsync();
            return employees;



        }

        public async Task<Employee> GetAsync(int id)
        {
            string command = "SELECT * FROM EMPLOYEE WHERE EmployeeId = @EmployeeId";
            Employee employee = new Employee();
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            sqlCommand.Parameters.AddWithValue("@EmployeeId", id);

            await dbConn.OpenAsync();
            SqlDataReader reader = await sqlCommand.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {

                employee.Id = (int)reader["EmployeeId"];
                employee.FirstName = (string)reader["EmFirstName"];
                employee.LastName = (string)reader["EmLastName"];
                employee.PhoneNumber = (int)reader["EmPhone"];
                employee.Email = (string)reader["EmMail"];
                employee.Address = (string)reader["EmAddress"];
                employee.JobTitle = (string)reader["JobTitle"];


                return employee;

            }
            await dbConn.CloseAsync();
            return new Employee();



        }

        public async Task<bool> UpdateAsync(Employee employee)
        {
            string command = "UPDATE EMPLOYEE SET " +
                "EmFirstName = @EmFirstName, " +
                "EmLastName = @EmLastName, " +
                "EmPhone = @EmPhone, " +
                "EmMail = @EmMail, " +
                "EmAddress = @EmAddress, " +
                "JobTitle = @JobTitle " +
                "WHERE EmployeeId = @EmployeeId";
            int rowsAffected;
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            sqlCommand.Parameters.AddWithValue("@EmFirstName", employee.FirstName);
            sqlCommand.Parameters.AddWithValue("@EmLastName", employee.LastName);
            sqlCommand.Parameters.AddWithValue("@EmPhone", employee.PhoneNumber);
            sqlCommand.Parameters.AddWithValue("@EmMail", employee.Email);
            sqlCommand.Parameters.AddWithValue("@EmAddress", employee.Address);
            sqlCommand.Parameters.AddWithValue("@JobTitle", employee.JobTitle);
            sqlCommand.Parameters.AddWithValue("@EmployeeId", employee.Id);
            await dbConn.OpenAsync();
            rowsAffected = await sqlCommand.ExecuteNonQueryAsync();
            await dbConn.CloseAsync();

            if (rowsAffected > 0)
            {
                return true;
            }
            return false;
        }


        public async Task<List<Course>> GetSpecificCoursesAsync(int employeeId)
        {
            List<Course> courses = new List<Course>();
            string command = "SELECT COURSE.CourseId, COURSE.CourseName FROM COURSE " +
                "INNER JOIN COMPLETEDCOURSE ON EmployeeId = @EmployeeId AND COMPLETEDCOURSE.CourseId = COURSE.CourseId;";
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            sqlCommand.Parameters.AddWithValue("@EmployeeId", employeeId);

            await dbConn.OpenAsync();
            SqlDataReader reader = await sqlCommand.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                Course course = new Course();
                course.CourseId = (int)reader["CourseId"];
                course.CourseName = (string)reader["CourseName"];
                courses.Add(course);
            }
            await dbConn.CloseAsync();
            return courses;



        }

        public async Task UpdateCoursesAsync(List<Course> courses, int employeeId)
        {

            string deleteCommand = "DELETE FROM COMPLETEDCOURSE WHERE EmployeeId = @employeeId";
            string createCommand = "INSERT INTO COMPLETEDCOURSE (EmployeeId, CourseId) VALUES (@employeeId, @courseId)";
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlDeleteCommand = new SqlCommand(deleteCommand, dbConn);
            sqlDeleteCommand.Parameters.AddWithValue("@employeeId", employeeId);


            await dbConn.OpenAsync();
            await sqlDeleteCommand.ExecuteNonQueryAsync();
            foreach (Course course in courses)
            {
                SqlCommand sqlCreateCommand = new SqlCommand(createCommand, dbConn);
                sqlCreateCommand.Parameters.AddWithValue("@employeeId", employeeId);
                sqlCreateCommand.Parameters.AddWithValue("@courseId", course.CourseId);
                await sqlCreateCommand.ExecuteNonQueryAsync();

            }
            await dbConn.CloseAsync();


        }
    }
}
