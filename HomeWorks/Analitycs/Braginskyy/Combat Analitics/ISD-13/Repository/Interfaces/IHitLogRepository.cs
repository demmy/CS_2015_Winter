using ISD_13.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_13.Repository.Interfaces
{
    public interface IHitLogRepository : IRepository<HitLog>
    {
        List<HitLog> FindHitLogsByCombatId(string id);
        void Delete(List<HitLog> hitLogList);
        void DeleteWhithSelectedCombat(List<HitLog> hitLogList);
    }   
}
