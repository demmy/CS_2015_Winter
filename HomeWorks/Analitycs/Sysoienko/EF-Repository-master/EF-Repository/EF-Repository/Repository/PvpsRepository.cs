using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Repository.Data;
using EF_Repository.Model;
using EF_Repository.Repository.Interfaces;

namespace EF_Repository.Repository
{
    class PvpsRepository: IPvpsRepository,IDisposable
    {
        private readonly EfContext _entity;
        public PvpsRepository(EfContext entity)
        {
            _entity = entity;
        }
        public void Add(Pvp entity)
        {
            _entity.Pvps.Add(entity);
        }
        public void Delete(Pvp entity)
        {
            _entity.Pvps.Remove(entity);
        }
        public Pvp[] GetPvps()
        {
            return _entity.Pvps.ToArray();
        }
        public void SaveChanges()
        {
            _entity.SaveChanges();
        }
        public void Dispose()
        {
            if (_entity != null)
            {
                _entity.Dispose();
            }
        }
    }
}
