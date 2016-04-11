using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using EF_Repository.Model;

namespace EF_Repository.Data
{
    class DbInitializer : DropCreateDatabaseIfModelChanges<EfContext>
    {
        public  void AddEntityGraph()
        {
            var combat = new Combat() { Date = new DateTime(2012, 2, 15) };
            var newPlayer = new Player() { Login = "archer", Password = "777", Email = "archer@gmail.com", IsValidEmail = true, Date = new DateTime(2012, 2, 10) };
            newPlayer.Combat = combat;
            newPlayer.Combat.Pves.Add(new Pve() { Player = newPlayer, Combat = combat });
            var hitlog = new HitLog() { FirstPlayerHitValue = 100, SecondPlayerHitValue = 70, FirstPlayerLogin = newPlayer.Login, SecondPlayerLogin = "Bot" };
            newPlayer.Combat.HitLog = hitlog;
            newPlayer.Transactions.Add(new Transcation() { Player = newPlayer, Sum = 40, Date = new DateTime(2012, 2, 12) });
            using (var entity = new EfContext())
            {
                UnitOfWork unitOfWork = new UnitOfWork(entity);
                unitOfWork.PlayersRepo.Add(newPlayer);
                try
                {
                    entity.SaveChanges();

                }
                catch (DbEntityValidationException e)
                {
                    foreach (var eve in e.EntityValidationErrors)
                    {
                        Debug.WriteLine(@"Entity of type \{0}\ in state \{1}\ has the
                                 following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Debug.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                ve.PropertyName, ve.ErrorMessage);
                        }
                    }
                    throw;
                }
                catch (DbUpdateException e)
                {
                    Debug.WriteLine(e.Entries);
                    var exception = HandleDbUpdateException(e);
                    throw exception;
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.Message);
                    throw;
                }
            }

        }
        private  Exception HandleDbUpdateException(DbUpdateException dbu)
        {
            var builder = new StringBuilder("A DbUpdateException was caught while saving changes. ");

            try
            {
                foreach (var result in dbu.Entries)
                {
                    builder.AppendFormat("Type: {0} was part of the problem. ", result.Entity.GetType().Name);
                }
            }
            catch (Exception e)
            {
                builder.Append("Error parsing DbUpdateException: " + e.ToString());
            }

            string message = builder.ToString();
            return new Exception(message, dbu);
        }

        public  IList<Player> AddEntityGraphs()
        {
            IList<Player> players = new List<Player>();

            var combat = new Combat() { Date = new DateTime(2013, 1, 15) };
            var newPlayer = new Player() { Login = "mike", Password = "000", Email = "mike@mail.ru", IsValidEmail = false, Date = new DateTime(2013, 1, 10) };
            var newPlayer1 = new Player() { Login = "alex", Password = "111", Email = "plyaer@mail.ru", IsValidEmail = true, Date = new DateTime(2013, 1, 10) };

            combat.Pvps.Add(new Pvp() { First = newPlayer, Second = newPlayer1 });



            var hitlog = new HitLog() { FirstPlayerHitValue = 60, SecondPlayerHitValue = 100, FirstPlayerLogin = newPlayer.Login, SecondPlayerLogin = newPlayer1.Login };
            combat.HitLog = hitlog;
            newPlayer.Transactions.Add(new Transcation() { Sum = 20, Date = new DateTime(2010, 1, 12) });
            newPlayer1.Transactions.Add(new Transcation() { Sum = 30, Date = new DateTime(2010, 1, 12) });

            combat.Winner = newPlayer1.Login;

            newPlayer.Combat = combat;
            newPlayer1.Combat = combat;
            players.Add(newPlayer);
            players.Add(newPlayer1);
            return players;
        }

        protected override void Seed(EfContext context)
        {
            IList<Player> list = AddEntityGraphs();
            foreach (var player in list)
            {
                context.Players.Add(player);
            }
            base.Seed(context);
        }
    }
}
