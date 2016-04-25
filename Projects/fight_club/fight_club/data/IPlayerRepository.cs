using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fight_club
{
    public interface IPlayerRepository
    {
        bool IsExist(string name);
        void Save();
        void Add(Player player);
        Player Get(string name);
        List<Player> GetAll();
    }
}
