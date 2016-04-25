using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubStatistics
{
   public class MyContext : DbContext , IContext
    {
        public MyContext()
        {
            Database.SetInitializer<MyContext>(new MyContextInitializer());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<CombatLog> CombatLogs { get; set; }
        public DbSet<HitLog> HitLogs { get; set; }

        void IContext.SaveChanges()
        {
            this.SaveChanges();
        }
    }
}
