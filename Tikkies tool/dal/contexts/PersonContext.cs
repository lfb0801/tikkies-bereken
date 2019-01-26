using core.interfaces.repositories;
using core.models;
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
            throw new NotImplementedException();
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
