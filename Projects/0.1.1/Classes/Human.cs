/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 12.02.2016
 * Time: 11:42
 */
using System;

namespace Combats.Classes
{
    /// <summary>
    /// Description of Human.
    /// </summary>
    public class Human : Player
    {
        public bool isHumanAttacker;
        
        public Human(string name = "Jack", int hp = 100, int maxHp = 100, int damage = 25)
        {
            Name = name;
            Hp = hp;
            MaxHp = maxHp;
            Damage = damage;
            IsHumanAttacker = true;
        }
    }
}
