using DataAcces.DAInterfaces;
using Models;
using System.Configuration;
using System.Data.SqlClient;

namespace DataAcces
{
    public class TransportLogDA : ITransportLog
    {
        string connString;
        public TransportLogDA()
        {
            connString = ConfigurationManager
                        .ConnectionStrings["dbConn"]
                        .ToString();
        }
        public async Task<bool> CreateAsync(TransportLog transport)
        {
            string command = "INSERT INTO TRANSPORT_LOG VALUES (@KmDriven, @LogDescription, @CaseId, @ServiceId)";
            int rowsAffected;
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            sqlCommand.Parameters.AddWithValue("@KmDriven", transport.KmDriven);
            sqlCommand.Parameters.AddWithValue("@LogDescription", transport.LogDescription);
            sqlCommand.Parameters.AddWithValue("@CaseId", transport.CaseId);
            sqlCommand.Parameters.AddWithValue("@ServiceId", transport.ServiceId);

            await dbConn.OpenAsync();
            rowsAffected = await sqlCommand.ExecuteNonQueryAsync();
            await dbConn.CloseAsync();
            if (rowsAffected > 0)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            string command = "DELETE FROM TRANSPORT_LOG WHERE TransportLogId = @TransportLogId";
            int rowsAffected;
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            sqlCommand.Parameters.AddWithValue("@TransportLogId", id);

            await dbConn.OpenAsync();
            rowsAffected = await sqlCommand.ExecuteNonQueryAsync();
            await dbConn.CloseAsync();
            if (rowsAffected > 0)
            {
                return true;
            }
            return false;
        }

        public async Task<TransportLog> GetAsync(int id)
        {
            string command = "SELECT * FROM TRANSPORT_LOG WHERE CaseId = @CaseId";
            TransportLog transportLog = new TransportLog();
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            sqlCommand.Parameters.AddWithValue("@CaseId", id);

            await dbConn.OpenAsync();
            SqlDataReader reader = await sqlCommand.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                transportLog.TransportLogId = (int)reader["TransportLogId"];
                transportLog.LogDescription = (string)reader["LogDescription"];
                transportLog.KmDriven = (int)reader["KmDriven"];
                transportLog.CaseId = (int)reader["CaseId"];
                transportLog.ServiceId = (int)reader["ServiceId"];

                return transportLog;
            }
            await dbConn.CloseAsync();
            return new TransportLog();
        }

        public async Task<List<TransportLog>> GetAllAsync(int id)
        {
            string command = "SELECT * FROM TRANSPORT_LOG WHERE CaseId = @CaseId";
            List<TransportLog> transportLogs = new List<TransportLog>();
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            sqlCommand.Parameters.AddWithValue("@CaseId", id);


            await dbConn.OpenAsync();
            SqlDataReader reader = await sqlCommand.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                TransportLog transportLog = new TransportLog();
                transportLog.TransportLogId = (int)reader["TransportLogId"];
                transportLog.LogDescription = (string)reader["LogDescription"];
                transportLog.KmDriven = (int)reader["KmDriven"];
                transportLog.CaseId = (int)reader["CaseId"];
                transportLog.ServiceId = (int)reader["ServiceId"];
                transportLogs.Add(transportLog);

            }
            await dbConn.CloseAsync();
            return transportLogs;
        }

        public async Task<bool> UpdateAsync(TransportLog transportLog)
        {
            string command = "UPDATE TRANSPORT_LOG SET" +
                             "LogDescription = @LogDescription";
            int rowsAffected;
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            sqlCommand.Parameters.AddWithValue("@LogDescription", transportLog.LogDescription);

            await dbConn.OpenAsync();
            rowsAffected = await sqlCommand.ExecuteNonQueryAsync();
            await dbConn.CloseAsync();

            if (rowsAffected > 0)
            {
                return true;
            }
            return false;
        }
    }
}
