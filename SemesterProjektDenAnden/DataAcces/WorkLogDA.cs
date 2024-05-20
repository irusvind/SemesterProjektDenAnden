using DataAcces.DAInterfaces;
using Models;
using System.Configuration;
using System.Data.SqlClient;

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
            string command = "INSERT INTO WORK_LOG VALUES (@StartDate, @EndDate, @WorkDescription, @CaseId, @ServiceId)";
            int rowsAffected;
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            sqlCommand.Parameters.AddWithValue("@StartDate", newWorkLog.StartDate);
            sqlCommand.Parameters.AddWithValue("@EndDate", newWorkLog.EndDate);
            sqlCommand.Parameters.AddWithValue("@WorkDescription", newWorkLog.WorkDescription);
            sqlCommand.Parameters.AddWithValue("@CaseId", newWorkLog.CaseId);
            sqlCommand.Parameters.AddWithValue("@ServiceId", newWorkLog.ServiceId);

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
            string command = "DELETE FROM WORKLOG WHERE WorkLogId = @WorkLogId";
            int rowsAffected;
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            sqlCommand.Parameters.AddWithValue("@WorkLogId", id);

            await dbConn.OpenAsync();
            rowsAffected = await sqlCommand.ExecuteNonQueryAsync();
            await dbConn.CloseAsync();
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
            await dbConn.CloseAsync();
            return new WorkLog();
        }

        public async Task<List<WorkLog>> GetAllAsync(int id)
        {
            string command = "SELECT * FROM WORK_LOG WHERE CaseId = @CaseId";
            List<WorkLog> workLogs = new List<WorkLog>();
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            sqlCommand.Parameters.AddWithValue("@CaseId", id);

            await dbConn.OpenAsync();
            SqlDataReader reader = await sqlCommand.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                WorkLog workLog = new WorkLog();
                workLog.WorkLogId = (int)reader["WorkLogId"];
                workLog.WorkDescription = (string)reader["WorkDescription"];
                workLog.StartDate = (DateTime)reader["WorkStartDate"];
                workLog.EndDate = (DateTime)reader["EndDate"];
                workLog.CaseId = (int)reader["CaseId"];
                workLog.ServiceId = (int)reader["ServiceId"];
                workLogs.Add(workLog);

            }
            await dbConn.CloseAsync();
            return workLogs;
        }

        public async Task<bool> UpdateAsync(WorkLog newWorkLog)
        {
            string command = "UPDATE WORKLOG SET" +
                             "WorkDescription = @WorkDescription";
            int rowsAffected;
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            sqlCommand.Parameters.AddWithValue("@WorkDescription", newWorkLog.WorkDescription);

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
