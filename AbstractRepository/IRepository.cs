#region usings

using System.Collections.Generic;
using AbstractModel;

#endregion

namespace AbstractRepository
{
    public interface IRepository<T> where T : PersistableObject
    {
        void Add(T entity);
        void Remove(T entity);
        void Remove(int id);
        ICollection<T> GetAll();
        T GetById(int id);
        void Update(T entity);
    }
}