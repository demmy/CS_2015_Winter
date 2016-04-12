/*
 * Created by Mad Nomad
 * User: Mad Nomad
 * Date: 12.04.2016
 * Time: 4:40
 */
using System;

namespace LogicLayer.DataObject
{
    /// <summary>
    /// Description of BattleDTO.
    /// </summary>
    public class BattleDTO
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int BattleLogId { get; set; }
        public BattleResult Result { get; set; }
    }

    public enum BattleResult
    {
        Draw,
        Win,
        Lose
    }
}
