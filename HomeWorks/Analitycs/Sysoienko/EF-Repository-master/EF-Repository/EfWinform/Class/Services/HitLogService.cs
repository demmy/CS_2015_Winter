using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfWinform.Class.Services
{
    class HitLogService : Service
    {
        public override Array Get()
        {
            var hitlogs = (from p in UnitOfWork.HitLogsRepo.GetAll()
                           select new { p.CombatId, p.PlayerLogin, p.EnemyLogin, p.PlayerHitValue, p.EnemyHitValue }).ToArray();
            return hitlogs;
        }
        public override void DeleteById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
