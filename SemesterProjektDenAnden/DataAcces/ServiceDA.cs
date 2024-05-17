using DataAcces.DAInterfaces;
using Models;
using System.Configuration;
using System.Data.SqlClient;

namespace DataAcces
{
    public class ServiceDA : IService
    {
        string connString;

        public ServiceDA()
        {
            connString = ConfigurationManager
                        .ConnectionStrings["dbConn"]
                        .ToString();
        }
        public async Task<bool> DeleteAsync(int id)
        {
            string command = "DELETE FROM SERVICE_ WHERE ServiceId = @ServiceId";
            int rowAffected;
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            sqlCommand.Parameters.AddWithValue("@ServiceId", id);

            await dbConn.OpenAsync();
            rowAffected = await sqlCommand.ExecuteNonQueryAsync();
            await dbConn.CloseAsync();

            if (rowAffected > 0)
            {
                return true;
            }
            return false;
        }


        public async Task<List<Service>> GetAllAsync()
        {
            string command = "SELECT * FROM SERVICE_";
            List<Service> services = new List<Service>();
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(command, dbConn);

            await dbConn.OpenAsync();
            SqlDataReader reader = await sqlCommand.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                Service newService = new Service();
                newService.ServiceId = (int)reader["ServiceId"];
                newService.ServiceName = (string)reader["ServiceName"];
                newService.Price = (double)reader["Price"];
                newService.PriceHourly = (bool)reader["PriceHourly"];
                services.Add(newService);
            }
            await dbConn.CloseAsync();
            return services;
        }

        public async Task<Service> GetAsync(int id)
        {
            string command = "SELECT * FROM SERVICE_ WHERE ServiceId = @ServiceId";
            Service service = new Service();
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            sqlCommand.Parameters.AddWithValue("ServiceId", id);

            await dbConn.OpenAsync();
            SqlDataReader reader = await sqlCommand.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                service.ServiceId = (int)reader["ServiceId"];
                service.ServiceName = (string)reader["ServiceName"];
                service.Price = (float)reader["Price"];
                service.PriceHourly = (bool)reader["PriceHourly"];

                return service;
            }
            return new Service();
            await dbConn.CloseAsync();
        }

        public async Task UpdateServicesAsync(int serviceId, int caseId)
        {

            
            string createCommand = "INSERT INTO SERVICELIST (CaseId, serviceId) VALUES (@caseID, @ServiceId)";
            int rowsAffected;
            using SqlConnection dbConn = new SqlConnection(connString);

            try
            {
                await dbConn.OpenAsync();
                
                    SqlCommand sqlCreateCommand = new SqlCommand(createCommand, dbConn);
                    sqlCreateCommand.Parameters.AddWithValue("@caseID", caseId);
                    sqlCreateCommand.Parameters.AddWithValue("@ServiceId", serviceId);
                    await sqlCreateCommand.ExecuteNonQueryAsync();

                
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
        public async Task<List<Service>> GetSpecificCaseServiceAsync(int caseId)
        {
            List<Service> services  = new List<Service>();
            string command = "SELECT SERVICE_.ServiceId, SERVICE_.ServiceName FROM SERVICE_ " +
                "INNER JOIN SERVICELIST ON SERVICELIST.CaseId = @caseId AND SERVICELIST.ServiceId = SERVICE_.ServiceId";
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            sqlCommand.Parameters.AddWithValue("@CaseId", caseId);
            try
            {
                await dbConn.OpenAsync();
                SqlDataReader reader = await sqlCommand.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    Service service = new Service();
                    service.ServiceId = (int)reader["ServiceId"];
                    service.ServiceName = (string)reader["ServiceName"];
                    services.Add(service);
                }
                return services;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                await dbConn.CloseAsync();
            }
        }


    }
}
