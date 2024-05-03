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
    public class ClientDA : IClientDA
    {
        string connString;
        public ClientDA()
        {
            connString = ConfigurationManager
                         .ConnectionStrings["dbconn"]
                         .ToString();
        }
        public async Task<bool> CreateAsync(Client newClient)
        {
            string command = "INSERT INTO CLIENT VALUES(@FirstName, @LastName, @Phone, @Mail, @ClAddress, @Subscriber)";
            int rowsAffected;
            using SqlConnection dbConn = new SqlConnection (connString);
            SqlCommand sqlCommand = new SqlCommand (command, dbConn);
            sqlCommand.Parameters.AddWithValue("@FirstName", newClient.FirstName);
            sqlCommand.Parameters.AddWithValue("@LastName", newClient.LastName);
            sqlCommand.Parameters.AddWithValue("@Phone", newClient.Phone);
            sqlCommand.Parameters.AddWithValue("@Mail", newClient.Mail);
            sqlCommand.Parameters.AddWithValue("@ClAddress", newClient.ClAddress);
            sqlCommand.Parameters.AddWithValue("@Subscriber", newClient.Subscriber);
            try
            {
                dbConn.OpenAsync();
                rowsAffected = sqlCommand.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                return false;
            }
            finally { dbConn.Close(); }
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
            throw new NotImplementedException();
        }

        public async Task<Client> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Client>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateAsync(Client newClient)
        {
            throw new NotImplementedException();
        }
    }
}
