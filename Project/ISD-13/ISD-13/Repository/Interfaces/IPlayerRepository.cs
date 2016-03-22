using ISD_13.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_13.Repository.Interfaces
{
    interface IPlayerRepository : IRepository<Player>
    {
        IEnumerable<Player> FindRegisteredUsersByDate(DateTime date);
        IEnumerable<Player> FindUsersByValidEmail();
    }
}
