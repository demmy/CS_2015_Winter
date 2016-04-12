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
    /// Description of PlayerStatistic.
    /// </summary>
    public class PlayerStatistic
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public virtual Player Player { get; set; }
        public int Wins { get; set; }
        public int Loses { get; set; }
        public int Draws { get; set; }
    }
}
