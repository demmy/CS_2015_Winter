using FightClubStatistics.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubStatistics
{
    class CombatLogRepository : AbstractRepository, IRepository<CombatLog> , ICombatLogRepository
    {
        public void Add(CombatLog item)
        {
            context.CombatLogs.Add(item);
        }

        public void Delete(int id)
        {
            CombatLog combatLog = context.CombatLogs.Find(id);
            if (combatLog != null)
            {
                context.CombatLogs.Remove(combatLog);
            }
        }

        public CombatLog Get(int id)
        {
            return context.CombatLogs.Find(id);
        }

        public IEnumerable<CombatLog> GetAll()
        {
            return context.CombatLogs;
        }

        public void Update(CombatLog item)
        {
            throw new NotImplementedException();
        }
    }
}
