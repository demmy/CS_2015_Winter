using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FightClubReports.Repository.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        void Create(TEntity item);
        void CreateRange(IEnumerable<TEntity> entities);
        void Delete(TEntity item);
        void DeleteById(int id);
        void DeleteRange(IEnumerable<TEntity> entities);
        void Update(TEntity item);
        void Save();
    }
}
