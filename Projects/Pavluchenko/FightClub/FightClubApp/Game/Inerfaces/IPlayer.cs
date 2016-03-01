using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubApp.Inerfaces
{
    public interface IPlayer
    {
        string Name { get; set; }
        int HP { get; set; }
        void GetHit(PartOfBody part);
        void SetBlock(PartOfBody part);
        PartOfBody BlockPart { get; set; }
        PartOfBody HitPart { get; set; }
        event EventHandler<MyEventArgs> Wound;
        event EventHandler<MyEventArgs> Block;
        event EventHandler<MyEventArgs> Death;
    }
}
