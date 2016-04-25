using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubStatistics
{
    public interface IContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Transaction> Transactions { get; set; }
        DbSet<CombatLog> CombatLogs { get; set; }
        DbSet<HitLog> HitLogs { get; set; }

        void SaveChanges();
    }
}
