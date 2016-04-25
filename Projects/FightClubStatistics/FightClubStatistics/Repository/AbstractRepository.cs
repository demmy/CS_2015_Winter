using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using FightClubStatistics;

namespace FightClubStatistics
{
    public abstract class AbstractRepository//<T> : IRepository<T> where T : class
    {
        protected MyContext context;
        public AbstractRepository()
        {
            context = new MyContext();
        }
        public AbstractRepository(MyContext context)
        {
            this.context = context;
        }

        //public void Add(T item)
        //{
        //    context.Set<T>().Add(item);
        //    //db.Set<T>().Add(item);
        //}

        //public void Delete(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public T Get(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<T> GetAll()
        //{
        //    throw new NotImplementedException();
        //}

        public void Save()
        {
            context.SaveChanges();
        }

        //public void Update(T item)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
