#region usings

using System.Collections.Generic;
using System.Threading.Tasks;
using AbstractModel;

#endregion

namespace AbstractRepository
{
    public interface IAsyncRepository<T> where T : PersistableObject
    {
        Task Add(T entity);
        Task Remove(T entity);
        Task Remove(int id);
        Task<ICollection<T>> GetAll();
        Task<T> GetById(int id);
        Task Update(T entity);
    }
}