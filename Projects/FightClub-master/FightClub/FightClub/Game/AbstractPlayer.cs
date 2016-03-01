using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
    abstract class AbstractPlayer : IPlayer
    {
        #region Fields
        const int bonusHp = 25;
        Random rand = new Random();     
        protected int hp = 100;
        protected int damage = 5;
        protected int block = 0;
        #endregion

        #region Properties
        public string Name { get; set; }
        public int Damage
        {
            get
            {
                return damage;
            }
            set
            {
                damage = value;
            }
        }
         public int HP
        {
            get { return hp; }
            set
            {
                hp = value;
            }
        }
        public int Hit { get; set; }
        public int Set { get { return (int)block; } }
        public string log { get; set; }
        public int Win { get; set; }
        #endregion

        #region Methods
        public int SetBlock(Parts part) 
        {
            block = (int)part;
            return block;
        }
        public int BonusHp()
        {
            hp = hp + bonusHp;
            return hp;
        }
        public  void ImproveDmg()
        {
            damage = rand.Next(5,13);
        }
        public int Recovery(bool h)
        {
            if (h) 
            {
                hp = 100;
                return hp;
            }

            hp = 125;
            return hp;
        }
        public int GetHit(Parts part)
        {
            if ((int)part != block)
            {
                if (hp - damage > 0)
                {
                    hp -= damage;
                    if (Wound != null)
                        Wound(this, new GameEventArgs("wounded"));
                }
                else
                {
                    hp = 0;
                    if (Death != null)
                        Death(this, new GameEventArgs("Died"));
                }
            }
            if (block == (int)part)
            {
                if (Block != null)
                    Block(this, new GameEventArgs("Blocked"));
            }
            return hp;
        }
        #endregion

        #region events
        public event GameForceHandler Wound;
        public event GameForceHandler Block;
        public event GameForceHandler Death;
        #endregion
    }
}
