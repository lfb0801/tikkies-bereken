using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace dal.tools
{
    public static class Executer
    {
        public static void ExecuteQuery<T>(out T output, string query, MySqlParameter[] parameters = null) where T : new()
        {
            using (MySqlConnection connection = ConnectionDB.GetConnection())
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        foreach (MySqlParameter parameter in parameters)
                            command.Parameters.Add(parameter);
                    }
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        Factory.readerToObject(out output, reader);
                    }
                }
                connection.Close();
            }
        }

        public static void ExecuteQuery<T>(out IEnumerable<T> output, MySqlConnection connection, string query, MySqlParameter[] parameters = null) where T : new()
        {
            try
            {
                using (MySqlConnection conn = ConnectionDB.GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            foreach (MySqlParameter parameter in parameters)
                            {
                                command.Parameters.Add(parameter);
                            }
                        }
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            Factory.readerToList(out output, reader);
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception)
            {

                throw new Exception("Invalid Query");
            }
        }

        public static void ExecuteNonQuery(string query, MySqlParameter[] parameters = null)
        {
            using (MySqlConnection connection = ConnectionDB.GetConnection())
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        foreach (MySqlParameter parameter in parameters)
                        {
                            command.Parameters.Add(parameter);
                        }
                    }

                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
