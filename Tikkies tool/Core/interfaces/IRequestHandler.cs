using core.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace core.interfaces
{
    public interface IRequestHandler
    {
        void pushTransaction(Transaction newTransaction);
        List<Transaction> pullAllTransactions();
        List<Transaction> pullMyTransactions(string name);
        List<Tikkie> GetMyTikkies(string name);
    }
}
