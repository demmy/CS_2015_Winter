using FightClubReports.Data;
using FightClubReports.Entitys;
using FightClubReports.Interfaces;
using FightClubReports.Properties;
using FightClubReports.Repository;
using FightClubReports.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FightClubReports
{
    public class MainPresenter
    {
        private readonly IView view;
        private readonly ServiceRepository service;
        private List<Player> players;
        private Player player;
        private List<Transaction> transactions;
        private Transaction transaction;
        private List<Combat> combats;
        bool loginValid;
        bool passwordValid;
        bool emailValid;
        bool sumValid;
        bool dateValid;

        public MainPresenter(IView view)
        {
            this.view = view;
            service = new ServiceRepository();
            view.playersOkClick += onPlayersOkClick;
            view.transactionsOkClick += onTransactionsOkClick;
            view.combatsOkClick += onCombatsOkClick;
            view.playerSaveClick += onPlayerSaveClick;
            view.transactionSaveClick += onTransactionsSaveClick;
        }

        #region EventHandlers

        private void onPlayersOkClick(object sender, EventArgs e)
        {
            InfoForPlayerTable();
            view.PlayerTable = players;
        }

        private void onTransactionsOkClick(object sender, EventArgs e)
        {
            InfoForTransactionTable();
            view.TransactionsTable = transactions;
        }

        private void onCombatsOkClick(object sender, EventArgs e)
        {
            InfoForCombatTable();
            view.CombatsTable = combats;
        }

        private void onPlayerSaveClick(object sender, EventArgs e)
        {
            if (PlayersValidation())
            {
                ChangeSelectedPlayer();
                service.Save();
                view.SavePlayer = true;
            }
                PlayersErrorsVisible();
            
        }

        private void onTransactionsSaveClick(object sender, EventArgs e)
        {
            if (TransactionsValidation())
            {
                ChangeSelectedTransaction();
                service.Save();
                view.SaveTransaction = true;
            }
            TransactionsErrorsVisible();

        }

        #endregion

        #region Methods

        #region Validation

        #region Players
        private bool PlayersValidation()
        {
            LoginOrPasswordValid(true);
            LoginOrPasswordValid(false);
            ValidEmail();

            return (emailValid && loginValid && passwordValid) ? true : false;
        }

        private void ValidEmail()
        {
            string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";

            string email = view.SelectedPlayer.EMail;

            if (email != string.Empty)
            {
                if (Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase))
                {
                    emailValid = true;
                    view.SelectedPlayer.IsEmaillValid = true;
                }
                else
                {
                    emailValid = false;
                }
            }
            else
            {
                emailValid = true;
                view.SelectedPlayer.EMail = null;
                view.SelectedPlayer.IsEmaillValid = false;
            }
        }

        private void LoginOrPasswordValid(bool isLogin)
        {
            if (isLogin)
            {
                string login = view.SelectedPlayer.Login;
                loginValid = LatinAndNumbersValid(login) ? true : false;
            }
            else
            {
                string password = view.SelectedPlayer.Password;
                passwordValid = LatinAndNumbersValid(password) ? true : false;
            }
        }

        private bool LatinAndNumbersValid(string text)
        {
            string pattern = @"^[a-zA-Z][a-zA-Z0-9-_\.]{1,20}$";
            
            return (Regex.IsMatch(text, pattern, RegexOptions.IgnoreCase)) ? true : false;
        }

        private void PlayersErrorsVisible()
        {
            view.EmailError = !emailValid;
            view.LoginError = !loginValid;
            view.PasswordError = !passwordValid;
        }
        #endregion

        #region Transactions

        private bool TransactionsValidation()
        {
            SumValidation();
            DateValidation();
            return (sumValid && dateValid) ? true : false;
        }
        
        private void DateValidation()
        {
            dateValid = (view.SelectedTransaction.Date == DateTime.MinValue) ? false : true;
        }

        private void SumValidation()
        {
            sumValid = (view.SelectedTransaction.Sum <= 0) ? false : true;
        }

        private void TransactionsErrorsVisible()
        {
            view.DateError = !dateValid;
            view.SumError = !sumValid;
        }

        #endregion

        #endregion

        private void  InfoForPlayerTable()
        {
            switch (view.OutputInfo)
            {
                case Enums.OutputInfoType.PTop:
                    players =  service.Players.GetTopPlayers().ToList();
                    break;

                case Enums.OutputInfoType.PDate:
                    players = service.Players.GetPlayersByRegist().ToList();
                    break;

                case Enums.OutputInfoType.PAlphabet:
                    players = service.Players.GetPlayersByAlphabet().ToList();
                    break;

                case Enums.OutputInfoType.PNumOfComb:
                    players = service.Players.GetPlayersByNumberOfGame().ToList();
                    break;

                case Enums.OutputInfoType.PValidEmail:
                    players = service.Players.GetValidEmailPlayers().ToList();
                    break;
                case Enums.OutputInfoType.PLogin:
                    players = service.Players.GetPlayerByLogin(view.SelectedPlayer.Login).ToList();
                    break;

                default:
                    break;
            }
        }

        private void ChangeSelectedPlayer()
        {
            player = service.Players.GetPlayerById(view.SelectedPlayer.Id);
            player.Login = view.SelectedPlayer.Login;
            player.Password = view.SelectedPlayer.Password;
            player.EMail = view.SelectedPlayer.EMail;
            player.IsEmaillValid = (player.EMail != null) ? true : false;
        }

        private void InfoForTransactionTable()
        {
            switch (view.OutputInfo)
            {
                case Enums.OutputInfoType.TSum:
                    transactions = service.Transactions.GetTransactionsBySum().ToList();
                    break;
                case Enums.OutputInfoType.TDate:
                    transactions = service.Transactions.GetTransactionsByDate().ToList();
                    break;
                case Enums.OutputInfoType.TLogin:
                    transactions = service.Transactions.GetTransactionsByLogin(view.SelectedPlayer.Login).ToList();
                    break;
                default:
                    break;
            }
        }

        private void ChangeSelectedTransaction()
        {
            transaction = service.Transactions.GetTransactionsById(view.SelectedTransaction.Id);
            transaction.Date = view.SelectedTransaction.Date;
            transaction.Sum = view.SelectedTransaction.Sum;
        }

        private void InfoForCombatTable()
        {
            switch (view.OutputInfo)
            {
                case Enums.OutputInfoType.CType:
                    combats = service.Combats.GetCombatsByType().ToList();
                    break;
                case Enums.OutputInfoType.CLogin:
                    combats = service.Combats.GetCombatsByPlayer(view.SelectedPlayer.Login).ToList();
                    break;
                case Enums.OutputInfoType.CDate:
                    combats = service.Combats.GetCombatsByDate().ToList();
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}
