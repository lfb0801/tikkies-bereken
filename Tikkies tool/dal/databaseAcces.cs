using System;
using System.Collections.Generic;
using System.Text;
using core.interfaces.repositories;
using dal.repositories;

namespace dal
{
    public static class databaseAcces
    {
        public static ITransactionRepository transaction = new TransactionRepository();
        public static IPersonRepository person = new PersonRepository();
    }
}
