using Enums.Entitys;
using System;
using System.Collections.Generic;

namespace FightClubReports
{
    public class Combat : BaseEntity
    {
        public int Id { get; set; }
        public DateTime TimeOfStart { get; set; }
        public bool TypePVP { get; set; } // pvp or pve 
        public virtual List<RoundLog> Log { get; set; }
        public virtual Player Player1 { get; set; }
        public virtual Player Player2 { get; set; }
        public bool WinnerIsExist { get; set; }
        public virtual Player Winner { get; set; }
    }
}