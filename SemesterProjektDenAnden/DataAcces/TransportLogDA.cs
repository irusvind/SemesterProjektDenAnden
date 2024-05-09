using DataAcces.DAInterfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            using SqlConnection dbConn = new SqlConnection (connString);
            SqlCommand sqlCommand = new SqlCommand (command, dbConn);
            sqlCommand.Parameters.AddWithValue("@KmDriven", transport.KmDriven);
            sqlCommand.Parameters.AddWithValue("@LogDescription", transport.LogDescription);
            sqlCommand.Parameters.AddWithValue("@CaseId", transport.CaseId);
            sqlCommand.Parameters.AddWithValue("@ServiceId", transport.ServiceId);
            try
            {
                await dbConn.OpenAsync();
                rowsAffected = await sqlCommand.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally { await dbConn.CloseAsync(); }
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
            SqlCommand sqlCommand = new SqlCommand (command,dbConn);
            sqlCommand.Parameters.AddWithValue("@TransportLogId", id);
            try
            {
                await dbConn.OpenAsync();
                rowsAffected = await sqlCommand.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally { await dbConn.CloseAsync(); }
            if (rowsAffected > 0)
            {
                return true;
            }
            return false;
        }

        public async Task<TransportLog> GetAsync(int id)
        {
            string command = "SELECT * FROM TRANSPORT_LOG WHERE TransportLogId = @TransportLogId";
            TransportLog transportLog = new TransportLog();
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand (command, dbConn);
            sqlCommand.Parameters.AddWithValue("@TransportLogId", id);
            try
            {
                await dbConn.OpenAsync();
                SqlDataReader reader = await sqlCommand.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    transportLog.TransportLogId = (int)reader["TransportLogId"];
                    transportLog.LogDescription = (string)reader["LogDescription"];
                    transportLog.CaseId = (int)reader["CaseId"];
                    transportLog.ServiceId = (int)reader["ServiceId"];

                    return transportLog;
                }
                return new TransportLog();
            }
            catch (Exception e)
            {
                throw;
            }
            finally { await dbConn.CloseAsync(); }
        }

        public async Task<List<TransportLog>> GetAllAsync()
        {
            string command = "SELECT * FROM TRANSPORT_LOG";
            List<TransportLog> transportLogs = new List<TransportLog>();
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand (command,dbConn);
            try
            {
                await dbConn.OpenAsync();
                SqlDataReader reader = await sqlCommand.ExecuteReaderAsync();
                while(await reader.ReadAsync())
                {
                    TransportLog transportLog = new TransportLog();
                    transportLog.TransportLogId = (int)reader["TransportLogId"];
                    transportLog.LogDescription = (string)reader["LogDescription"];
                    transportLog.CaseId = (int)reader["CaseId"];
                    transportLog.ServiceId = (int)reader["ServiceId"];
                    transportLogs.Add(transportLog);

                }
                return transportLogs;
            }
            catch (Exception e)
            {
                throw;
            }
            finally { await dbConn.CloseAsync(); }
        }

        public async Task<bool> UpdateAsync(TransportLog transportLog)
        {
            string command = "UPDATE TRANSPORT_LOG SET" + 
                             "LogDescription = @LogDescription";
            int rowsAffected;
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand ( command,dbConn);
            sqlCommand.Parameters.AddWithValue("@LogDescription", transportLog.LogDescription);
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
            return false;
        }
    }
}
