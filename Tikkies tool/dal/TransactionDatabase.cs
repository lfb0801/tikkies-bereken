using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using core.models;

namespace dal
{
    class TransactionDatabase
    {
        Database db = Database.GetInstance();
        public void AddTransaction(Transaction transaction)
        {

        }

        public List<Transaction> GetTransactionsFromPerson(Person person)
        {

            var result = db.Query($"SELECT * FROM transaction WHERE WhoPaid = {person.Name}");
            return null;
        }

        public List<Transaction> GetAllTransactions()
        {
            var result = db.Query("SELECT * FROM transaction");
            var transactions = new List<Transaction>();
            foreach (DataRow row in result.Rows)
            {
                var trans = new Transaction(new Person(row[0].ToString()), (double)row[1], null);
                transactions.Add(trans);
            }

            return transactions;
        }
    }
}
