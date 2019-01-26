using core.models;
using dal;
using System;
using System.Collections.Generic;
using System.Text;

namespace logic
{
    public class TikkieFactory
    {
        TransactionDatabase transactionDatabase = new TransactionDatabase();
        List<Transaction> Transactions;
        public Tikkie getTikkies() {

            return new Tikkie();
        }
    }
}
