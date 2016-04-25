using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EF_Repository.Repository.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Insert(T entity);
        T GetById(int id);
        IEnumerable<T> GetByQuery(Expression<Func<T, bool>> query = null,
                                  Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                  string includeProperties = "");
        T GetFirst(Expression<Func<T, bool>> predicate);
        IEnumerable<T> GetAll();
        void Update(T entity);
        void UpdateById(int id);
        void Delete(T entity);
        void DeleteById(int id);
    }
}
