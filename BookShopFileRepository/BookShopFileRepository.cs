using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractModel;
using AbstractRepository;

namespace BookShopFileRepository
{
    public class BookShopFileRepository<T> : IRepository<T> where T : PersistableObject
    {
        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
