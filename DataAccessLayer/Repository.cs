using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    
    
        public class Repository<T> where T : class
        {
            private readonly DbContext _context;
            private readonly DbSet<T> _dbSet;

            public Repository(DbContext context)
            {
                _context = context;
                _dbSet = context.Set<T>();
            }

            public IQueryable<T> GetAll()
            {
                return _dbSet.AsQueryable();
            }

            public T GetById(int id)
            {
                return _dbSet.Find(id);
            }

            public IQueryable<T> Find(Expression<Func<T, bool>> predicate)
            {
                return _dbSet.Where(predicate);
            }

            public void Add(T entity)
            {
                _dbSet.Add(entity);
            }

            public void Update(T entity)
            {
                _context.Entry(entity).State = EntityState.Modified;
            }

            public void Delete(T entity)
            {
                _dbSet.Remove(entity);
            }
        }
    
}
