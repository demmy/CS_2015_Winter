using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubStatistics
{
    public class CombatLog
    {
        public int CombatLogId { get; set; }
        public GameType GameType { get; set; }
        public virtual Player FirstPlayer { get; set; }
        public virtual Player SecondPlayer { get; set; }
        public virtual List<HitLog> CombatHitLog { get; set; }
        public GameResult Result { get; set; }
        public int Exp { get; set; }
        public DateTime CombatTime { get; set; }
    }
}
