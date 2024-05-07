using DataAcces.DAInterfaces;
using Models;
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
            string command = "INSERT INTO EMPLOYEE VALUES(@FirstName, @LastName, @Phone, @Mail, @EmAddress, @JobTitle)";
            int rowsAffected;
            using SqlConnection dbConn = new SqlConnection (connString);
            SqlCommand sqlCommand = new SqlCommand (command, dbConn);
            sqlCommand.Parameters.AddWithValue("@FirstName", employee.FirstName);
            sqlCommand.Parameters.AddWithValue("@LastName", employee.LastName);
            sqlCommand.Parameters.AddWithValue("@Phone", employee.PhoneNumber);
            sqlCommand.Parameters.AddWithValue("@Mail", employee.Email);
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
                        employee.FirstName = (string)reader["FirstName"];

                    }
                }
            }
        }

        public Task<bool> UpdateAsync(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
