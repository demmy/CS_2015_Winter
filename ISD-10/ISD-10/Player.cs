using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_10
{
   
    public delegate void StatusPlayer (int damage, int xp, string name);
    public interface IPlayer
    {
        string PlayerName { get; }
        int PlayerHp { get; set; }
        int GetHit(Position b);
        void SetBlock(Position b);
        event StatusPlayer Wound;
        event StatusPlayer Block;
        event StatusPlayer Death;
        
    }
    public enum Position { Head = 1, Body, Legs }
    public class Player : IPlayer
    {
        public event StatusPlayer Wound;
        public event StatusPlayer Block;
        public event StatusPlayer Death;
       
        private string name = "Player";
        private int xp = 100;
        private int block;
        private int damage = 5;       

        public string PlayerName
        {
            get { return name; }
        }
        public int PlayerHp
        {
            get { return xp; }
            set { xp = value; }
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
