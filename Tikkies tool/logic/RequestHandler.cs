using core.interfaces;
using core.models;
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
            throw new NotImplementedException();
        }

        public List<Transaction> pullMyTransactions(string name)
        {
            throw new NotImplementedException();
        }

        public void pushTransaction(Transaction newTransaction)
        {
            throw new NotImplementedException();
        }
    }
}
