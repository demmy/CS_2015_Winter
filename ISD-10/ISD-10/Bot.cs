using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_10
{
    public delegate void StatusBot (int damage, int xp, string name);
    public interface IBot
    {
        string BotName { get; }
        int BotHp { get; set; }
        int RandomBlock { get; }
        int RandomHit { get; }
        int GetHit(Position b);
        void SetBlock(Position b);
        event StatusBot Wound;
        event StatusBot Block;
        event StatusBot Death;
    }    
    public class Bot : IBot
    {
        public event StatusBot Wound;
        public event StatusBot Block;
        public event StatusBot Death;
        private string name = "Bot";
        private int xp = 100;
        private int block;
        private int damage = 5;        
        Random r = new Random();

        public string BotName
        {
            get { return name; }
        }
        public int BotHp
        {
            get { return xp; }
            set { xp = value; }
        }
        public int RandomBlock
        {
            get { return r.Next(1, 4); }
        }
        public int RandomHit
        {
            get { return r.Next(1, 4); }
        }
        public int GetHit(Position b)
        {            
            if (block != (int)b)
            {
                if (xp - damage > 0)
                {
                    xp = xp - damage;
                    if (Wound != null) Wound(damage, xp, name);
                }
                else
                {
                    xp = 0;
                    if (Death != null) Death(damage, xp, name);
                }
            }
            else if (block == (int)b)
            {
                if (Block != null) Block(damage, xp, name);
            }

            return xp;
        }
        public void SetBlock(Position b)
        {
            block = (int)b;
        }
    }
}
