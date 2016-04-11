using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubReports.Entitys.Combat
{
    public class ActionLog
    {
        public int Id { get; set; }
        public Hitlog HitLog { get; set; }
        public BlockLog BlockLog { get; set; }
    }
}
