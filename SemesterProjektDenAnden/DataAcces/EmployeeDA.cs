using DataAcces.DAInterfaces;
using Models;
using System.Configuration;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

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
            using SqlConnection dbConn = new SqlConnection (connString);
            SqlCommand sqlCommand = new SqlCommand (command, dbConn);
            sqlCommand.Parameters.AddWithValue("@EmFirstName", employee.FirstName);
            sqlCommand.Parameters.AddWithValue("@EmLastName", employee.LastName);
            sqlCommand.Parameters.AddWithValue("@EmPhone", employee.PhoneNumber);
            sqlCommand.Parameters.AddWithValue("@EmMail", employee.Email);
            sqlCommand.Parameters.AddWithValue("@EmAddress", employee.Address);
            sqlCommand.Parameters.AddWithValue("@JobTitle", employee.JobTitle);

            try
            {
                await dbConn.OpenAsync();
                rowsAffected = await sqlCommand.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally { await  dbConn.CloseAsync(); }
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
            string command = "DELETE FROM CLIENT WHERE ClientId = @Id";
            int rowsAffected;
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand ( command, dbConn);
            sqlCommand.Parameters.AddWithValue("@Id", id);
            try
            {
                await dbConn.OpenAsync();
                rowsAffected = await sqlCommand.ExecuteNonQueryAsync();
            }
            catch (Exception ex) 
            {
                return false;
            }
            finally { await dbConn.CloseAsync(); }
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
            string command = "SELECT * FROM CLIENT";
            List<Employee> employees = new List<Employee>();
            using SqlConnection dbConn = new SqlConnection( connString );
            SqlCommand sqlCommand = new SqlCommand (command, dbConn);
            try
            {
                await dbConn.OpenAsync();
                SqlDataReader reader = await sqlCommand.ExecuteReaderAsync();
                while(await reader.ReadAsync())
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
                return employees;
            }
            catch(Exception ex)
            {
                throw;
            }
            finally
            {
                await dbConn.CloseAsync();
            }
        }

        public async Task<Employee> GetAsync(int id)
        {
            string command = "SELECT * FROM EMPLOYEE";
            Employee employee = new Employee();
            List<Employee> list = new List<Employee>();
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            try
            {
                await dbConn.OpenAsync();
                SqlDataReader reader = await sqlCommand.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    if ((int)reader["EmployeeId"] == id)
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
                }
                return new Employee();
            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                await dbConn.CloseAsync();
            }
        }

        public async Task<bool> UpdateAsync(Employee employee)
        {
            string command = "UPDATE CLIENT SET" +
                "EmFirstName = @EmFirstName" +
                "EmLastName = @EmLastName" +
                "EmPhone = @EmPhone" +
                "EmMail = @EmMail" +
                "EmAddress = @EmAddress" +
                "JobTitle = @Jobtitle" +
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
            try
            {
                await dbConn.CloseAsync();
                rowsAffected = await sqlCommand.ExecuteNonQueryAsync();
            }
            catch (Exception e) 
            { 
                throw; 
            }
            finally
            {
                await dbConn.CloseAsync();
            }
            if (rowsAffected > 0)
            {
                return true;
            }
            return false;
        }
    }
}
