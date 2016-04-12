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
            ChangeSelectedPlayer();
            service.Save();
        }

        private void onTransactionsSaveClick(object sender, EventArgs e)
        {
            ChangeSelectedTransaction();
            service.Save();
        }

        #endregion

        #region Methods

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
