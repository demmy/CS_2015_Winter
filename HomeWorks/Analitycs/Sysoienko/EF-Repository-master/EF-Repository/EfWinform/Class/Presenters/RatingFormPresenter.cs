using System;
using EfWinform.Class.Services;
using EfWinform.Interface;

namespace EfWinform.Class.Presenters
{
    class RatingFormPresenter
    {
        private readonly IRatingForm _view;
        private Service _service;
        public RatingFormPresenter(IRatingForm view)
        {
            _view = view;
            _view.ShowPlayersGrid += _view_ShowPlayersGrid;
            _view.ShowCombatsGrid += _view_ShowCombatsGrid;
            _view.ShowHitLogsGrid += _view_ShowHitLogsGrid;
            _view.ShowTransactionsGrid += _view_ShowTransactionsGrid;
            _view.Pves += _view_Pves;
            _view.Pvps += _view_Pvps;
            _view.Winners += _view_Winners;
            _view.PlayersOrderByDate += _view_PlayersOrderByDate;
            _view.PlayersWithValidEmails += _view_PlayersWithValidEmails;
            _view.TopPlayersByLongestPassword += _view_TopPlayersByLongestPassword;
            _view.TopTransactionsBySum += _view_TopTransactionsBySum;
            _view.TransactionsOrderByDate += _view_TransactionsOrderByDate;
        }

        void _view_TransactionsOrderByDate(object sender, EventArgs e)
        {
            var service = new TransactionService();
            var transactions = service.TransactionsOrderByDate();
            _view.TransactionsGrid = transactions;
        }

        void _view_TopTransactionsBySum(object sender, EventArgs e)
        {
            var service = new TransactionService();
            var transactions = service.TopTransactionsBySum();
            _view.TransactionsGrid = transactions;
        }

        void _view_TopPlayersByLongestPassword(object sender, EventArgs e)
        {
            var service = new PlayerService();
            var players = service.TopPlayersByLongestPassword();
            _view.PlayersGrid = players;
        }

        void _view_PlayersWithValidEmails(object sender, EventArgs e)
        {
            var service = new PlayerService();
            var players = service.PlayersWithValidEmails();
            _view.PlayersGrid = players;
        }

        void _view_PlayersOrderByDate(object sender, EventArgs e)
        {
            var service = new PlayerService();
            var players = service.PlayersOrderByDate();
            _view.PlayersGrid = players;
        }

        void _view_Winners(object sender, EventArgs e)
        {
            var service = new CombatService();
            var combats = service.Winners();
            _view.CombatsGrid = combats;
        }

        void _view_Pvps(object sender, EventArgs e)
        {
            var service = new PvpService();
            var pvps = service.Pvps();
            _view.CombatsGrid = pvps;
        }

        void _view_Pves(object sender, EventArgs e)
        {
            var service = new PveService();
            var pves = service.Pves();
            _view.CombatsGrid = pves;
        }
        void _view_ShowTransactionsGrid(object sender, EventArgs e)
        {
            _service = new TransactionService();
            var  transactions = _service.Get();
            _view.TransactionsGrid = transactions;
        }
        void _view_ShowHitLogsGrid(object sender, EventArgs e)
        {
            _service = new HitLogService();
            var hitlogs = _service.Get();
            _view.HitLogsGrid = hitlogs;
        }
        void _view_ShowCombatsGrid(object sender, EventArgs e)
        {
            _service = new CombatService();
            var combats = _service.Get();
            _view.CombatsGrid = combats;
        }
        void _view_ShowPlayersGrid(object sender, EventArgs e)
        {
            _service = new PlayerService();
            var players = _service.Get();
            _view.PlayersGrid = players;
        }
    }
}
