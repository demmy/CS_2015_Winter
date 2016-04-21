using System;

namespace EfWinform.Interface
{
    public interface IRatingForm
    {
        event EventHandler Pves;
        event EventHandler Pvps;
        event EventHandler Winners;
        event EventHandler ShowCombatsGrid;
        event EventHandler ShowPlayersGrid;
        event EventHandler ShowTransactionsGrid;
        event EventHandler ShowHitLogsGrid;
        event EventHandler PlayersWithValidEmails;
        event EventHandler TopPlayersByLongestPassword;
        event EventHandler PlayersOrderByDate;
        event EventHandler TopTransactionsBySum;
        event EventHandler TransactionsOrderByDate;
        object PlayersGrid { set; }
        object CombatsGrid { set; }
        object TransactionsGrid { set; }
        object  HitLogsGrid { set; }
    }
}