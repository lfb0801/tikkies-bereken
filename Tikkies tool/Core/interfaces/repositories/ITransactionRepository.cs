using core.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace core.interfaces.repositories
{
    public interface ITransactionRepository : ICRUD<Transaction>
    {
        Transaction readByPerson(Person person);
    }
}
