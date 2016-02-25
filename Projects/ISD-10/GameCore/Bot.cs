using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCore
{    
    public class Bot : Player, IBot
    {
        Random rnd = new Random();
        public Bot()
        {
            this.name = "Bot";
            this.hp = 100;
            this.armor = rnd.Next(11);
            this.strength = 10 - this.armor;
        }
        public Position RandomBlock
        {
            get { return (Position)rnd.Next(1, 4); }
        }
        public Position RandomHit
        {
            get { return (Position)rnd.Next(1, 4); }
        }
    }
}
