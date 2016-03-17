using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace fight_club
{
    public interface IPlayersContainer : IContainer
    {
        List<Player> GetAll();
    }
}
