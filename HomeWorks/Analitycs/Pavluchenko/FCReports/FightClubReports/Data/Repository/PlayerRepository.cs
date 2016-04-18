using FightClubReports.Data;
using FightClubReports.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubReports.Repository
{
    public class PlayerRepository :BaseRepository<Player>, IPlayerRepository
    {
        public PlayerRepository( Context db) : base(db)
        {
           
        }

        public IEnumerable<Player> GetPlayersByAlphabet()
        {
            return db.Players
                .OrderBy(l => l.Login)
                .ToList();
        }

        public IEnumerable<Player> GetPlayerByLogin(string login)
        {
            return db.Players
                .Where(l => l.Login == login);
        }

        public Player GetPlayerById(int id)
        {
            return db.Players.FirstOrDefault(i => i.Id == id);
        }

        public IEnumerable<Player> GetPlayersByNumberOfGame()
        {
            return db.Players
                .OrderByDescending(s => s.Statistics.Combats)
                .ToList();
        }

        public IEnumerable<Player> GetPlayersByRegist()
        {
            return db.Players
               .OrderBy(t => t.RegistrationDate)
               .ToList();
        }

        public IEnumerable<Player> GetTopPlayers()
        {
            return db.Players
                .OrderByDescending(w => w.Statistics.Wins)
                .ThenByDescending(d => d.Statistics.Draws)
                .ToList();
        }

        public IEnumerable<Player> GetValidEmailPlayers()
        {
            return db.Players
               .Where(e => e.IsEmaillValid == true)
               .ToList();
        }
    }
}
