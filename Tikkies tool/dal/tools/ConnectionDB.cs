using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal
{
    public static class ConnectionDB
    {
        private static string database = "";
        private static string password = "";
        private static string server = "";
        private static string uid = "";

        public static MySqlConnection GetConnection() {
            return new MySqlConnection(createConnectionString());
        }

        private static string createConnectionString() {
            return $"SERVER={server}; DATABASE={database}; UID={uid}; PASSWORD={password}; SslMode=none";
        }
    }
}
