using System;
using FightClubApp.Inerfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubApp.FightersClasses
{
    

    class Bot : Fighter, IBot
    {
        Random rand = new Random();
        public Bot()
        {
            this.name = "Бот";
        }

        public PartOfBody BotBlock
        {
            get { return (PartOfBody)rand.Next(1, 4); }
        }
        public PartOfBody BotHit
        {
            get { return (PartOfBody)rand.Next(1, 4); }
        }
    }
}
