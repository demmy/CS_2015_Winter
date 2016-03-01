/*
 * Created by Mad Nomad
 * User: Mad Nomad
 * Date: 25.02.2016
 * Time: 23:21
 */
using System;

namespace Combats
{
    /// <summary>
    /// Description of IView.
    /// </summary>
    public interface IBattlePageView
    {
        string BattleFirstPlayerName { get; set; }
        int BattleFirstPlayerHP { get; set; }
        int BattleFirstPlayerHpMax { get; set; }
        string BattleSecondPlayerName { get; set; }
        int BattleSecondPlayerHP { get; set; }
        int BattleSecondPlayerHpMax { get; set; }
        string BattleResultMessage { get; set; }
        bool RadioButtonsVisible { get; set; }
        bool NewBattleButtonVisible { get; set; }
        string AddBattleLog { get; set; }
        
    }
}
