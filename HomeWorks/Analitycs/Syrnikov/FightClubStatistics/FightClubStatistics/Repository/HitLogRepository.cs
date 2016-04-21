using FightClubStatistics.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubStatistics
{
    class HitLogRepository : AbstractRepository, IRepository<HitLog> , IHitLogRepository
    {
        public void Add(HitLog item)
        {
            context.HitLogs.Add(item);
        }

        public void Delete(int id)
        {
            HitLog hitLog = context.HitLogs.Find(id);
            if (hitLog != null)
            {
                context.HitLogs.Remove(hitLog);
            }
        }

        public HitLog Get(int id)
        {
            return context.HitLogs.Find(id);
        }

        public IEnumerable<HitLog> GetAll()
        {
            return context.HitLogs;
        }

        public void Update(HitLog item)
        {
            throw new NotImplementedException();
        }
    }
}
