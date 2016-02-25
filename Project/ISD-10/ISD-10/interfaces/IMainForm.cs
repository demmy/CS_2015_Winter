using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameCore;

namespace Combats
{
    public interface IMainForm
    {
        string PlayerName { get; set; }
        int PlayerHp { get; set; }
        int PlayerStrengthProgress { get; set; }
        int PlayerArmorProgress { get; set; }
        int PlayerHpMaxProgress { set; get; }
        int PlayerStrengthMaxProgress { get; set; }
        int PlayerArmorMaxProgress { get; set; }
        string BotName { set; }
        int BotHp { get; set; }
        int BotStrengthProgress { get; set; }
        int BotArmorProgress { get; set; }
        int BotHpMaxProgress { set; get; }
        int BotStrengthMaxProgress { get; set; }
        int BotArmorMaxProgress { get; set; }
        Position Hit { get; }
        Position Block { get; }
        string Log { set; }
        string LabelStat { set; }        
        event EventHandler Fight;
        event EventHandler NextBatle;
        event EventHandler PlayerStrengthAdd;
        event EventHandler PlayerArmorAdd;
        event EventHandler Save;
    }
}
