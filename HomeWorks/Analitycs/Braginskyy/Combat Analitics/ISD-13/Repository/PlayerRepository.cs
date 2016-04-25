using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISD_13.Repository.Interfaces;
using ISD_13.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace ISD_13.Repository
{
    public class PlayerRepository : Repository<Player>, IPlayerRepository
    {
        public PlayerRepository(Context db)
            : base(db)
        {
        }
       
        public IEnumerable<Player> FindUsersByValidEmail()
        {
            var query = GetAll().Where(p => p.EMailValid == true).ToList();
            return query;
        }

        public Player FindUserByLogin(string login)
        {
            var player = GetAll().Where(p => p.Login == login).FirstOrDefault();
            return player;
        }

        public void Delete(List<Player> playerList)
        {
            var query = GetAll().Except(playerList);
            foreach (var t in query)
            {
                Delete(t.Id);
            }
        }

        public void DeleteWhithFilterByValidEmail(List<Player> playerList)
        {
            foreach (Player p in playerList)
            {
                var query = GetAll().Where(x => x.EMailValid == true).Except(playerList);
                foreach (var d in query)
                {
                    Delete(d.Id);
                }
            }
        }
    }
}
