/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 12.02.2016
 * Time: 11:42
 */
using System;

namespace Combats
{
    /// <summary>
    /// Description of Npc.
    /// </summary>
    public class Npc : Player
    {
        Random rnd = new Random();
        
        
        public Npc(string name = "Tyler", int hp = 100, int maxHp = 100, int damage = 25)
        {
            Name = name;
            Hp = hp;
            MaxHp = maxHp;
            Damage = damage;
        }
        
        public BodyPart GenRandPart()
        {
            int items = Enum.GetNames(typeof(BodyPart)).Length;
            return (BodyPart)rnd.Next(1, items);
        }
        
        public override BodyPart GetHit(BodyPart arg = 0)
        {
            return GenRandPart();
        }
        
        public override BodyPart SetBlock(BodyPart arg = 0)
        {
            return GenRandPart();
        }
    }
}
