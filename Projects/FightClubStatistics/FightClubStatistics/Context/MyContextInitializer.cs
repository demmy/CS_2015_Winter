using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubStatistics
{
    public class MyContextInitializer : DropCreateDatabaseAlways<MyContext>
    {
        protected override void Seed(MyContext context)
        {
            #region AddFiveUsers
            context.Users.Add(new User
            {
                Login = "User1",
                EMail = "User1@mail.ru",
                CreationDate = DateTime.Now,
                IsEmailValid = true,
                Password = "123456",
                PlayerData = new Player
                {
                    Name = "player1",
                    Exp = 100
                }
            });
            context.Users.Add(new User
            {
                Login = "User2",
                EMail = "User2@mail.ru",
                CreationDate = DateTime.Now,
                IsEmailValid = true,
                Password = "456123",
                PlayerData = new Player
                {
                    Name = "player2",
                    Exp = 200
                }
            });
            context.Users.Add(new User
            {
                Login = "User3",
                EMail = "User3@mail.ru",
                CreationDate = DateTime.Now,
                IsEmailValid = true,
                Password = "789465",
                PlayerData = new Player
                {
                    Name = "player3",
                    Exp = 300
                }
            });
            context.Users.Add(new User
            {
                Login = "User4",
                EMail = "User4@mail.ru",
                CreationDate = DateTime.Now,
                IsEmailValid = true,
                Password = "321456",
                PlayerData = new Player
                {
                    Name = "player4",
                    Exp = 400
                }
            });
            context.Users.Add(new User
            {
                Login = "User5",
                EMail = "User5@mail.ru",
                CreationDate = DateTime.Now,
                IsEmailValid = true,
                Password = "555555",
                PlayerData = new Player
                {
                    Name = "player5",
                    Exp = 500
                }
            });
            #endregion

            #region AddThreeTransactions
            context.Transactions.Add(new Transaction
            {
                User = new User
                {
                    UserId = 1,
                    Login = "User1",
                    EMail = "User1@mail.ru",
                    CreationDate = DateTime.Now,
                    IsEmailValid = true,
                    Password = "123456",
                    PlayerData = new Player
                    {
                        Name = "player1",
                        Exp = 100
                    }
                },
                Sum = 100,
                Date = DateTime.Now
            });
            context.Transactions.Add(new Transaction
            {
                User = new User
                {
                    UserId = 2,
                    Login = "User2",
                    EMail = "User2@mail.ru",
                    CreationDate = DateTime.Now,
                    IsEmailValid = true,
                    Password = "456123",
                    PlayerData = new Player
                    {
                        Name = "player2",
                        Exp = 200
                    }
                },
                Sum = 200,
                Date = DateTime.Now
            });
            //context.Transactions.Add(new Transaction
            //{
            //    User = (User)context.Users.Where(x => x.UserId == 4).FirstOrDefault(),
            //    Sum = 300,
            //    Date = DateTime.Now
            //}); 
            #endregion

            base.Seed(context);
        }
    }
}
