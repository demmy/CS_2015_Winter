/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 11.04.2016
 * Time: 15:48
 */
using System;
using System.ComponentModel;

namespace DataLayer.Entities
{
    /// <summary>
    /// Description of PlayerStatistic.
    /// </summary>
    public class PlayerStatistic
    {
        [DefaultValue(0)]
        public int Wins { get; set; }
        [DefaultValue(0)]
        public int Loses { get; set; }
        [DefaultValue(0)]
        public int Draws { get; set; }
    }
}
