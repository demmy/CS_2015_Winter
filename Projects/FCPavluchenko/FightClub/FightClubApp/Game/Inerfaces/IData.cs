using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubApp.Game.Inerfaces
{
    public interface IData
    {
        string Name { get; set; }
        int NumberOfFight { get; set; }
        int NumberOfWin { get; set; }
        int NumberOfTie { get; set; }
        int NumberOfLoss { get; set; } 
    }
}
