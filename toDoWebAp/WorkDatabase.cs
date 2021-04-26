using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace toDoWebAp
{
    public class WorkDatabase: IWorkDatabase
    {
        private static string _connectionString = @"Server=.\SQLEXPRESS;Database=Informations;Trusted_Connection=True;";

        public static List<ToDoDto> ReadInformation()
        {
            List<ToDoDto> informations = new List<ToDoDto>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText =
                        @"SELECT 
                            [TaskName]
                        FROM [TaskList]";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var information = new ToDoDto
                            {
                                Name = Convert.ToString(reader["TaskName"])
                            };
                            informations.Add(information);
                        }
                    }
                }
            }
            return informations;
        }

        public int InsertInformation( string taskName )
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = @"
                        INSERT INTO TaskList
                            (TaskName)
                        VALUES
                            (@Name)
                        SELECT SCOPE_IDENTITY()";

                    cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = taskName;

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public void DeleteInformation( string taskName )
        {
            List<ToDoDto> informations = new List<ToDoDto>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText =
                        @"DELETE FROM TaskList 
                          WHERE TaskName = @taskName";
                }
            }
        }
    }
}
