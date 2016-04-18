using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubStatistics.UI.TransactionScene
{
    public interface ITransactionUserControl : IUserControl
    {
        void DrawTransactionsTable(List<Transaction> transactionsList);
        void ChangeCounter(int count);
    }
}
