using Enums;
using FightClubReports.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubReports.Interfaces
{
    public interface IView
    {
        OutputInfoType OutputInfo { get; }
        ViewInfoType InfoType { get; }
        Player SelectedPlayer { get; }
        Transaction SelectedTransaction { get; }
        bool EmailError { set; }
        bool LoginError {set; }
        bool PasswordError { set; }
        bool DateError { set; }

        bool SavePlayer{set ; }
        bool SaveTransaction { set; }
        event EventHandler playersOkClick;
        event EventHandler transactionsOkClick;
        event EventHandler combatsOkClick;
        event EventHandler playerSaveClick;
        event EventHandler transactionSaveClick;
        object PlayerTable {  set; }
        object TransactionsTable { set; }
        object CombatsTable { set; }
    }
}
