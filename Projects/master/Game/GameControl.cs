/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 12.02.2016
 * Time: 11:57
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Collections;

namespace Combats
{
    /// <summary>
    /// Description of GameControl.
    /// </summary>
    public enum BodyPart
    {
        None,
        [Description("Голова")]
        Head,
        [Description("Корпус")]
        Body,
        [Description("Ноги")]
        Legs
    }
    
    public partial class GameControl
    {
        public delegate void PlayerStatus(string name, int hp, int damage);

        public IPlayer Human;
        public IPlayer Npc;
        public List<Message> Log = new List<Message>();

        public GameControl(string name)
        {
            Human = new Human(name);
            Npc = new Npc();
        }
        
        protected void GetPrize(IPlayer player)
        {
            //            TODO Реализовать получение опыта/уровня.
        }

        public enum RoundAction
        {
            none,
            attacked,
            blocked,
            dead,
            draw,
            win
                
        }
        public List<Message> MakeRound(BodyPart attackPoint, BodyPart blockPoint)
        {
            Log.Clear();

            if (Human.Hp <= 0 || Npc.Hp <= 0)
            {
                return Log;
            }
            
            if (Human.IsHumanAttacker)
            {
                HumanAttack(attackPoint);
                HumanBlock(blockPoint);
                Human.IsHumanAttacker = false;
            }
            else
            {
                HumanBlock(blockPoint);
                HumanAttack(attackPoint);
                Human.IsHumanAttacker = true;
            }
            
            if (Human.Hp <= 0 && Npc.Hp <= 0)
            {
                Log.Add(new Message(RoundAction.draw, DateTime.Now));
            }
            else if (Human.Hp <= 0)
            {
                Log.Add(new Message(RoundAction.dead, DateTime.Now, Human.Name));
                Log.Add(new Message(RoundAction.win, DateTime.Now, Npc.Name));
                GetPrize(Npc);
            }
            else if (Npc.Hp <= 0)
            {
                Log.Add(new Message(RoundAction.dead, DateTime.Now, Npc.Name));
                Log.Add(new Message(RoundAction.win, DateTime.Now, Human.Name));
                GetPrize(Human);
            }
            return Log;
        }
        
        
        protected void HumanAttack(BodyPart attackPoint)
        {
            RoundAction action;
            if (attackPoint != Npc.SetBlock(BodyPart.None))
            {
                Npc.Hp -= Human.Damage;
                action = RoundAction.attacked;
            }
            else
            {
                action = RoundAction.blocked;
            }
            Log.Add(new Message(action, DateTime.Now, Human.Name, Npc.Name, Human.Damage));
        }
        
        protected void HumanBlock(BodyPart blockPoint)
        {
            RoundAction action;
            if (blockPoint != Npc.GetHit(BodyPart.None))
            {
                Human.Hp -= Npc.Damage;
                action = RoundAction.attacked;
            }
            else
            {
                action = RoundAction.blocked;
            }
            Log.Add(new Message(action, DateTime.Now, Npc.Name, Human.Name, Human.Damage));
        }

        public void ChangeName(string name)
        {
            Human.Name = name;
        }
    }
}
