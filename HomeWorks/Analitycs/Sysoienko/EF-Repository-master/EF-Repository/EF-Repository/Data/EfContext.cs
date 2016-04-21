using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Repository.Model;
using EF_Repository.Model.Interfaces;

namespace EF_Repository.Data
{
    class EfContext:DbContext
    {
        public EfContext()
            : base("CombatDbReport")
        {
        }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Combat> Combats { get; set; }
        public virtual DbSet<Pve> Pves { get; set; }
        public virtual DbSet<Pvp> Pvps { get; set; }
        public virtual DbSet<HitLog> HitLogs { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pve>().HasRequired(c => c.Player).WithMany().WillCascadeOnDelete(false);
            //base.OnModelCreating(modelBuilder);
        }
    }
}
