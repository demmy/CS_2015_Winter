using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fight_club
{
    [Serializable]
    public abstract class AbstractPlayer : IPlayer
    {
        protected int level;          
        protected int hp;             
        protected string name;        
        protected int straight;       
        protected int agility;        
        protected int stamina;        
        protected int exp;            
        public BodyPart blockedPart;

        public delegate void MyEvent(object sender, BodyPart e);

        public event MyEvent Block;
        public event MyEvent Wound;

        public int Level
        {
            get
            {
                return level;
            }
        }
        public int Hp
        {
            get
            {
                return hp;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public int Straight
        {
            get
            {
                return straight;
            }
        }
        public int Agility
        {
            get
            {
                return agility;
            }
        }
        public int Stamina
        {
            get
            {
                return stamina;
            }
        }
        public int MaxHp
        {
            get
            {
                return (100 + ((stamina - 1) * 10));
            }
        }
        public int Exp
        {
            get
            {
                return exp;
            }
        }

        public AbstractPlayer()
        {
            level = 1;
            name = "Bot";
            straight = 3;
            agility = 2;
            stamina = 1;
            hp = 100 + ((stamina - 1) * 10);
            exp = 0;
        }

        public abstract void SetBlock(BodyPart part);
        public int GetHit(BodyPart part , FightPapams par)
        {
            int damage;
            if (part != blockedPart)
            {
                hp -= par.straight * 5;
                damage = par.straight * 5;
                Wound.Invoke(this , part);
            }
            else
            {
                if (Dice.Throw() + (par.agility - agility) > 14)
                {
                    hp -= par.straight * 5;
                    damage = par.straight * 5;
                    Wound.Invoke(this , part);
                }
                else
                {
                    damage = 0;
                    Block.Invoke(this , blockedPart);
                }
            }
            return damage;
        }

        public void AddExp(int exp)
        {
            this.exp += exp;
        }
        
    }
}
