using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_13.Data
{
    class Context : DbContext
    {
        public DbSet<Player> Player { get; set; }
        public DbSet<Combat> Combat { get; set; }
        public DbSet<HitLog> HitLog { get; set; }
        public DbSet<Transaction> Transaction { get; set; }
    }
}
