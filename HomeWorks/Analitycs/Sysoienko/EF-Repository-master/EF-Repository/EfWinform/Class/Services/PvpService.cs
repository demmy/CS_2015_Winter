using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfWinform.Class.Services
{
    class PvpService : Service
    {
        public override Array Get()
        {
            var pvps = (from p in UnitOfWork.PvpsRepo.GetAll()
                        select p).ToArray();
            return pvps;
        }
        public override void DeleteById(int id)
        {
            throw new NotImplementedException();
        }
        public Array Pvps()
        {
            var pvps = (from c in UnitOfWork.CombatsRepo.GetAll()
                        join p in UnitOfWork.PvpsRepo.GetAll()
                                on c.CombatId equals p.CombatId
                        join n in UnitOfWork.PlayersRepo.GetAll()
                        on c.CombatId equals n.CombatId
                        select new { n.PlayerId, n.Login }).ToArray();
            return pvps;
        }
    }
}
