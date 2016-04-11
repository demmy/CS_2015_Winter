using ISD_13.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_13.Repository.Interfaces
{
    public interface ICombatRepository : IRepository<Combat>
    {
        List<Combat> FindCombatsByUserId(int id);
        void Delete(List<Combat> combatList);
        void DeleteWhithSelectedPlayer(List<Combat> combatList);
    }
}
