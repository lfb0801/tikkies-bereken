using core.interfaces;
using core.models;
using dal;
using System;
using System.Collections.Generic;
using System.Text;

namespace logic
{
    public class RequestHandler : IRequestHandler
    {
        public List<Tikkie> GetMyTikkies(string name)
        {
            throw new NotImplementedException();
        }

        public List<Transaction> pullAllTransactions()
        {
            return databaseAcces.transaction.readAll();
        }

        public List<Transaction> pullMyTransactions(string name)
        {
            return (List<Transaction>)databaseAcces.transaction.readByPerson(databaseAcces.person.readByName(name));
        }

        public void pushTransaction(Transaction newTransaction)
        {
            databaseAcces.transaction.create(newTransaction);
        }
    }
}
