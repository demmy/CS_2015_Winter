namespace DataLayer.Migrations
{
    using EF;
    using Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Context context)
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

            for (int i = 0; i < 5; i++)
            {
                context.Users.AddOrUpdate(
                    c => c.Login,
                    new User
                    {
                        Login = "TestLogin" + i,
                        Password = "TestPass" + i,
                        EMail = "test" + i + "@email.com",
                        IsEMailValid = Convert.ToBoolean(new Random().Next(100) % 2 == 0),
                        Date = DateTime.Now,
                        Character = new Player
                        {
                            Name = "Player" + 1,
                            Statistics = new PlayerStatistic
                            {
                                Wins = new Random().Next(20),
                                Loses = new Random().Next(20),
                                Draws = new Random().Next(20)
                            }
                        }
                    }
                    );
            }
            context.SaveChanges();
        }
    }
}
