using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fight_club
{
    [Serializable]
    public class Player : AbstractPlayer , IPlayer
    {
        public Player(int level, string name, int straight, int agility, int stamina , int exp = 0)
        {
            base.level = level;
            base.name = name;
            base.hp = 100 + ((stamina - 1) * 10);
            base.straight = straight;
            base.agility = agility;
            base.stamina = stamina;
            base.exp = exp;
        }
        public override void SetBlock(BodyPart part)
        {
            base.blockedPart = part;
        }       
    }
}
