using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories.Abstractions
{
    public interface IRepository<T, TPrimaryKey> where T : IEntity<TPrimaryKey>
    {
        public T Get(TPrimaryKey id);
        public IEnumerable<T> GetAll(bool asNoTracking = false);
        public T Add(T entity);
        public void AddRange(List<T> entities);
        public void Update(T entity);
        public bool Delete(TPrimaryKey id);
        public bool DeleteRange(ICollection<T> entities);
        public void SaveChanges();

    }
}
