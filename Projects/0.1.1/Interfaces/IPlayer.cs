/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 12.02.2016
 * Time: 11:38
 */
using System;
using Combats.Classes;

namespace Combats
{
    /// <summary>
    /// Description of IPlayer.
    /// </summary>
    public interface IPlayer
    {
        string Name { get; set; }
        bool IsHumanAttacker { get; set; }
        int MaxHp { get; set; }
        int Hp { get; set; }
        int Damage { get; set; }
        BodyPart GetHit(BodyPart arg);
        BodyPart SetBlock(BodyPart arg);
        event GameControl.PlayerStatus Wound;
        event GameControl.PlayerStatus Block;
        event GameControl.PlayerStatus Death;
    }
}
