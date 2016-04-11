using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FightClubReports.Repository.Interfaces;
using FightClubReports.Data;
using System.Data.Entity;
using Enums.Entitys;

namespace FightClubReports.Repository
{
    public abstract class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        protected Context db;

        public BaseRepository(Context db)
        {
            this.db = db;
        }
        
        public void Create(TEntity item)
        {
            db.Set<TEntity>().Add(item);
        }

        public void CreateRange(IEnumerable<TEntity> entities)
        {
            db.Set<TEntity>().AddRange(entities);
        }
        
        public void Delete(TEntity item)
        {
            db.Set<TEntity>().Remove(item);
        }

        public void DeleteById(int id)
        {
            TEntity item = db.Set<TEntity>().Find(id);
            if (item != null)
            {
                db.Set<TEntity>().Remove(item);
            }
        }

        public void DeleteRange(IEnumerable<TEntity> entities)
        {
            db.Set<TEntity>().RemoveRange(entities);
        }

        public TEntity Get(int id)
        {
            return db.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return db.Set<TEntity>().ToList();
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(TEntity item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
