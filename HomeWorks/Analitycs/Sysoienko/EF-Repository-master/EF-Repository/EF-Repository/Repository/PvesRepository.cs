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
    class PvesRepository: IPvesRepository, IDisposable
    {
        private readonly EfContext _entity;
        public PvesRepository(EfContext entity)
        {
            _entity = entity;
        }
        public void Add(Pve entity)
        {
            _entity.Pves.Add(entity);
        }
        public void Delete(Pve entity)
        {
            _entity.Pves.Remove(entity);
        }
        public Pve[] GetPves()
        {
            return _entity.Pves.ToArray();
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
