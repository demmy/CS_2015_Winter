using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EF_Repository.Data;
using EF_Repository.Data.Interfaces;
using EF_Repository.Model;
using EF_Repository.Model.Interfaces;
using WinFormsEF.Classes.Interfaces;

namespace WinFormsEF.Classes
{
    class Service:IService
    {
        private IUnitOfWork _unitOfWork;
        public IPlayer CheckingValidateUser(string login , string password)
        {
            IPlayer myCheckingValidateUser;
            using ( _unitOfWork = new UnitOfWork())
            {
                  myCheckingValidateUser = (from p in _unitOfWork.PlayersRepo.GetPlayers()
                    where
                        String.Equals(p.Login, login, StringComparison.CurrentCultureIgnoreCase) &&
                        String.Equals(p.Password, password, StringComparison.CurrentCultureIgnoreCase)
                    select p).FirstOrDefault();
            }
            return myCheckingValidateUser;
        }

        public void CreatePlayer(string login, string password, string email, bool checkEmail)
        {
            var player = new Player() { Login = login, Password = password, Email = email, IsValidEmail = checkEmail, Date = DateTime.Now };
            using (_unitOfWork = new UnitOfWork())
            {
                _unitOfWork.PlayersRepo.Add(player);
                _unitOfWork.Save();
            }
        }

        public Array PlayersWithValidEmails()
        {
            using (_unitOfWork = new UnitOfWork())
            {
                var usersWithValidEmail = (from u in _unitOfWork.PlayersRepo.GetPlayers()
                    where u.IsValidEmail == true
                    select new {u.PlayerId, u.Login, u.Email, u.Date}).ToArray();
                return usersWithValidEmail;
            }
        }

        public Array TopPlayersByLongestPassword()
        {
            using (_unitOfWork = new UnitOfWork())
            {
                var longestPassword = (from p in _unitOfWork.PlayersRepo.GetPlayers()
                    orderby p.Password descending
                    select new {p.PlayerId, p.Login}).Take(5).ToArray();
                return longestPassword;
            }
        }

        public Array TopTransactionsBySum()
        {
            using (_unitOfWork = new UnitOfWork())
            {
                var transactions = (from p in _unitOfWork.TransactionsRepo.GetTranscations()
                    orderby p.Sum descending
                    select new {p.TransactId, p.PlayerId, p.Sum, p.Date}).
                    Take(3).ToArray();
                  return transactions;
            }
        }

        public Array PlayersOrderByDate()
        {
            using (_unitOfWork = new UnitOfWork())
            {
                var players = (from p in _unitOfWork.PlayersRepo.GetPlayers()
                               orderby p.Date descending
                               select new { p.PlayerId, p.Login, p.Date }).ToArray();
                return players;
            }
        }

        public Array Winners()
        {
            using (_unitOfWork = new UnitOfWork())
            {
                var winners = (from p in _unitOfWork.CombatsRepo.GetCombats()
                                    where p.Winner != null
                                    select new { p.CombatId, p.Winner, p.Date }).ToArray();
                return winners;
            }
        }

        public Array Pves()
        {
            using (_unitOfWork = new UnitOfWork())
            {
                var pves = (from c in _unitOfWork.CombatsRepo.GetCombats()
                            join p in _unitOfWork.PvesRepo.GetPves()
                            on c.CombatId equals p.CombatId
                            join n in _unitOfWork.PlayersRepo.GetPlayers()
                            on c.CombatId equals n.CombatId
                            select new { n.PlayerId, n.Login }).ToArray();
                return pves;
            }
        }

        public Array Pvps()
        {
            using (_unitOfWork = new UnitOfWork())
            {
                var pvps = (from c in _unitOfWork.CombatsRepo.GetCombats()
                            join p in _unitOfWork.PvpsRepo.GetPvps()
                                    on c.CombatId equals p.CombatId
                            join n in _unitOfWork.PlayersRepo.GetPlayers()
                            on c.CombatId equals n.CombatId
                            select new { n.PlayerId, n.Login }).ToArray();
                return pvps;
            }
        }

        public Array TransactionsOrderByDate()
        {
            using (_unitOfWork = new UnitOfWork())
            {
                var transactions = (from p in _unitOfWork.TransactionsRepo.GetTranscations()
                                    orderby p.Date descending
                                    select new { p.PlayerId, p.Sum, p.Date }).ToArray();
                return transactions;
            }
        }

    }
}
