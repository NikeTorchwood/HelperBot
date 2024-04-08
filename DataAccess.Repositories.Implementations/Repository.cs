using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories.Implementations
{
    public abstract class Repository<T, TPrimaryKey> where T: class, IEntity<TPrimaryKey>
    {
        protected readonly DbContext Context;
        private readonly DbSet<T> _entitySet;

        protected Repository(DbContext context)
        {
            Context = context;
            _entitySet = Context.Set<T>();
        }

        public virtual T Get(TPrimaryKey id)
        {
            return _entitySet.Find(id);
        }
        public virtual IEnumerable<T> GetAll(bool asNoTracking = false)
        {
            return asNoTracking ? _entitySet.AsNoTracking() : _entitySet;
        }
        public virtual T Add(T entity)
        {
            var objToReturn = _entitySet.Add(entity);
            return objToReturn.Entity;
        }
        public virtual void AddRange(List<T> entities)
        {
            var enumerable = entities as IList<T>;
            _entitySet.AddRange(enumerable);
        }
        public virtual void Update(T entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
        }
        public virtual bool Delete(TPrimaryKey id)
        {
            var obj = _entitySet.Find(id);
            if (obj == null)
            {
                return false;
            }
            _entitySet.Remove(obj);
            return true;
        }
        public virtual bool DeleteRange(ICollection<T> entities)
        {
            if (entities == null || entities.Count == 0)
            {
                return false;
            }
            _entitySet.RemoveRange(entities);
            return true;
        }
        public virtual void SaveChanges()
        {
            Context.SaveChanges();
        }
    }
}
