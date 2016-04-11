using ISD_13.Data;
using ISD_13.Interfaces;
using ISD_13.Repository;
using ISD_13.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ISD_13
{
    public class MainPresenter
    {
        private readonly IMainForm view;
        private readonly IProxy proxy;
        private List<Player> playerList;
        private List<Transaction> transactionList;
        private List<Combat> combatList;
        private List<HitLog> hitLogList;
        public MainPresenter(IMainForm view)
        {
            this.view = view;
            this.proxy = new Proxy();
            view.LoadAllTables += view_LoadAllTables;
            view.SaveInfo += SaveInfo;
            view.FindUserByLogin += view_FindPlayerByName;
            view.FindHitLogsByCombatId += view_FindHitLogsByCombatId;
            view.EditTransactionCell += view_EditTransactionCell;
        }

        void view_EditTransactionCell(object sender, EventArgs e)
        {
            if (playerList.Where(x => x.Login == view.TransactiomPlayerLogin).FirstOrDefault() != null)
            {
                transactionList.Where(x => x.Id.ToString() == view.TransactionId).FirstOrDefault().Player =
                    playerList.Where(x => x.Login == view.TransactiomPlayerLogin).FirstOrDefault();
            }
        }

        void view_FindHitLogsByCombatId(object sender, EventArgs e)
        {
            if (proxy.HitLog.FindHitLogsByCombatId(view.SelectedCombat) != null)
            {
                view.SelectedCombatId = view.SelectedCombat;
            }
        }

        void view_FindPlayerByName(object sender, EventArgs e)
        {
            if (proxy.Player.FindUserByLogin(view.SelectedPlayerName) != null)
            {
                view.SelectedPlayerId = proxy.Player.FindUserByLogin(view.SelectedPlayerName).Id;
            }
        }

        void SaveInfo(object sender, EventArgs e)
        {
            switch (view.SelectedTabIndex)
            {
                case 0:
                    {
                        proxy.Player.AddOrUpdate(playerList);
                        if (view.ValidEmailCBStatus)
                        {
                            proxy.Player.DeleteWhithFilterByValidEmail(playerList);
                        }
                        else
                        {
                            proxy.Player.Delete(playerList);
                        }
                        proxy.Save();
                        LoadPlayerTable();
                        break;
                    }
                case 1:
                    {
                        proxy.Transaction.AddOrUpdate(transactionList);
                        if (view.SelectedPlayerName != string.Empty)
                        {
                            proxy.Transaction.DeleteWhithSelectedPlayer(transactionList);
                        }
                        else
                        {
                            proxy.Transaction.Delete(transactionList);
                        }
                        proxy.Save();
                        LoadTransactionTable();
                        break;
                    }
                case 2:
                    {
                        proxy.Combat.AddOrUpdate(combatList);
                        if (view.SelectedPlayerName != string.Empty)
                        {
                            proxy.Combat.DeleteWhithSelectedPlayer(combatList);
                        }
                        else
                        {
                            proxy.Combat.Delete(combatList);
                        }
                        proxy.Save();
                        LoadCombatTable();
                        break;
                    }
                case 3:
                    {
                        proxy.HitLog.AddOrUpdate(hitLogList);
                        if (view.SelectedCombat != string.Empty)
                        {
                            proxy.HitLog.DeleteWhithSelectedCombat(hitLogList);
                        }
                        else
                        {
                            proxy.HitLog.Delete(hitLogList);
                        }
                        proxy.Save();
                        LoadHitLogTable();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        void view_LoadAllTables(object sender, EventArgs e)
        {
            LoadPlayerTable();
            LoadTransactionTable();
            LoadCombatTable();
            LoadHitLogTable();
        }
        public void LoadTransactionTable()
        {
            transactionList = proxy.Transaction.GetAll().ToList();
            if (view.SelectedPlayerName != "")
            {
                transactionList = proxy.Transaction.FindTransactionsByUserId(view.SelectedPlayerId);
            }
            view.TransactionBindingSource = transactionList;
        }
        public void LoadCombatTable()
        {
            combatList = proxy.Combat.GetAll().ToList();
            if (view.SelectedPlayerName != "")
            {
                combatList = proxy.Combat.FindCombatsByUserId(view.SelectedPlayerId);
            }
            view.CombatBindingSource = combatList;

        }
        public void LoadHitLogTable()
        {
            hitLogList = proxy.HitLog.GetAll().ToList();
            if (view.SelectedCombat != "")
            {
                hitLogList = proxy.HitLog.FindHitLogsByCombatId(view.SelectedCombatId);
            }
            view.HitLogBindingSource = hitLogList;
        }
        public void LoadPlayerTable()
        {
            playerList = proxy.Player.GetAll().ToList();
            if (view.ValidEmailCBStatus)
            {
                playerList = proxy.Player.FindUsersByValidEmail().ToList();
            }
            view.PlayerBindingSource = playerList;
        }
    }
}
