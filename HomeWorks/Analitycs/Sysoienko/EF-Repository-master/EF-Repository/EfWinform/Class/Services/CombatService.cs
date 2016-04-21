using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfWinform.Class.Services
{
    internal class CombatService : Service
    {
        public override Array Get()
        {
            var combats = (from p in UnitOfWork.CombatsRepo.GetAll()
                           select new { p.CombatId, p.Winner, p.Date }).ToArray();
            return combats;
        }

        public override void DeleteById(int id)
        {
            throw new NotImplementedException();
        }
        public Array Winners()
        {
            var winners = (from p in UnitOfWork.CombatsRepo.GetAll()
                           where p.Winner != null
                           select new { p.CombatId, p.Winner, p.Date }).ToArray();
            return winners;
        }
    }
}
