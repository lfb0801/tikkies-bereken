using core.interfaces.repositories;
using core.models;
using dal.contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace dal.repositories
{
    public class PersonRepository : IPersonRepository
    {
        IPersonRepository ctx = new PersonContext();

        public void create(Person entity)
        {
            ctx.create(entity);
        }

        public void delete(Person entity)
        {
            ctx.delete(entity);
        }

        public void deleteById(int id)
        {
            ctx.deleteById(id);
        }

        public Person read(int id)
        {
            return ctx.read(id);
        }

        public List<Person> readAll()
        {
            return ctx.readAll();
        }

        public Person readByName(string name)
        {
            return ctx.readByName(name);
        }

        public void update(Person entity)
        {
            ctx.update(entity);
        }
    }
}
