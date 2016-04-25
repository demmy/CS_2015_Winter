using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfWinform.Class.Services
{
    internal class PveService : Service
    {

        public override Array Get()
        {
            var pves = (from p in UnitOfWork.PvesRepo.GetAll()
                        select p).ToArray();
            return pves;
        }

        public override void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Array Pves()
        {
            var pves = (from c in UnitOfWork.CombatsRepo.GetAll()
                join p in UnitOfWork.PvesRepo.GetAll()
                    on c.CombatId equals p.CombatId
                join n in UnitOfWork.PlayersRepo.GetAll()
                    on c.CombatId equals n.CombatId
                        select new { n.PlayerId, n.Login }).ToArray();
            return pves;
        }
    }
}
