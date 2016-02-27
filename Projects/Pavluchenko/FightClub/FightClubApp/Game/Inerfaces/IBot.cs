using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubApp.Inerfaces
{
    public interface IBot : IPlayer
    {
        PartOfBody BotBlock { get; }
        PartOfBody BotHit { get; }
    }
}
