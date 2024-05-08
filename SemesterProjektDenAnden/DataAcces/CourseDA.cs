using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DataAcces.DAInterfaces;
using Models;

namespace DataAcces
{
    public class CourseDA : ICourse
    {
        string connString;
        public CourseDA()
        {
            connString = ConfigurationManager
                        .ConnectionStrings["dbConn"]
                        .ToString();
        }
        public async Task<bool> CreateAsync(Course newCourse)
        {
            string command = "INSERT INTO COURSE VALUES(@CourseName)";
            int rowsAffected;
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            sqlCommand.Parameters.AddWithValue("@CourseName", newCourse.CourseName);
            try
            {
                await dbConn.OpenAsync();
                rowsAffected = await sqlCommand.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
            if (rowsAffected > 0)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            string command = "DELETE FROM COURSE WHERE CourseId = @CourseId";
            int rowsAffected;
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            sqlCommand.Parameters.AddWithValue("@CourseId", id);
            try
            {
                await dbConn.OpenAsync();
                rowsAffected = await sqlCommand.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                await dbConn.CloseAsync();
            }
            if(rowsAffected > 0)
            { 
                return true; 
            }
            return false;
        }

        public async Task<List<Course>> GetAllAsync()
        {
            string command = "SELECT * FROM COURSE";
            List<Course> courses = new List<Course>();
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            try
            {
                await dbConn.OpenAsync();
                SqlDataReader reader = await sqlCommand.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    Course newCourse = new Course();
                    newCourse.CourseId = (int)reader["CourseId"];
                    newCourse.CourseName = (string)reader["CourseName"];
                    courses.Add(newCourse);
                }
                return courses;
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

        public async Task<Course> GetAsync(int id)
        {
            string command = "SELECT * FROM COURSE WHERE CourseId = @CourseId";
            Course newCourse = new Course();
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(command,dbConn);
            sqlCommand.Parameters.AddWithValue("CourseId", id);
            try
            {
                await dbConn.OpenAsync();
                SqlDataReader reader = await sqlCommand.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    newCourse.CourseId = (int)reader["CourseId"];
                    newCourse.CourseName = (string)reader["CourseName"];

                    return newCourse;
                }
                return new Course();
            }
            catch
            {
                throw;
            }
            finally
            {
                await dbConn.CloseAsync();
            }
        }

        public async Task<bool> UpdateAsync(Course newCourse)
        {
            string command = "UPDATE CLIENT SET" +
                             "CourseName = @CourseName" +
                             "WEHERE CourseId = @CourseId";
            int rowsAffected;
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            sqlCommand.Parameters.AddWithValue("@CourseName", newCourse.CourseName);
            try
            {
                await dbConn.OpenAsync();
                rowsAffected = await sqlCommand.ExecuteNonQueryAsync();
            }
            catch
            {
                throw;
            }
            finally { await dbConn.CloseAsync();}
            if (rowsAffected > 0)
            {
                return true;
            }
            return false;
        }
    }
}
