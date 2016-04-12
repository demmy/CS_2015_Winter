using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_13.Interfaces
{
    public interface IMainForm
    {
        event EventHandler AddNewPlayer;
        event EventHandler AddNewTransaction;
        event EventHandler AddNewCombat;
        event EventHandler AddNewHit;
        event EventHandler LoadAllTables;
        event EventHandler SaveInfo;
        event EventHandler EditTransactionCell;
        event EventHandler EditCombatCell;
        event EventHandler FindUserByLogin;

        object PlayerBindingSource { set; }
        object CombatBindingSource { set; }
        object TransactionBindingSource { set; }
        object HitLogBindingSource { set; }

        string SelectedPlayerId { get; set; }
        string SelectedTransactionId { get; }
        string SelectedCombatId { get; set; }

        int SelectedTabIndex { get; }
        string SelectedPlayerName { get; set; }
        string SelectedCombat { get; set; }

        string EditPlayerLogin { get; }
        int EditCombatColumn { get; }

        bool ValidEmailCBStatus { get; }
    }
}
