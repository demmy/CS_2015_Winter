using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EF_Repository.Data;
using EF_Repository.Repository.Interfaces;

namespace EF_Repository.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected DbSet<T> DbSet;
        protected DbContext DbContext;

        public Repository(DbContext dataContext)
        {
            DbContext = dataContext;
            DbSet = DbContext.Set<T>();
        }
        public Repository()
        {
            DbContext = new EfContext();
            DbSet = DbContext.Set<T>();
        }
        #region IRepository<T> Members
        public void Insert(T entity)
        {
            DbSet.Add(entity);
        }
        public T GetById(int id)
        {
            return DbSet.Find(id);
        }
        public IEnumerable<T> GetAll()
        {
            return DbContext.Set<T>().ToList();
        }
        public System.Collections.Generic.IEnumerable<T> GetByQuery(Expression<Func<T, bool>> query = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "")
        {
            IQueryable<T> queryResult = DbSet;

            if (query != null)
            {
                queryResult = queryResult.Where(query);
            }
            foreach (var property in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                queryResult = queryResult.Include(property);
            }

            if (orderBy != null)
            {
                return orderBy(queryResult).ToList();
            }
            else
            {
                return queryResult.ToList();
            }
        }
        public T GetFirst(Expression<Func<T, bool>> predicate)
        {
            return DbSet.First(predicate);
        }
        public void Update(T entity)
        {
            DbSet.Attach(entity);
            DbContext.Entry(entity).State = EntityState.Modified;
        }
        public void UpdateById(int id)
        {
            T entity = DbSet.Find(id);
            DbSet.Attach(entity);
            DbContext.Entry(entity).State = EntityState.Modified;
        }
        public void Delete(T entity)
        {
            if (DbContext.Entry(entity).State == EntityState.Detached)
                DbSet.Attach(entity);

            DbSet.Remove(entity);
        }
        public void DeleteById(int id)
        {
            T entity = DbSet.Find(id);
            DbSet.Remove(entity);
        }

        #endregion
    }
}
