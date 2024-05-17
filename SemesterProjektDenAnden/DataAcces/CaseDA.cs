using DataAcces.DAInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Configuration;
using System.Data.SqlClient;
using System.Net;

namespace DataAcces
{
    public class CaseDA : ICase
    {
        string connString;
        public CaseDA()
        {
            connString = ConfigurationManager
                         .ConnectionStrings["dbconn"]
                         .ToString();
        }
        public async Task<bool> CreateAsync(Case newCase)
        {

            {
                string command = "INSERT INTO CASE_ VALUES(@CaseTitle, @CaseStartDate, @EstEndDate, @EstHours,@UsedHours, @Done, @EmployeeId, @ClientId)";
                int rowsAffected;
                using SqlConnection dbConn = new SqlConnection(connString);
                SqlCommand sqlCommand = new SqlCommand(command, dbConn);
                sqlCommand.Parameters.AddWithValue("@CaseTitle", newCase.CaseTitle);
                sqlCommand.Parameters.AddWithValue("@CaseStartDate", newCase.StartDate);
                sqlCommand.Parameters.AddWithValue("@EstEndDate", newCase.ExEndDate);
                sqlCommand.Parameters.AddWithValue("@EstHours", newCase.EstHours);
                sqlCommand.Parameters.AddWithValue("@UsedHours", newCase.UsedHours);
                sqlCommand.Parameters.AddWithValue("@Done", newCase.Done);
                sqlCommand.Parameters.AddWithValue("@EmployeeId", newCase.EmployeeId);
                sqlCommand.Parameters.AddWithValue("@ClientId", newCase.ClientId);

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

        public async Task<bool> DeleteAsync(int id)
        {
            string command = "DELETE FROM CASE_ WHERE CaseId = @Id";
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

        public async Task<Case> GetAsync(int id)
        {
            string command = "SELECT * FROM CASE_ WHERE CaseId = @CaseId";
            Case newCase = new Case();
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            sqlCommand.Parameters.AddWithValue("@CaseId", id);
            try
            {
                await dbConn.OpenAsync();
                SqlDataReader reader = await sqlCommand.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    newCase.CaseId = (int)reader["CaseId"];
                    newCase.CaseTitle = (string)reader["CaseTitle"];
                    newCase.StartDate = (DateTime)reader["CaseStartDate"];
                    newCase.ExEndDate = (DateTime)reader["EstEndDate"];
                    newCase.EstHours = (int)reader["EstHours"];
                    if (reader["UsedHours"] != DBNull.Value)
                    {
                        newCase.UsedHours = (int)reader["UsedHours"];
                    }
                    else newCase.UsedHours = 0;
                    newCase.Done = (bool)reader["Done"];
                    newCase.EmployeeId = (int)reader["EmployeeId"];
                    newCase.ClientId = (int)reader["ClientId"];

                    return newCase;

                }
                return new Case();
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

        public async Task<List<Case>> GetAllAsync()
        {
            string command = "SELECT * FROM CASE_";
            List<Case> newCaseList = new List<Case>();
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            try
            {
                await dbConn.OpenAsync();
                SqlDataReader reader = await sqlCommand.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    Case newCase = new Case();
                    newCase.CaseId = (int)reader["CaseId"];
                    newCase.CaseTitle = (string)reader["CaseTitle"];

                    newCase.StartDate = (DateTime)reader["CaseStartDate"];
                    newCase.ExEndDate = (DateTime)reader["EstEndDate"];
                    if (reader["UsedHours"] != DBNull.Value)
                    {
                        newCase.UsedHours = (int)reader["UsedHours"];
                    }
                    else newCase.UsedHours = 0;
                    newCase.EstHours = (int)reader["EstHours"];
                    newCase.Done = (bool)reader["Done"];
                    newCase.EmployeeId = (int)reader["EmployeeId"];
                    newCase.ClientId = (int)reader["ClientId"];
                    newCaseList.Add(newCase);

                }
                return newCaseList;
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

        public async Task<bool> UpdateAsync(Case newCase)
        {
            string command = "UPDATE CASE_ SET " +
                "CaseTitle = @CaseTitle, " +
                "CaseStartDate = @CaseStartDate, " +
                "EstEndDate = @EstEndDate, " +
                "EstHours = @EstHours, " +
                "UsedHours = @UsedHours, " +
                "Done = @Done, " +
                "EmployeeId = @EmployeeId, " +
                "ClientId = @ClientId " +
                "WHERE CaseID = @CaseId ";
            int rowsAffected;
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            sqlCommand.Parameters.AddWithValue("@CaseTitle", newCase.CaseTitle);
            sqlCommand.Parameters.AddWithValue("@CaseStartDate", newCase.StartDate);
            sqlCommand.Parameters.AddWithValue("@EstEndDate", newCase.ExEndDate);
            sqlCommand.Parameters.AddWithValue("@EstHours", newCase.EstHours);
            sqlCommand.Parameters.AddWithValue("@UsedHours", newCase.UsedHours);
            sqlCommand.Parameters.AddWithValue("@Done", newCase.Done);
            sqlCommand.Parameters.AddWithValue("@EmployeeId", newCase.EmployeeId);
            sqlCommand.Parameters.AddWithValue("@ClientId", newCase.ClientId);
            sqlCommand.Parameters.AddWithValue("@CaseId", newCase.CaseId);
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

        public async Task<List<Case>> GetCaseWithClientIdAsync(int id)
        {
            string command = "SELECT * FROM CASE_ WHERE ClientId = @ClientId";
            List<Case> caseListClient = new List<Case>();
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            sqlCommand.Parameters.AddWithValue("@ClientId", id);
            try
            {
                await dbConn.OpenAsync();
                SqlDataReader reader = await sqlCommand.ExecuteReaderAsync();
                while (await reader.ReadAsync()) { 
                Case newCaseClient = new Case();
                newCaseClient.CaseId = (int)reader["CaseId"];
                newCaseClient.StartDate = (DateTime)reader["CaseStartDate"];
                newCaseClient.ExEndDate = (DateTime)reader["EstEndDate"];
                newCaseClient.EstHours = (int)reader["EstHours"];
                if (reader["UsedHours"] != DBNull.Value)
                {
                    newCaseClient.UsedHours = (int)reader["UsedHours"];
                }
                newCaseClient.Done = (bool)reader["Done"];
                newCaseClient.EmployeeId = (int)reader["EmployeeId"];
                newCaseClient.ClientId = (int)reader["ClientId"];
                caseListClient.Add(newCaseClient);
                
                }
                return caseListClient;

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
        //    public Task<bool> addServiceToCase(int caseId, int serviceId)
        //    {

        //    }
        //}
    }
}


    


