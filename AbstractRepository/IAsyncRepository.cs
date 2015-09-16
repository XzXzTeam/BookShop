using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractRepository
{
    public interface IAsyncRepository<T> where T : PersistableObject
    {
        void Add(T entity);
        void Remove(T entity);
        void Remove(int id);
        ICollection<T> GetAll();
        T GetById(int id);
        void Update(T entity);
    }
}
