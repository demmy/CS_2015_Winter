/*
 * Created by Mad Nomad
 * User: Mad Nomad
 * Date: 12.04.2016
 * Time: 5:19
 */
using System;
using System.Collections.Generic;
using System.Linq;
using DataLayer.Entities;
using DataLayer.Interfaces;
using DataLayer.Repositories;
using LogicLayer.DataObject;
using LogicLayer.Interfaces;

namespace LogicLayer.Services
{
    /// <summary>
    /// Description of UserService.
    /// </summary>
    public class UserService : IUserService
    {
        IServiceRepository db;
        public UserService(string connectionService)
        {
            db = new ServiceRepository(connectionService);
        }

        public List<UserDTO> GetAllUsers()
        {
            List<UserDTO> users = new List<UserDTO>();
            List<User> dbUsers = (List<User>)db.Users.GetAll();
            if (dbUsers.Count == 0)
            {
                return users;
            }
            foreach (User u in dbUsers)
            {
                users.Add(new UserDTO
                {
                    Id = u.Id,
                    Login = u.Login,
                    Password = u.Password,
                    EMail = u.EMail,
                    IsEMailValidated = u.IsEMailValid,
                    CharacterName = u.Character.ToString(),
                    RegistrationDate = u.Date
                });
            }
            return users;
        }

        public UserDTO GetUser(int userId)
        {
            User u = db.Users.GetById(userId);
            UserDTO user = new UserDTO
            {
                Id = u.Id,
                Login = u.Login,
                Password = u.Password,
                EMail = u.EMail,
                IsEMailValidated = u.IsEMailValid,
                CharacterName = u.Character.Name,
                RegistrationDate = u.Date
            };
            return user;
        }

        public PlayerDTO GetCharacterStatistic(int userId)
        {
            PlayerDTO statistics = new PlayerDTO
            {
                CharacterName = db.Players.GetById(userId).Name,
                Wins = db.Players.GetById(userId).Statistics.Wins,
                Loses = db.Players.GetById(userId).Statistics.Loses,
                Draws = db.Players.GetById(userId).Statistics.Draws
            };
            return statistics;
        }

        public List<UserDTO> GetUsersBySearchString(string word)
        {
            List<User> search = db.Users.GetAll().Where(x => x.Login.ToLower().Contains(word.ToLower())).ToList();
            List<UserDTO> result = new List<UserDTO>();
            if (search.Count > 0)
            {
                foreach (User u in search)
                {
                    result.Add(
                        new UserDTO
                        {
                            Id = u.Id,
                            Login = u.Login,
                            Password = u.Password,
                            CharacterName = u.Character.Name,
                            EMail = u.EMail,
                            IsEMailValidated = u.IsEMailValid,
                            RegistrationDate = u.Date
                        }
                        );
                }
            }
            return result;
        }

        public int GetUserByLogin(string login)
        {
                return db.Users.GetUserByLogin(login).Id;
        }

        public void AddUser(UserDTO user)
        {
            int newUserId = db.Users.GetLastUsedUserId() + 1;
            Random rnd = new Random();
            User u = new User
            {
                Id = newUserId,
                Login = user.Login,
                Password = user.Password,
                EMail = user.EMail,
                IsEMailValid = user.IsEMailValidated,
                Date = user.RegistrationDate,
                UserTransactions = new List<UserTransaction>() { },
                Character = new Player
                {
                    UserId = newUserId,
                    Name = user.CharacterName,
                    PlayerId = newUserId,
                    Date = DateTime.Now,
                    Statistics = new PlayerStatistic
                    {
                        Wins = rnd.Next(20),
                        Loses = rnd.Next(20),
                        Draws = rnd.Next(20)
                    }
                }

            };
            db.Users.Create(u);
            db.Save();
        }

        public void EditUser(UserDTO user)
        {
            User u = db.Users.GetById(user.Id);
            u.Login = user.Login;
            u.Password = user.Password;
            u.EMail = user.EMail;
            u.IsEMailValid = user.IsEMailValidated;
            u.Character.Name = user.CharacterName;
            db.Users.Update(u);
            db.Save();
        }

        public void Delete(int userId)
        {
            db.Users.Delete(db.Users.GetById(userId));
            db.Save();
        }

        public List<UserDTO> GetLastTenUsers()
        {
            {
                List<UserDTO> ut = new List<UserDTO>();
                List<User> udb = db.Users.GetAll().OrderBy(u => u.Date).ToList();
                if (udb.Count >= 10)
                {
                    udb = udb.Skip(Math.Max(0, udb.Count() - 10)).ToList();
                }
                foreach (User u in udb)
                {
                    ut.Add(new UserDTO
                    {
                        Id = u.Id,
                        Login = u.Login,
                        Password = u.Password,
                        CharacterName = u.Character.Name,
                        EMail = u.EMail,
                        IsEMailValidated = u.IsEMailValid,
                        RegistrationDate = u.Date
                    });
                }
                return ut;
            }
        }

        public List<UserDTO> GetUsersWithValidEMail()
        {
            throw new NotImplementedException();
        }

        public List<UserDTO> GetTopTenDonators()
        {
            throw new NotImplementedException();
        }
    }
}
