using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubApp.FightersClasses
{
    abstract public class Fighter
    {
        protected string name = "";
        protected int hp = (int)Constant.StartHP;
        protected PartOfBody block = PartOfBody.Unknown;
        protected PartOfBody hit = PartOfBody.Unknown;
        //protected int numberOfHits = 0;
        //на fightClick сделать проверку успешности бота и игрока. эти данные перекинуть в статистику. 


        public void GetHit(PartOfBody part)
        {
            if (block != part)
            {
                if (hp > (int)Constant.WoundHP)
                {
                    hp -= (int)Constant.WoundHP;
                    if (Wound != null)
                    {
                        Wound(this, new MyEventArgs(hp, name, part, block));
                        //  numberOfHits++;
                    }
                }
                else
                {
                    hp = (int)Constant.DeathHP;
                    if (Death != null)
                    {
                        Death(this, new MyEventArgs(hp, name));
                    }
                }
            }
            else if (block == part)
                if (Block != null)
                {
                    Block(this, new MyEventArgs(hp, name, block));

                }
        }

        public void SetBlock(PartOfBody part)
        {
            block = part;
        }

        public string Name
        {
            get { return name; }
            set { name = value;  }
        }

        public int HP
        {
            get { return hp; }
            set { hp = value; }
        }

        public PartOfBody BlockPart
        {
            get { return block; }
            set { block = value; }
        }
        public PartOfBody HitPart
        {
            get { return hit; }
            set { hit = value; }
        }
        //public int NumberOfHit
        //{
        //    get { return numberOfHits; }
        //}

        public event EventHandler<MyEventArgs> Wound;
        public event EventHandler<MyEventArgs> Block;
        public event EventHandler<MyEventArgs> Death;
    }
}
