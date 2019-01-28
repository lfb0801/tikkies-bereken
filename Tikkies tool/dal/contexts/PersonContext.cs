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
            throw new NotImplementedException();
        }

        public void delete(Person entity)
        {
            throw new NotImplementedException();
        }

        public void deleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Person read(int id)
        {
            Person output = new Person();
            try
            {
                string query = "";
                MySqlParameter[] parameters = { new MySqlParameter("@Id", id) };

                Executer.ExecuteQuery(out output, query, parameters);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Person> readAll()
        {
            throw new NotImplementedException();
        }

        public Person readByName(string name)
        {
            throw new NotImplementedException();
        }

        public void update(Person entity)
        {
            throw new NotImplementedException();
        }
    }
}
