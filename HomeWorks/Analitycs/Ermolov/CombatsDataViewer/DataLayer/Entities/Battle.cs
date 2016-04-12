/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 11.04.2016
 * Time: 15:48
 */
using System;

namespace DataLayer.Entities
{
    /// <summary>
    /// Description of Battle.
    /// </summary>
    public enum BattleResult
    {
        Draw,
        FirstPlayerWin,
        SecondPlayerWin
    }
    
    public enum BattleType
    {
        None,
        PvM,
        PvP
    }
    
    public class Battle
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public BattleType Type { get; set; }
        public virtual Player FirstPlayer { get; set; }
        public virtual Player SecondPlayer { get; set; }
        public virtual BattleLog BattleLog { get; set; }
        public BattleResult Result { get; set; }
        public int ExpGained { get; set; }
    }
}
