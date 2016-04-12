/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 11.04.2016
 * Time: 15:47
 */
using System;

namespace DataLayer.Entities
{
    /// <summary>
    /// Description of Player.
    /// </summary>
    public class Player
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public int Hp { get; set; }
        public int MaxHP { get; set; }
        public int Damage { get; set; }
        public int Experience { get; set; }
        public virtual PlayerStatistic Statistics { get; set; }
    }
}
