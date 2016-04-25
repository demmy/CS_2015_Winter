/*
 * Created by Mad Nomad
 * User: Mad Nomad
 * Date: 11.04.2016
 * Time: 23:59
 */
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using DataLayer.EF;
using DataLayer.Interfaces;

namespace DataLayer.Repositories
{
    /// <summary>
    /// Description of BaseRepository.
    /// </summary>
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected Context db;
        protected DbSet<TEntity> dbSet;
        
        public BaseRepository(Context context)
        {
            this.db = context;
            dbSet = db.Set<TEntity>();
        }

        public TEntity GetById(int id)
        {
            return dbSet.Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return dbSet.ToList();
        }

        public void Create(TEntity item)
        {
            dbSet.Add(item);
        }

        public void Update(TEntity item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(TEntity item)
        {
            dbSet.Remove(item);
        }

    }
}
