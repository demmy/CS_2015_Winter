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
            var combat = new Combat() { Date = new DateTime(2014, 2, 16) };
            var newPlayer = new Player() { Login = "bayern", Password = "munchen", Email = "bayern@gmail.com", IsValidEmail = true, Date = new DateTime(2014, 2, 11) };
            var newPlayer1 = new Player() { Login = "wolfsburg", Password = "123", Email = "wv@gmail.com", IsValidEmail = true, Date = new DateTime(2014, 2, 11) };

            combat.Pvps.Add(new Pvp() { Player = newPlayer, Enemy = newPlayer1 });
            var hitlog = new HitLog() { PlayerHitValue = 90, EnemyHitValue = 100, PlayerLogin = newPlayer.Login, EnemyLogin = newPlayer1.Login };
            combat.HitLog = hitlog;
            newPlayer.Transactions.Add(new Transaction() { Sum = 50, Date = new DateTime(2014, 1, 12) });
            newPlayer1.Transactions.Add(new Transaction() { Sum = 45, Date = new DateTime(2014, 1, 12) });

            combat.Winner = newPlayer1.Login;

            newPlayer.Combat = combat;
            newPlayer1.Combat = combat;
            context.Players.Add(newPlayer);
            context.Players.Add(newPlayer1);

            var combat1 = new Combat() { Date = new DateTime(2012, 2, 15) };
            var newPlayer3 = new Player() { Login = "archer", Password = "777", Email = "archer@gmail.com", IsValidEmail = true, Date = new DateTime(2012, 2, 10) };
            combat1.Winner = newPlayer3.Login;
            newPlayer3.Combat = combat1;
            newPlayer3.Combat.Pves.Add(new Pve() { Player = newPlayer3, Combat = combat1 });
            var hitlog1 = new HitLog() { PlayerHitValue = 100, EnemyHitValue = 70, PlayerLogin = newPlayer3.Login, EnemyLogin = "Bot" };
            newPlayer3.Combat.HitLog = hitlog1;
            newPlayer3.Transactions.Add(new Transaction() { Player = newPlayer3, Sum = 40, Date = new DateTime(2012, 2, 12) });
            context.Players.Add(newPlayer3);
        }
    }
}
