using System;
using System.Collections.Generic;
using System.Text;

namespace core.models
{
    public class Transaction
    {
        public Person WhoPaid { get; private set; }
        public string Subject { get; private set; }
        public double Amount { get; private set; }
        public List<Person> FreeLoaders { get; private set; }

        public Transaction(Person whoPaid, double amount, List<Person> freeLoaders)
        {
            WhoPaid = whoPaid;
            Amount = amount;
            FreeLoaders = freeLoaders;
        }

    }
}
