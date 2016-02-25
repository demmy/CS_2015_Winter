using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fight_club
{
    public struct FightPapams
    {
        public int straight;
        public int agility;
        //public int stamina;

        public FightPapams(int straight , int agility)
        {
            this.straight = straight;
            this.agility = agility;
            //this.stamina = stamina;
        }
    }
}
