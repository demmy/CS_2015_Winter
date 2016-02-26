/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 19.02.2016
 * Time: 10:35
 */
using System;
using Combats;

namespace Combats
{
    /// <summary>
    /// Формат возвращаемых в качестве лога данных.
    /// </summary>
    public class Message
    {
        protected DateTime time;
        protected GameControl.RoundAction action;
        protected string attacker;
        protected string defender;
        protected string name;
        protected int damage;
        
        public GameControl.RoundAction Action
        {
            get
            {
                return action;
            }
            protected set
            {
                action = value;
            }
        }

        public string Attacker
        {
            get
            {
                return attacker;
            }
            set
            {
                attacker = value;
            }
        }
        
        public string Defender
        {
            get
            {
                return defender;
            }
            set
            {
                defender = value;
            }
        }
        
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
        
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        

        public Message(GameControl.RoundAction action, DateTime time, string attacker, string defender, int damage)
        {
            this.time = time;
            this.action = action;
            this.attacker = attacker;
            this.defender = defender;
            this.damage = damage;
        }

        public Message(GameControl.RoundAction action, DateTime time)
        {
            this.time = time;
            Action = action;
        }

        public Message(GameControl.RoundAction action, DateTime time, string name)
        {
            this.time = time;
            Action = action;
            this.name = name;
        }
    }
    
}
