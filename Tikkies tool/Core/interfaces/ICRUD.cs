using System;
using System.Collections.Generic;
using System.Text;

namespace core.interfaces
{
    public interface ICRUD <T>
    {
        //  create
        void create(T entity);

        //  read
        T read(int id);
        List<T> readAll();

        //  update
        void update(T entity);

        //  delete
        void delete(T entity);
        void deleteById(int id);
    }
}
