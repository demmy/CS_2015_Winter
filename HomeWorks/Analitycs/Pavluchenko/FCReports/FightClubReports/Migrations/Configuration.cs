namespace FightClubReports.Migrations
{
    using Data.Entitys;
    using Entitys;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FightClubReports.Data.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "FightClubReports.Data.Context";
        }

        protected override void Seed(FightClubReports.Data.Context context)
        {

            if (context.Players.Count() == 0) //?
            {
                #region Statistics
                var statistics1 = new Statistics()
                {
                    Combats = 4,
                    Wins = 3,
                    Draws = 1
                };

                var statistics2 = new Statistics()
                {
                    Combats = 7,
                    Wins = 5,
                    Draws = 1
                };

                var statistics3 = new Statistics()
                {
                    Combats = 7,
                    Wins = 2,
                    Draws = 2
                };

                var statistics4 = new Statistics()
                {
                    Combats = 20,
                    Wins = 2,
                    Draws = 12
                };

                #endregion

                #region Players

                var player1 = new Player()
                {
                    Login = "Pikovit",
                    Password = "limpopo200",
                    EMail = "PikEmail@gmail.com",
                    IsEmaillValid = true,
                    Statistics = statistics1,
                    DateOfRegistrations = new DateTime(2001, 2, 2)
                };

                var player2 = new Player()
                {
                    Login = "Jameson",
                    Password = "12dublin21",
                    EMail = "Irish@ir.com",
                    IsEmaillValid = true,
                    Statistics = statistics2,
                    DateOfRegistrations = new DateTime(1997, 12, 2)
                };

                var player3 = new Player()
                {
                    Login = "Maldini",
                    Password = "forzaMilan",
                    EMail = null,
                    IsEmaillValid = false,
                    Statistics = statistics3,
                    DateOfRegistrations = new DateTime(2012, 1, 1)
                };

                var player4 = new Player()
                {
                    Login = "Chendler",
                    Password = "Bing777",
                    EMail = null,
                    IsEmaillValid = false,
                    Statistics = statistics4,
                    DateOfRegistrations = new DateTime(2001, 6, 19)
                };

                context.Players.AddRange(new List<Player> { player1, player2, player3, player4 });

                #endregion

                #region Transactions
                var transactions1 = new Transaction()
                {
                    Date = new DateTime(2012, 1, 23),
                    Sum = 222,
                    Player = player3
                };

                var transactions2 = new Transaction()
                {
                    Date = new DateTime(2013, 2, 11),
                    Sum = 1421,
                    Player = player1
                };

                var transactions3 = new Transaction()
                {
                    Date = new DateTime(2001, 3, 15),
                    Sum = 123,
                    Player = player1
                };

                var transactions4 = new Transaction()
                {
                    Date = new DateTime(2015, 4, 12),
                    Sum = 7236,
                    Player = player2
                };

                context.Transactions.AddRange(new List<Transaction> { transactions1, transactions2, transactions3, transactions4 });

                #endregion

                #region Combats

                var combat1 = new Combat()
                {
                    TimeOfStart = new DateTime(2016, 1, 12),
                    WinnerIsExist = true,
                    Player1 = player1,
                    Player2 = player2,
                    Winner = player2,
                    TypePVP = true
                };

                var combat2 = new Combat()
                {
                    TimeOfStart = new DateTime(2016, 3, 30),
                    WinnerIsExist = false,
                    Player1 = player1,
                    Player2 = player3,
                    Winner = null,
                    TypePVP = true
                };

                var combat3 = new Combat()
                {
                    TimeOfStart = new DateTime(2016, 3, 15),
                    WinnerIsExist = false,
                    Player1 = player1,
                    Player2 = null,
                    Winner = null,
                    TypePVP = false
                };
                context.Combats.AddRange(new List<Combat> { combat1, combat2, combat3 });
                #endregion

                context.SaveChanges();
            }
                
            

        }
    }
}
