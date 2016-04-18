/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 11.04.2016
 * Time: 15:47
 */
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Core.Objects.DataClasses;

namespace DataLayer.Entities
{
    /// <summary>
    /// Description of Player.
    /// </summary>
    public partial class Player
    {
        public int PlayerId { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        [DefaultValue(100)]
        public int Hp { get; set; }
        [DefaultValue(100)]
        public int MaxHP { get; set; }
        [DefaultValue(10)]
        public int Damage { get; set; }
        [DefaultValue(0)]
        public int Experience { get; set; }
        public virtual PlayerStatistic Statistics { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
