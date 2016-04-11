using ISD_13.Data;
using ISD_13.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_13.Repository
{
    public class CombatRepository : Repository<Combat>, ICombatRepository
    {
        public CombatRepository(Context db)
            : base(db)
        {
        }
        public List<Combat> FindCombatsByUserId(int id)
        {
            var query = db.Combats.Where(c => (c.FirstPlayer.Id == id) || (c.SecondPlayer.Id == id)).ToList();
            return query;
        }

        public void Delete(List<Combat> combatList)
        {
            var query = GetAll().Except(combatList);
            foreach (var c in query)
            {
                Delete(c.Id);
            }
        }
        public void DeleteWhithSelectedPlayer(List<Combat> combatList)
        {
            foreach (Combat c in combatList)
            {
                var query = GetAll()
                    .Where(x => (x.FirstPlayer == c.FirstPlayer) || (x.SecondPlayer == c.SecondPlayer))
                    .Except(combatList);
                foreach (var d in query)
                {
                    Delete(d.Id);
                }
            }
        }
    }
}
