using Enums.Entitys;
using FightClubReports.Data.Entitys;
using FightClubReports.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FightClubReports
{
    public class Player : BaseEntity 
    {
        public Player():base()
        { }

        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string EMail { get; set; }        
        public bool IsEmaillValid { get; set; }
        public DateTime DateOfRegistrations { get; set; }
        public virtual List<Combat> GameData { get; set; }
        public Statistics Statistics { get; set; } 
        public virtual List<Transaction> Transactions { get; set; }

        public override string ToString()
        {
            return string.Format("{0}", Login);
        }
    }
}