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
        #region Fields
        protected int level;  // mb remoove exp to class Player?
        protected int hp;
        protected string name;
        protected int straight;
        protected int agility;
        protected int stamina;
        protected int exp;  // mb remoove exp to class Player?
        public BodyPart blockedPart;
        #endregion        

        #region Properties
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
        #endregion

        #region Events
        public delegate void MyEvent(object sender, BodyPart e);
        public event MyEvent Block;
        public event MyEvent Wound;
        #endregion

        #region Constructors
        public AbstractPlayer()
        {
            level = 1;
            name = "Bot";
            straight = 3;
            agility = 2;
            stamina = 3;
            hp = CalculateHp();
            exp = 0;
        } 
        #endregion

        #region Methods
        public abstract void SetBlock(BodyPart part);
        public int GetHit(BodyPart part, FightPapams par)
        {
            int damage;
            if (part != blockedPart)
            {
                damage = CalculateDamage(par.straight);
                hp -= damage;
                Wound.Invoke(this, part);
            }
            else
            {
                if (Dice.Throw() + (par.agility - agility) > 14)   // chanse of succesfull block is 70% - agility difference
                {
                    damage = CalculateDamage(par.straight);
                    hp -= damage;
                    Wound.Invoke(this, part);
                }
                else
                {
                    damage = 0;
                    Block.Invoke(this, blockedPart);
                }
            }
            return damage;
        }

        public void AddExp(int exp)
        {
            this.exp += exp;
        }

        protected int CalculateHp()
        {
            return 100 + ((stamina - 1) * 10);
        }

        private int CalculateDamage(int str)
        {
            return str * 5;
        } 
        #endregion
    }
}
