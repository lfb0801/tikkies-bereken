using System;
using System.Collections.Generic;
using System.Text;
using core.interfaces.repositories;
using dal.repositories;

namespace dal
{
    public class databaseAcces
    {
        ITransactionRepository transaction = new TransactionRepository();
        IPersonRepository person = new PersonRepository();
    }
}
