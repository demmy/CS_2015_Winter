/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 11.04.2016
 * Time: 15:52
 */
using System;
using System.Data.Entity;
using DataLayer.Entities;

namespace DataLayer.EF
{
    /// <summary>
    /// Description of Context.
    /// </summary>
    public class Context : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<UserTransaction> UserTransactions { get; set; }
        public DbSet<Battle> Battles { get; set; }
        public DbSet<BattleLog> BattleLogs { get; set; }

        public Context()
            : base ("name=MsSqlServer")
        {
        }
        
        public Context(string connectionString)
            : base(connectionString)
        {
        }
    }
}
