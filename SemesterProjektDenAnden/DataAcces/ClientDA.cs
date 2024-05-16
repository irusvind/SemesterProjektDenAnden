using DataAcces.DAInterfaces;
using Models;
using System.Configuration;
using System.Data.SqlClient;
using System.Net;

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
            string command = "INSERT INTO CLIENT VALUES(@ClFirstName, @ClLastName, @ClPhone, @ClMail, @ClAddress, @Subscriber, @SubEndDate)";
            int rowsAffected;
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            sqlCommand.Parameters.AddWithValue("@ClFirstName", newClient.FirstName);
            sqlCommand.Parameters.AddWithValue("@ClLastName", newClient.LastName);
            sqlCommand.Parameters.AddWithValue("@ClPhone", newClient.Phone);
            sqlCommand.Parameters.AddWithValue("@ClMail", newClient.Mail);
            sqlCommand.Parameters.AddWithValue("@ClAddress", newClient.ClAddress);
            sqlCommand.Parameters.AddWithValue("@Subscriber", newClient.Subscriber);
            if (newClient.SubEndDate == null)
            {
                sqlCommand.Parameters.AddWithValue("@SubEndDate", DBNull.Value);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@SubEndDate", newClient.SubEndDate);
            }
            try
            {
                await dbConn.OpenAsync();
                rowsAffected = await sqlCommand.ExecuteNonQueryAsync();

            }
            catch (Exception e)
            {
                throw;
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

        public async Task<bool> DeleteAsync(int id)
        {
            string command = "DELETE FROM CLIENT WHERE ClientId = @Id";
            int rowsAffected;
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            sqlCommand.Parameters.AddWithValue("@Id", id);
            try
            {
                await dbConn.OpenAsync();
                rowsAffected = await sqlCommand.ExecuteNonQueryAsync();

            }
            catch (Exception e)
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

        public async Task<Client> GetAsync(int id)
        {
            string command = "SELECT * FROM CLIENT WHERE ClientId = @ClientId";
            Client newClient = new Client();
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            sqlCommand.Parameters.AddWithValue("@ClientId", id);
            try
            {
                await dbConn.OpenAsync();
                SqlDataReader reader = await sqlCommand.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    newClient.ClientId = (int)reader["ClientId"];
                    newClient.FirstName = (string)reader["ClFirstName"];
                    newClient.LastName = (string)reader["ClLastName"];
                    newClient.Phone = (int)reader["ClPhone"];
                    newClient.Mail = (string)reader["ClMail"];
                    newClient.ClAddress = (string)reader["CLAddress"];
                    newClient.Subscriber = (bool)reader["Subscriber"];
                    string? date = (string?)reader["SubEndDate"].ToString();
                    newClient.SubPrice = (int?)reader["SubPrice"];
                    if (string.IsNullOrEmpty(date))
                    {
                        date = "";
                    }
                    else
                    { newClient.SubEndDate = DateTime.Parse(date); }

                    return newClient;

                }
                return new Client();
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

        public async Task<List<Client>> GetAllAsync()
        {
            string command = "SELECT * FROM CLIENT";
            List<Client> newClientList = new List<Client>();
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            try
            {
                await dbConn.OpenAsync();
                SqlDataReader reader = await sqlCommand.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    Client newClient = new Client();
                    newClient.ClientId = (int)reader["ClientId"];
                    newClient.FirstName = (string)reader["ClFirstName"];
                    newClient.LastName = (string)reader["ClLastName"];
                    newClient.Phone = (int)reader["ClPhone"];
                    newClient.Mail = (string)reader["ClMail"];
                    newClient.ClAddress = (string)reader["CLAddress"];
                    newClient.Subscriber = (bool)reader["Subscriber"];
                    string? date = (string?)reader["SubEndDate"].ToString();
                    int? price = newClient.SubPrice = (int?)reader["SubPrice"];
                    if (string.IsNullOrEmpty(date))
                    {
                        date = "";
                    }
                    else
                    { newClient.SubEndDate = DateTime.Parse(date); }
                    newClientList.Add(newClient);

                    if ()

                }
                return newClientList;
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


        public async Task<bool> UpdateAsync(Client newClient)
        {
            string command = "UPDATE CLIENT SET " +
                "ClFirstName = @ClFirstName, " +
                "ClLastName = @ClLastName, " +
                "ClPhone = @ClPhone, " +
                "ClMail = @ClMail, " +
                "CLAddress = @CLAddress, " +
                "Subscriber = @Subscriber, " +
                "SubEndDate = @SubEndDate, " +
                "SubPrice = @SubPrice"  +
                "WHERE ClientID = @ClientId ";
            int rowsAffected;
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            sqlCommand.Parameters.AddWithValue("@ClFirstName", newClient.FirstName);
            sqlCommand.Parameters.AddWithValue("@ClLastName", newClient.LastName);
            sqlCommand.Parameters.AddWithValue("@ClPhone", newClient.Phone);
            sqlCommand.Parameters.AddWithValue("@ClMail", newClient.Mail);
            sqlCommand.Parameters.AddWithValue("@ClAddress", newClient.ClAddress);
            sqlCommand.Parameters.AddWithValue("@Subscriber", newClient.Subscriber);
            if(newClient.SubEndDate == null)
            {
                sqlCommand.Parameters.AddWithValue("@SubEndDate", DBNull.Value);
            } 
            else 
            { 
                sqlCommand.Parameters.AddWithValue("@SubEndDate", newClient.SubEndDate);
                sqlCommand.Parameters.AddWithValue("@SubPrice", newClient.SubPrice);
            }
            sqlCommand.Parameters.AddWithValue("@ClientId", newClient.ClientId);
            try
            {
                await dbConn.OpenAsync();
                rowsAffected = await sqlCommand.ExecuteNonQueryAsync();

            }
            catch (Exception e)
            {
                throw;
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
    }
}
