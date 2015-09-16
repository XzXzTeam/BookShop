#region usings

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractModel;
using AbstractRepository;

#endregion

namespace BookShopMemoryRepository.Base
{
    public abstract class AbstractBookMemoryAsyncRepository<T> : IAsyncRepository<T> where T : PersistableObject
    {
        protected ICollection<T> _entities;

        protected AbstractBookMemoryAsyncRepository()
        {
            _entities = new List<T>();
        }

        public async Task Add(T entity)
        {
            await Task.Run(() => { _entities.Add(entity); });
        }

        public async Task Remove(T entity)
        {
            await Task.Run(() => { _entities.Remove(entity); });
        }

        public async Task Remove(int id)
        {
            await Task.Run(() =>
            {
                var entity = _entities.First(e => e.Id == id);
                if (entity != null)
                {
                    _entities.Remove(entity);
                }
            });
        }

        public async Task<ICollection<T>> GetAll()
        {
            return await Task.Run(() => _entities);
        }

        public async Task<T> GetById(int id)
        {
            return await Task.Run(() =>
            {
                return _entities.First(e => e.Id == id);
            });
        }

        public async Task Update(T entity)
        {
            await Task.Run(() =>
            {
                Remove(entity.Id).RunSynchronously();
                Add(entity).RunSynchronously();
            });
        }
    }
}