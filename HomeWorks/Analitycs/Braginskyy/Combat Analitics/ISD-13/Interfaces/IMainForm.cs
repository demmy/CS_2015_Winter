using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_13.Interfaces
{
    public interface IMainForm
    {
        event EventHandler LoadAllTables;
        event EventHandler SaveInfo;
        event EventHandler FindUserByLogin;
        event EventHandler FindHitLogsByCombatId;
        event EventHandler EditTransactionCell;
        string TransactiomPlayerLogin { get; }
        string TransactionId { get; }
        object PlayerBindingSource { set; }
        object CombatBindingSource { set; }
        object TransactionBindingSource { set; }
        object HitLogBindingSource { set; }
        string SelectedCombat { get; set; }
        string SelectedCombatId { get; set; }
        string SelectedPlayerName { get; set; }
        int SelectedPlayerId { get; set; }
        int SelectedTabIndex { get; }       
        bool ValidEmailCBStatus { get; }        
    }
}
