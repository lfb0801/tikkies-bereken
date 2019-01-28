using core.interfaces.repositories;
using core.models;
using dal.tools;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace dal.contexts
{
    public class PersonContext : IPersonRepository
    {
        public void create(Person entity)
        {
            try
            {
                string query = "INSERT @Name INTO person";
                MySqlParameter[] parameters = { new MySqlParameter("@Name", entity.Name) };

                Executer.ExecuteNonQuery(query,parameters);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void delete(Person entity)
        {
            try
            {
                string query = "DELETE FROM person WHERE ID=@Id";
                MySqlParameter[] parameters = { new MySqlParameter("@Id", entity.Id) };

                Executer.ExecuteNonQuery(query, parameters);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void deleteById(int id)
        {
            try
            {
                string query = "DELETE FROM person WHERE ID=@Id";
                MySqlParameter[] parameters = { new MySqlParameter("@Id", id) };

                Executer.ExecuteNonQuery(query, parameters);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public Person read(int id)
        {
            Person output = new Person();
            try
            {
                string query = "SELECT * FROM person WHERE ID=@Id";
                MySqlParameter[] parameters = { new MySqlParameter("@Id", id) };

                Executer.ExecuteQuery(out output, query, parameters);
            }
            catch (Exception)
            {
                throw;
            }

            return output;
        }

        public List<Person> readAll()
        {
            List<Person> output = new List<Person>();
            try
            {
                string query = "SELECT * FROM person";

                Executer.ExecuteQuery(out output, query);
            }
            catch (Exception)
            {
                throw;
            }

            return output;
        }

        public Person readByName(string name)
        {
            Person output = new Person();
            try
            {
                string query = "SELECT * FROM person WHERE name=@Name";
                MySqlParameter[] parameters = { new MySqlParameter("@Name", name) };

                Executer.ExecuteQuery(out output, query, parameters);
            }
            catch (Exception)
            {
                throw;
            }

            return output;
        }

        public void update(Person entity)
        {
            try
            {
                string query = "UPDATE person SET Name=@Name WHERE ID=@Id";
                MySqlParameter[] parameters = { new MySqlParameter("@Name", entity.Name), new MySqlParameter("@Id", entity.Id) };

                Executer.ExecuteNonQuery(query, parameters);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
