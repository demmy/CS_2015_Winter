namespace ISD_13.Migrations
{
    using ISD_13.Data;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ISD_13.Data.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ISD_13.Data.Context context)
        {
            var player1 = new Player() { Login = "Ninja", Password = "123456", EMail = "Ninja@mail.ru", EMailValid = true, Date = DateTime.Now };
            var player2 = new Player() { Login = "BatMan", Password = "004fgh0", EMail = "BatMan@mail.ru", EMailValid = true, Date = DateTime.Now };
            var player3 = new Player() { Login = "Superman", Password = "dfgdfg", EMail = "Superman@mail", EMailValid = false, Date = DateTime.Now };
            var player4 = new Player() { Login = "Hunter", Password = "12345365", EMail = "Huntermail.ru", EMailValid = false, Date = DateTime.Now };
            var player5 = new Player() { Login = "Killer", Password = "qwerty", EMail = "Killer@mail.ru", EMailValid = true, Date = DateTime.Now };
            var player6 = new Player() { Login = "BOT", Password = "000000", EMail = "BOT", EMailValid = false, Date = DateTime.Now };
            context.Players.AddRange(new List<Player> { player1, player2, player3, player4, player5, player6 });
            context.SaveChanges();


            var hit1 = new HitLog() { HitValue = 10, Part = BodyPart.Head, Result = 4, Date = DateTime.Now };
            var hit2 = new HitLog() { HitValue = 12, Part = BodyPart.Body, Result = 0, Date = DateTime.Now };
            var hit3 = new HitLog() { HitValue = 17, Part = BodyPart.Head, Result = 2, Date = DateTime.Now };
            var hit4 = new HitLog() { HitValue = 11, Part = BodyPart.Legs, Result = 5, Date = DateTime.Now };
            var hit5 = new HitLog() { HitValue = 7, Part = BodyPart.Legs, Result = 2, Date = DateTime.Now };
            var hit6 = new HitLog() { HitValue = 15, Part = BodyPart.Head, Result = 13, Date = DateTime.Now };
            var hit7 = new HitLog() { HitValue = 5, Part = BodyPart.Head, Result = 1, Date = DateTime.Now };
            var hit8 = new HitLog() { HitValue = 18, Part = BodyPart.Body, Result = 16, Date = DateTime.Now };
            var hit9 = new HitLog() { HitValue = 13, Part = BodyPart.Head, Result = 11, Date = DateTime.Now };
            var hit10 = new HitLog() { HitValue = 11, Part = BodyPart.Legs, Result = 8, Date = DateTime.Now };
            var hit11 = new HitLog() { HitValue = 7, Part = BodyPart.Legs, Result = 0, Date = DateTime.Now };
            var hit12 = new HitLog() { HitValue = 17, Part = BodyPart.Head, Result = 4, Date = DateTime.Now };
            var hit13 = new HitLog() { HitValue = 13, Part = BodyPart.Head, Result = 7, Date = DateTime.Now };
            var hit14 = new HitLog() { HitValue = 11, Part = BodyPart.Body, Result = 0, Date = DateTime.Now };
            var hit15 = new HitLog() { HitValue = 19, Part = BodyPart.Head, Result = 13, Date = DateTime.Now };
            var hit16 = new HitLog() { HitValue = 21, Part = BodyPart.Legs, Result = 18, Date = DateTime.Now };
            var hit17 = new HitLog() { HitValue = 17, Part = BodyPart.Legs, Result = 0, Date = DateTime.Now };
            var hit18 = new HitLog() { HitValue = 18, Part = BodyPart.Head, Result = 8, Date = DateTime.Now };
            context.HitLogs.AddRange(new List<HitLog> { hit1, hit2, hit3, hit4, hit5, hit6, hit17, hit8, hit9, 
                hit10, hit11, hit12, hit13, hit14, hit15, hit16, hit17, hit18 });

            var transaction1 = new Transaction() { Date = DateTime.Now, Player = player1, Sum = 100 };
            var transaction2 = new Transaction() { Date = DateTime.Now, Player = player2, Sum = 200 };
            var transaction3 = new Transaction() { Date = DateTime.Now, Player = player3, Sum = 150 };
            var transaction4 = new Transaction() { Date = DateTime.Now, Player = player4, Sum = 70 };
            var transaction5 = new Transaction() { Date = DateTime.Now, Player = player5, Sum = 40 };
            var transaction6 = new Transaction() { Date = DateTime.Now, Player = player1, Sum = 120 };
            var transaction7 = new Transaction() { Date = DateTime.Now, Player = player1, Sum = 80 };
            var transaction8 = new Transaction() { Date = DateTime.Now, Player = player5, Sum = 220 };
            var transaction9 = new Transaction() { Date = DateTime.Now, Player = player4, Sum = 180 };
            var transaction10 = new Transaction() { Date = DateTime.Now, Player = player3, Sum = 170 };
            var transaction11 = new Transaction() { Date = DateTime.Now, Player = player3, Sum = 420 };
            var transaction12 = new Transaction() { Date = DateTime.Now, Player = player2, Sum = 10 };
            context.Transactions.AddRange(new List<Transaction> { transaction1, transaction2, transaction3, transaction4, transaction5, transaction6,
            transaction7, transaction8, transaction9, transaction10, transaction11, transaction12});

            Combat combat1 = new Combat
            {
                CombatTypePVP = true,
                FirstPlayer = player1,
                SecondPlayer = player2,
                Date = DateTime.Now,
                Winner = player1,
                Experience = 15,
                CombatLog = new List<HitLog>() { hit1, hit2 }
            };
            combat1.Players.Add(player1);
            combat1.Players.Add(player2);
            Combat combat2 = new Combat
            {
                CombatTypePVP = true,
                FirstPlayer = player2,
                SecondPlayer = player1,
                Date = DateTime.Now,
                Winner = player2,
                Experience = 11,
                CombatLog = new List<HitLog>() { hit3, hit4 }
            };
            combat2.Players.Add(player1);
            combat2.Players.Add(player2);
            Combat combat3 = new Combat
            {
                CombatTypePVP = true,
                FirstPlayer = player2,
                SecondPlayer = player5,
                Date = DateTime.Now,
                Winner = player2,
                Experience = 10,
                CombatLog = new List<HitLog>() { hit5, hit6 }
            };
            combat3.Players.Add(player2);
            combat3.Players.Add(player5);
            Combat combat4 = new Combat
            {
                CombatTypePVP = false,
                FirstPlayer = player3,
                SecondPlayer = player6,
                Date = DateTime.Now,
                Winner = player3,
                Experience = 14,
                CombatLog = new List<HitLog>() { hit7, hit8 }
            };
            combat4.Players.Add(player3);
            combat4.Players.Add(player6);
            Combat combat5 = new Combat
            {
                CombatTypePVP = false,
                FirstPlayer = player2,
                SecondPlayer = player6,
                Date = DateTime.Now,
                Winner = player6,
                Experience = 4,
                CombatLog = new List<HitLog>() { hit9, hit10 }
            };
            combat5.Players.Add(player3);
            combat5.Players.Add(player6);
            Combat combat6 = new Combat
            {
                CombatTypePVP = true,
                FirstPlayer = player4,
                SecondPlayer = player1,
                Date = DateTime.Now,
                Winner = player4,
                Experience = 17,
                CombatLog = new List<HitLog>() { hit11, hit12 }
            };
            combat6.Players.Add(player1);
            combat6.Players.Add(player4);
            Combat combat7 = new Combat
            {
                CombatTypePVP = true,
                FirstPlayer = player3,
                SecondPlayer = player4,
                Date = DateTime.Now,
                Winner = player3,
                Experience = 9,
                CombatLog = new List<HitLog>() { hit13, hit14 }
            };
            combat7.Players.Add(player3);
            combat7.Players.Add(player4);
            Combat combat8 = new Combat
            {
                CombatTypePVP = true,
                FirstPlayer = player5,
                SecondPlayer = player1,
                Date = DateTime.Now,
                Winner = player1,
                Experience = 3,
                CombatLog = new List<HitLog>() { hit15, hit16 }
            };
            combat8.Players.Add(player1);
            combat8.Players.Add(player5);
            Combat combat9 = new Combat
            {
                CombatTypePVP = true,
                FirstPlayer = player4,
                SecondPlayer = player2,
                Date = DateTime.Now,
                Winner = player2,
                Experience = 8,
                CombatLog = new List<HitLog>() { hit17, hit18 }
            };
            combat9.Players.Add(player4);
            combat9.Players.Add(player2);
            context.Combats.Add(combat1);
            context.Combats.Add(combat2);
            context.Combats.Add(combat3);
            context.Combats.Add(combat4);
            context.Combats.Add(combat5);
            context.Combats.Add(combat6);
            context.Combats.Add(combat7);
            context.Combats.Add(combat8);
            context.Combats.Add(combat9);
            context.SaveChanges();
        }
    }
}
