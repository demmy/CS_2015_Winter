/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 11.04.2016
 * Time: 15:50
 */
using System;

namespace DataLayer.Entities
{
    /// <summary>
    /// Description of BattleLog.
    /// </summary>
    
    public enum BodyPart
    {
        None,
        Head,
        Body,
        Legs
    }

    public class BattleLog
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public virtual Player FirstPlayer { get; set; }
        public virtual Player SecondPlayer { get; set; }
        public BodyPart Part { get; set; }
        public int Result { get; set; }
        public int HitValue { get; set; }
    }
}
