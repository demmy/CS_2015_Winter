using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubApp.Inerfaces
{
    public interface IStatistics
    {
        int HitLegs { get; }
        int HitTors { get; }
        int HitHead { get; }
        int BlockLegs { get; }
        int BlockTors { get; }
        int BlockHead { get; }
        void ShowInfo();
        void FightStatis();
    }
}
