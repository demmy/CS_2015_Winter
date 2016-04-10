using System;
using System.Linq;
using EF_Repository.Data;
using EF_Repository.Model;
using EF_Repository.Repository.Interfaces;

namespace EF_Repository.Repository
{
    class HitLogsRepository: IHitLogsRepository, IDisposable
    {
        private readonly EfContext _entity;

        public HitLogsRepository(EfContext entity)
        {
            _entity = entity;
        }

        public void Add(HitLog entity)
        {
            _entity.HitLogs.Add(entity);
        }

        public void Delete(HitLog entity)
        {
            _entity.HitLogs.Remove(entity);
        }
        public HitLog[] GetHitLogs()
        {
            return _entity.HitLogs.ToArray();
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
