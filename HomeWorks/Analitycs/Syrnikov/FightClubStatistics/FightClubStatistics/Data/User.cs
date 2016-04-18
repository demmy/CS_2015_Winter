using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubStatistics
{
    public class User
    {
        public int UserId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string EMail { get; set; }
        public virtual Player PlayerData { get; set; }
        public bool IsEmailValid { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
