namespace WindowsFormsApplication2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WindowsFormsApplication2.Domain;

    internal sealed class Configuration : DbMigrationsConfiguration<WindowsFormsApplication2.Data.MyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WindowsFormsApplication2.Data.MyContext context)
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

            var vasya = new Person
            {
                FName = "Vaja",
                LName = "Bulkin",
                Id = 1,
                Address = new Address { Id = 1, City = "Kyiv", Street = "Novaja" }

            };

            context.Persons.Add(vasya);

            context.SaveChanges();
        }
    }
}
