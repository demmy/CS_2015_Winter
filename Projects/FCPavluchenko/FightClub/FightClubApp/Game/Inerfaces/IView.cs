using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubApp.Inerfaces
{
    public interface IView
    {
        int Round { get; }
        string PlayerName { set; }
        int PlayerHp { set; }
        string BotName { set; }
        int BotHp { set; }
        PartOfBody Hit { get; }
        PartOfBody Block { get; }
        string Log { set; }
        event EventHandler FightClick;
        event EventHandler NextFightClick;
        event EventHandler StatisticsClick;
        event EventHandler EndRound;
        event EventHandler Save;
    }
}
