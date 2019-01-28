using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace dal.tools
{
    public static class Factory
    {
        public static T readerToObject<T>(out T output, MySqlDataReader reader) {
            output = Activator.CreateInstance<T>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    T t = Activator.CreateInstance<T>();

                    foreach (PropertyInfo prop in t.GetType().GetProperties())
                    {
                        if (!object.Equals(reader[prop.Name], DBNull.Value))
                        {
                            prop.SetValue(t, reader[prop.Name], null);
                        }
                    }
                    output = t;
                };
            }

            return output;
        }

        public static IEnumerable<T> readerToList<T>(out IEnumerable<T> output, MySqlDataReader reader) {
            output = new List<T>();

            //  if the query finds a result
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    T t = Activator.CreateInstance<T>();

                    foreach (PropertyInfo prop in t.GetType().GetProperties())
                    {
                        if (!object.Equals(reader[prop.Name], DBNull.Value))
                        {
                            prop.SetValue(t, reader[prop.Name], null);
                        }
                    }

                    (output as List<T>).Add(t);
                };
            }
        }
    }
}
