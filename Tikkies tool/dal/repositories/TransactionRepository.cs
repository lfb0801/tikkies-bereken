using core.interfaces.repositories;
using core.models;
using dal.contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace dal.repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        ITransactionRepository ctx = new TransactionContext();

        public void create(Transaction entity)
        {
            ctx.create(entity);
        }

        public void delete(Transaction entity)
        {
            ctx.delete(entity);
        }

        public void deleteById(int id)
        {
            ctx.deleteById(id);
        }

        public Transaction read(int id)
        {
            return ctx.read(id);
        }

        public List<Transaction> readAll()
        {
            return ctx.readAll();
        }

        public Transaction readByPerson(Person person)
        {
            return ctx.readByPerson(person);
        }

        public void update(Transaction entity)
        {
            ctx.update(entity);
        }
    }
}
