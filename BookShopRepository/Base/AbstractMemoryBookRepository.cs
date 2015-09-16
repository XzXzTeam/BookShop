#region usings

using System.Collections.Generic;
using System.Linq;
using AbstractModel;
using AbstractRepository;

#endregion

namespace BookShopMemoryRepository.Base
{
    public abstract class AbstractBookMemoryRepository<T> : IRepository<T> where T : PersistableObject
    {
        protected ICollection<T> _entities;

        protected AbstractBookMemoryRepository()
        {
            _entities = new List<T>();
        }

        public void Add(T entity)
        {
            _entities.Add(entity);
        }

        public void Remove(T entity)
        {
            _entities.Remove(entity);
        }

        public void Remove(int id)
        {
            var entity = _entities.First(e => e.Id == id);
            if (entity != null)
            {
                _entities.Remove(entity);
            }
        }

        public ICollection<T> GetAll()
        {
            return _entities;
        }

        public T GetById(int id)
        {
            return _entities.First(e => e.Id == id);
        }

        public void Update(T entity)
        {
            Remove(entity.Id);
            Add(entity);
        }
    }
}