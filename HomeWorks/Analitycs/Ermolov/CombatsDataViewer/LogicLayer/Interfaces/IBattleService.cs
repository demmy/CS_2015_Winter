/*
 * Created by Mad Nomad
 * User: Mad Nomad
 * Date: 12.04.2016
 * Time: 5:13
 */
using System;
using System.Collections.Generic;
using LogicLayer.DataObject;

namespace LogicLayer.Interfaces
{
    /// <summary>
    /// Description of IBattleService.
    /// </summary>
    public interface IBattleService
    {
        IEnumerable<BattleDTO> GetCharacterBattles(int id);
        IEnumerable<BattleDTO> GetCharacterWinBattles(int id);
        IEnumerable<BattleDTO> GetCharacterLoseBattles(int id);
        IEnumerable<BattleDTO> GetCharacterDrawBattles(int id);
    }
}
