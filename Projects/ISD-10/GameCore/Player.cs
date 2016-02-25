using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCore
{
    public enum Position { Head = 1, Body, Legs }
    public class Player : IPlayer
    {
        public Player()
        {

        }
        public Player(string name)
        {
            this.name = name;
        }
        protected int rand = 0;
        protected string name = "Player";
        protected int hp = Setup.BaseHp;
        protected int maxHp = Setup.BaseHp;
        protected int strength = 0;
        protected int armor = 0;
        protected int bonus = Setup.BonusStat;
        protected Position block = Position.Legs;
        protected Position hit = Position.Legs;
        public void SetBlock(Position block)
        {
            this.block = block;
        }
        public int GetHit(Position hit, int damage)
        {
            this.hit = hit;
            if (block != hit)
            {
                if (hp - (damage - (armor / 2)) > 0)
                {
                    if (damage - (armor / 2) > 0)
                    {
                        hp = hp - (damage - (armor / 2));
                    }
                    if (Wound != null)
                    {
                        Wound(this, new InfoEventArgs(damage - armor / 2, hp, name));
                    }
                }
                else
                {
                    hp = 0;
                    if (Death != null)
                    {
                        Death(this, new InfoEventArgs(damage, hp, name));
                    }
                }
            }
            else if (block == hit)
            {
                if (Block != null)
                {
                    Block(this, new InfoEventArgs(damage, hp, name));
                }
            }
            return hp;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Hp
        {
            get { return hp; }
            set { hp = value; }
        }
        public int MaxHp
        {
            get { return maxHp; }
            set { maxHp = value; }
        }
        public int Strength
        {
            get { return strength; }
            set { strength = value; }
        }
        public int Armor
        {
            get { return armor; }
            set { armor = value; }
        }
        public int Rand
        {
            set { rand = value; }
        }
        public int Damage
        {
            get { return strength + rand; }
        }
        public int Bonus
        {
            get { return bonus; }
            set { bonus = value; }
        }
        public event EventHandler<InfoEventArgs> Wound;
        public event EventHandler<InfoEventArgs> Block;
        public event EventHandler<InfoEventArgs> Death;
    }
}
