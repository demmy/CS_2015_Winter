using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCore
{
    public interface IPlayer
    {
        string Name { get; set; }
        int Hp { get; set; }
        int MaxHp { get; set; }
        int Strength { get; set; }
        int Armor { get; set; }
        int Rand { set; }
        int Damage { get; }
        int Bonus { get; set; }
        int GetHit(Position p, int damage);
        void SetBlock(Position p);
        event EventHandler<InfoEventArgs> Wound;
        event EventHandler<InfoEventArgs> Block;
        event EventHandler<InfoEventArgs> Death;
    }
}
