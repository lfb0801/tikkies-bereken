using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;

namespace dal
{
    class Database
    {
        private static Database instance = new Database("studmysql01.fhict.local","dbi379275","dbi379275", "OuluTrekkers");
        private static MySqlConnection conn;

        public Database(string server, string db, string user, string pass)
        {
            conn = new MySqlConnection($"Server={server};Database={db};Uid={user};Pwd={pass};");
        }

        public static Database GetInstance()
        {
            return instance;
        }


        public DataTable Query(string query)
        {
            Connect();
            var dt = new DataTable();
            var cmd = new MySqlCommand(query, conn);
            var reader = cmd.ExecuteReader();
            dt.Load(reader);
            Disconnect();
            return dt;
        }

        public void NonQuery(string query)
        {
            Connect();
            var cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            Disconnect();
        }

        private void Connect()
        {
            conn.Open();
        }

        private void Disconnect()
        {
            conn.Close();
        }
    }

}
