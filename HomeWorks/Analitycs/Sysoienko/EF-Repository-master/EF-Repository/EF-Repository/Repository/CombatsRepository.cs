using System;
using System.Linq;
using EF_Repository.Data;
using EF_Repository.Model;
using EF_Repository.Repository.Interfaces;

namespace EF_Repository.Repository
{
    class CombatsRepository:ICombatsRepository, IDisposable
    {
        private readonly EfContext _entity;

        public CombatsRepository(EfContext entity)
        {
            _entity = entity;
        }

        public void Add(Combat entity)
        {
            _entity.Combats.Add(entity);
        }

        public void Delete(Combat entity)
        {
            _entity.Combats.Remove(entity);
        }
        public Combat[] GetCombats()
        {
            return _entity.Combats.ToArray();
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
