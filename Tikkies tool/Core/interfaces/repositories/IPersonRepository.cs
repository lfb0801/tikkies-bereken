using core.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace core.interfaces.repositories
{
    public interface IPersonRepository : ICRUD<Person>
    {
        Person readByName(string name);
    }
}
