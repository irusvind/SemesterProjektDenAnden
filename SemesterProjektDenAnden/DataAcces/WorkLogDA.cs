using DataAcces.DAInterfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces
{
    public class WorkLogDA : IWorkLog
    {
        string connString;
        public WorkLogDA()
        {
            connString = ConfigurationManager
                        .ConnectionStrings["dbConn"]
                        .ToString();
        }
        public async Task<bool> CreateAsync(WorkLog newWorkLog)
        {
            string command = "INSERT INTO WORKLOG VALUES (@StartDate, @EndDate, @WorkDescription, @CaseId, @ServiceId)";
            int rowsAffected;
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            sqlCommand.Parameters.AddWithValue("@StartDate", newWorkLog.StartDate);
            sqlCommand.Parameters.AddWithValue("@EndDate", newWorkLog.EndDate);
            sqlCommand.Parameters.AddWithValue("@WorkDescription", newWorkLog.WorkDescription);
            sqlCommand.Parameters.AddWithValue("@CaseId", newWorkLog.CaseId);
            sqlCommand.Parameters.AddWithValue("@ServiceId", newWorkLog.ServiceId);
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
            string command = "DELETE FROM WORKLOG WHERE WorkLogId = @WorkLogId";
            int rowsAffected;
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            sqlCommand.Parameters.AddWithValue("@WorkLogId", id);
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

        public async Task<WorkLog> GetAsync(int id)
        {
            string command = "SELECT * FROM WORKLOG WHERE WorkLogId = @WorkLogId";
            WorkLog workLog = new WorkLog();
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            sqlCommand.Parameters.AddWithValue("@WorkLogId", id);
            try
            {
                await dbConn.OpenAsync();
                SqlDataReader reader = await sqlCommand.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    workLog.WorkLogId = (int)reader["TransportLogId"];
                    workLog.WorkDescription = (string)reader["LogDescription"];
                    workLog.StartDate = (DateTime)reader["StartDate"];
                    workLog.EndDate = (DateTime)reader["EndDate"];
                    workLog.CaseId = (int)reader["CaseId"];
                    workLog.ServiceId = (int)reader["ServiceId"];

                    return workLog;
                }
                return new WorkLog();
            }
            catch (Exception e)
            {
                throw;
            }
            finally { await dbConn.CloseAsync(); }
        }

        public async Task<List<WorkLog>> GetAllAsync()
        {
            string command = "SELECT * FROM WORKLOG";
            List<WorkLog> workLogs = new List<WorkLog>();
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            try
            {
                await dbConn.OpenAsync();
                SqlDataReader reader = await sqlCommand.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    WorkLog workLog = new WorkLog();
                    workLog.WorkLogId = (int)reader["TransportLogId"];
                    workLog.WorkDescription = (string)reader["LogDescription"];
                    workLog.StartDate = (DateTime)reader["StartDate"];
                    workLog.EndDate = (DateTime)reader["EndDate"];
                    workLog.CaseId = (int)reader["CaseId"];
                    workLog.ServiceId = (int)reader["ServiceId"];
                    workLogs.Add(workLog);

                }
                return workLogs;
            }
            catch (Exception e)
            {
                throw;
            }
            finally { await dbConn.CloseAsync(); }
        }

        public async Task<bool> UpdateAsync(WorkLog newWorkLog)
        {
            string command = "UPDATE WORKLOG SET" +
                             "WorkDescription = @WorkDescription";
            int rowsAffected;
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            sqlCommand.Parameters.AddWithValue("@WorkDescription", newWorkLog.WorkDescription);
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
