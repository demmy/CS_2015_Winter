using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Repository.Model;
using EF_Repository.Model.Interfaces;

namespace EfWinform.Class.Services
{
    internal class PlayerService : Service
    {
        private readonly List<IPlayer> _listPlayers = new List<IPlayer>();

        public override Array Get()
        {
            var players = (from p in UnitOfWork.PlayersRepo.GetAll()
                           select new { p.PlayerId, p.Login, p.Password, p.Email, p.IsValidEmail, p.Date }).ToArray();
            return players;
        }

        public IPlayer CheckingValidateUser(string login, string password)
        {
            IPlayer checkingValidateUser = (from p in UnitOfWork.PlayersRepo.GetAll()
                                            where
                                                String.Equals(p.Login, login, StringComparison.CurrentCultureIgnoreCase) &&
                                                String.Equals(p.Password, password, StringComparison.CurrentCultureIgnoreCase)
                                            select p).FirstOrDefault();
            return checkingValidateUser;
        }

        public void CreatePlayer(string login, string password, string email, bool checkEmail)
        {
            var player = new Player()
            {
                Login = login,
                Password = password,
                Email = email,
                IsValidEmail = checkEmail,
                Date = DateTime.Now
            };
            UnitOfWork.PlayersRepo.Insert(player);
        }

        public List<IPlayer> GetPlayers()
        {

            foreach (var item in UnitOfWork.PlayersRepo.GetAll())
            {
                _listPlayers.Add(item);
            }
            return _listPlayers;
        }

        public override void DeleteById(int id)
        {
            UnitOfWork.PlayersRepo.DeleteById(id);
        }

        public Array PlayersWithValidEmails()
        {

            var usersWithValidEmail = (from u in UnitOfWork.PlayersRepo.GetAll()
                                       where u.IsValidEmail == true
                                       select new { u.PlayerId, u.Login, u.Email, u.Date }).ToArray();
            return usersWithValidEmail;
        }
        public Array TopPlayersByLongestPassword()
        {
            var longestPassword = (from p in UnitOfWork.PlayersRepo.GetAll()
                                   orderby p.Password descending
                                   select new { p.PlayerId, p.Login }).Take(3).ToArray();
            return longestPassword;
        }
        public Array PlayersOrderByDate()
        {
            var players = (from p in UnitOfWork.PlayersRepo.GetAll()
                           orderby p.Date descending
                           select new { p.PlayerId, p.Login, p.Date }).ToArray();
            return players;
        }
    }

}
