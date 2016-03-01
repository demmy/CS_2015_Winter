using System;
using FightClubApp.Inerfaces;
using FightClubApp.UI.Login;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FightClubApp.FightersClasses;
using System.Threading.Tasks;

namespace FightClubApp.FightersClasses
{

    public class Player: Fighter, IPlayer
    {
        public  Player()
        {
            this.name = ""; 
        }
    }
}
