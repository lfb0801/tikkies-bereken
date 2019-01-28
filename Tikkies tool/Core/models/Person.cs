using System;
using System.Collections.Generic;
using System.Text;

namespace core.models
{
    public class Person
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public double TotalAmountPaid { get; private set; }
        public List<Transaction> TransactionsMade { get; private set; }

        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Person()
        {
        }
    }
}
