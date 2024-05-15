using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcces.DAInterfaces;
using Models;

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
            try
            {
                await dbConn.OpenAsync();
                rowAffected = await sqlCommand.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                await dbConn.CloseAsync();
            }
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
            try
            {
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
                return services;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally { await dbConn.CloseAsync(); }  
        }

        public async Task<Service> GetAsync(int id)
        {
            string command = "SELECT * FROM SERVICE_ WHERE ServiceId = @ServiceId";
            Service service = new Service();
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            sqlCommand.Parameters.AddWithValue("ServiceId", id);
            try
            {
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
            }
            catch (Exception e)
            {
                throw;
            }
            finally { await dbConn.CloseAsync(); }
        }

    }
}
