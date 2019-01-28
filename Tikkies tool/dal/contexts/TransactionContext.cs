using core.interfaces.repositories;
using core.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace dal.contexts
{
    public class TransactionContext : ITransactionRepository
    {
        public void create(Transaction entity)
        {
            throw new NotImplementedException();
        }

        public void delete(Transaction entity)
        {
            throw new NotImplementedException();
        }

        public void deleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Transaction read(int id)
        {
            throw new NotImplementedException();
        }

        public List<Transaction> readAll()
        {
            throw new NotImplementedException();
        }

        public List<Transaction> readByPerson(Person person)
        {
            throw new NotImplementedException();
        }

        public void update(Transaction entity)
        {
            throw new NotImplementedException();
        }
    }
}
