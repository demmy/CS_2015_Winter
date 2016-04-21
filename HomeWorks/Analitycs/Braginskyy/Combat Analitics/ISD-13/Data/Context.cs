using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_13.Data
{
    public class Context : DbContext
    {
        public Context()
        {        
            Database.SetInitializer<Context>(new MigrateDatabaseToLatestVersion<Context, Migrations.Configuration>());       
        }
        public DbSet<Player> Players { get; set; }
        public DbSet<Combat> Combats { get; set; }
        public DbSet<HitLog> HitLogs { get; set; }
        public DbSet<Transaction> Transactions { get; set; }         
    }
}
