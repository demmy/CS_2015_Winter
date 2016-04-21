using ISD_13.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_13.Repository.Interfaces
{
    public interface IPlayerRepository : IRepository<Player>
    {        
        IEnumerable<Player> FindUsersByValidEmail();
        Player FindUserByLogin(string login);
        void Delete(List<Player> playerList);
        void DeleteWhithFilterByValidEmail(List<Player> playerList);
    }
}
