using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractModel;
using AbstractRepository;

namespace WebApplication.Repository
{
    public class EFAbstractRepository<T> : IRepository<T> where T : PersistableObject
    {
        public void Add(T entity)
        {
            using (var ctx = new AppDbContext())
            {
                ctx.Set<T>().Add(entity);
                ctx.SaveChanges();
            }
        }

        public ICollection<T> GetAll()
        {
            using (var ctx = new AppDbContext())
            {
                return ctx.Set<T>().ToList();
            }
        }

        public T GetById(int id)
        {
            using (var ctx = new AppDbContext())
            {
                return ctx.Set<T>().Find(id);
            }
        }

        public void Remove(int id)
        {
            using (var ctx = new AppDbContext())
            {
                var entity = ctx.Set<T>().Find(id);
                ctx.Set<T>().Remove(entity);
                ctx.SaveChanges();
            }
        }

        public void Remove(T entity)
        {
            using (var ctx = new AppDbContext())
            {
                ctx.Set<T>().Remove(entity);
                ctx.SaveChanges();
            }
        }

        public void Update(T entity)
        {
            using (var ctx = new AppDbContext())
            {
                ctx.Set<T>().Attach(entity);
                ctx.Entry(entity).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }
    }
}
