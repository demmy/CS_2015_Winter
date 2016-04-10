using EF_Repository.Model;

namespace EF_Repository.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EF_Repository.Data.EfContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(EF_Repository.Data.EfContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            var combat = new Combat() { Date = new DateTime(2014, 2, 16) };
            var newPlayer = new Player() { Login = "bayern", Password = "munchen", Email = "bayern@gmail.com", IsValidEmail = true, Date = new DateTime(2014, 2, 11) };
            var newPlayer1 = new Player() { Login = "wolfsburg", Password = "vw", Email = "wv@gmail.com", IsValidEmail = true, Date = new DateTime(2014, 2, 11) };

            combat.Pvps.Add(new Pvp() { First = newPlayer, Second = newPlayer1 });



            var hitlog = new HitLog() { FirstPlayerHitValue = 90, SecondPlayerHitValue = 100, FirstPlayerLogin = newPlayer.Login, SecondPlayerLogin = newPlayer1.Login };
            combat.HitLog = hitlog;
            newPlayer.Transactions.Add(new Transcation() { Sum = 50, Date = new DateTime(2014, 1, 12) });
            newPlayer1.Transactions.Add(new Transcation() { Sum = 45, Date = new DateTime(2014, 1, 12) });

            combat.Winner = newPlayer1.Login;

            newPlayer.Combat = combat;
            newPlayer1.Combat = combat;
            context.Players.Add(newPlayer);
            context.Players.Add(newPlayer1);
        }
    }
}
