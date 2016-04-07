using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISD_13.Repository.Interfaces;
using ISD_13.Data;
using System.Data.Entity;

namespace ISD_13.Repository
{
    public class PlayerRepository : IPlayerRepository
    {
        private Context db;
        public PlayerRepository()
        {
            this.db = new Context();
        }

        public IEnumerable<Player> FindRegisteredUsersByDate(DateTime date)
        {            
            var query = GetList().Where(p => p.Date < date).ToList();
            return query;
        }

        public IEnumerable<Player> FindUsersByValidEmail()
        {
            var query = GetList().Where(p => p.EMail != null).ToList();
            return query;
        }

        public IEnumerable<Player> GetList()
        {
            return db.Player;
        }

        public Player Get(int id)
        {
            return db.Player.Find(id);
        }

        public void Create(Player player)
        {
            db.Player.Add(player);
        }

        public void Update(Player player)
        {
            db.Entry(player).State = EntityState.Modified;
        }

        public void Delate(int id)
        {
            Player player = db.Player.Find(id);
            if (player != null)
            {
                db.Player.Remove(player);
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
