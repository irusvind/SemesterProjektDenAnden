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
        public async Task<bool> Create(Case newCase)
        {
            {
                string command = "INSERT INTO CASE_ VALUES(@CaseTitle, @CaseStartDate, @EstEndDate, @EstHours, @Done, @ServiceId, @EmployeeId, ClientId)";
                int rowsAffected;
                using SqlConnection dbConn = new SqlConnection(connString);
                SqlCommand sqlCommand = new SqlCommand(command, dbConn);
                sqlCommand.Parameters.AddWithValue("@CaseTitle", newCase.CaseTitle);
                sqlCommand.Parameters.AddWithValue("@CaseStartDate", newCase.StartDate);
                sqlCommand.Parameters.AddWithValue("@EstEndDate", newCase.ExEndDate);
                sqlCommand.Parameters.AddWithValue("@EstHours", newCase.ExHours);
                sqlCommand.Parameters.AddWithValue("@Done", newCase.IsClosed);
                sqlCommand.Parameters.AddWithValue("@ServiceId", newCase.ServiceId);
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

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Case> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Case>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Case newCase)
        {
            throw new NotImplementedException();
        }
    }
}
