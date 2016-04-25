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
            view.SaveAllTables += SaveAllTables;            
            view.AddNewPlayer += view_AddNewPlayer;
            view.AddNewTransaction += view_AddNewTransaction;
            view.AddNewCombat += view_AddNewCombat;
            view.AddNewHit += view_AddNewHit;
            view.EditTransactionCell += view_EditTransactionCell;
            view.EditCombatCell += view_EditCombatCell;
        }

        void view_LoadAllTables(object sender, EventArgs e)
        {
            LoadPlayerTable();
            LoadTransactionTable();
            LoadCombatTable();
            LoadHitLogTable();
        }
        void SaveAllTables(object sender, EventArgs e)
        {
            SavePlayerTable();
            SaveTransactionTable();
            SaveCombatTable();
            SaveHitLogTable();                       
        }
        
        void view_AddNewPlayer(object sender, EventArgs e)
        {
            proxy.Player.Create(new Player() { Date = DateTime.Now });
            proxy.Save();
            LoadPlayerTable();
        }
        void view_AddNewTransaction(object sender, EventArgs e)
        {
            if (view.SelectedPlayerName != string.Empty)
            {
                proxy.Transaction.Create(new Transaction() { Player = playerList.Where(x => x.Id.ToString() == view.SelectedPlayerId).FirstOrDefault(), Date = DateTime.Now });
            }
            else
            {
                proxy.Transaction.Create(new Transaction() { Date = DateTime.Now });
            }
            proxy.Save();
            LoadTransactionTable();
        }
        void view_AddNewCombat(object sender, EventArgs e)
        {
            if (view.SelectedPlayerName != string.Empty)
            {
                proxy.Combat.Create(new Combat() { FirstPlayer = playerList.Where(x => x.Id.ToString() == view.SelectedPlayerId).FirstOrDefault(), Date = DateTime.Now });
            }
            else
            {
                proxy.Combat.Create(new Combat() { Date = DateTime.Now });
            }
            proxy.Save();
            LoadCombatTable();
        }
        void view_AddNewHit(object sender, EventArgs e)
        {
            if (view.SelectedCombatId != string.Empty)
            {
                proxy.HitLog.Create(new HitLog() { Combat = combatList.Where(x => x.Id.ToString() == view.SelectedCombatId).FirstOrDefault(), Date = DateTime.Now });
            }
            else
            {
                proxy.HitLog.Create(new HitLog() { Combat = null, Date = DateTime.Now });
            }
            proxy.Save();
            LoadHitLogTable();
        }

        void view_EditTransactionCell(object sender, EventArgs e)
        {
            if (playerList.Where(x => x.Login == view.EditPlayerLogin).FirstOrDefault() != null)
            {
                transactionList.Where(x => x.Id.ToString() == view.SelectedTransactionId).FirstOrDefault().Player =
                    playerList.Where(x => x.Login == view.EditPlayerLogin).FirstOrDefault();
            }
            view.TransactionBindingSource = transactionList;
        }
        void view_EditCombatCell(object sender, EventArgs e)
        {
            if (playerList.Where(x => x.Login == view.EditPlayerLogin).FirstOrDefault() != null)
            {
                switch (view.EditCombatColumn)
                {
                    case 2:
                        {
                            combatList.Where(x => x.Id.ToString() == view.SelectedCombatId).FirstOrDefault().FirstPlayer =
                    playerList.Where(x => x.Login == view.EditPlayerLogin).FirstOrDefault();
                            break;
                        }
                    case 3:
                        {
                            combatList.Where(x => x.Id.ToString() == view.SelectedCombatId).FirstOrDefault().SecondPlayer =
                    playerList.Where(x => x.Login == view.EditPlayerLogin).FirstOrDefault();
                            break;
                        }
                    case 4:
                        {
                            combatList.Where(x => x.Id.ToString() == view.SelectedCombatId).FirstOrDefault().Winner =
                    playerList.Where(x => x.Login == view.EditPlayerLogin).FirstOrDefault();
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
            view.CombatBindingSource = combatList;
        }

        private void LoadTransactionTable()
        {
            transactionList = proxy.Transaction.GetAll().ToList();
            if (view.SelectedPlayerName != string.Empty)
            {
                transactionList = proxy.Transaction.FindTransactionsByUserId(int.Parse(view.SelectedPlayerId));
            }
            if (view.TopTenBySummCBStatus && view.SelectedPlayerName != string.Empty)
            {
                transactionList = transactionList.OrderByDescending(x => x.Sum).Take(10).ToList();
            }
            if (view.TopTenBySummCBStatus && view.SelectedPlayerName == string.Empty)
            {
                transactionList = proxy.Transaction.TopTenTransactionsBySum();
            }
            view.TransactionBindingSource = transactionList;
        }
        private void LoadCombatTable()
        {
            combatList = proxy.Combat.GetAll().ToList();
            if (view.SelectedPlayerName != string.Empty)
            {
                combatList = proxy.Combat.FindCombatsByUserId(int.Parse(view.SelectedPlayerId));
            }
            view.CombatBindingSource = combatList;
        }
        private void LoadHitLogTable()
        {
            hitLogList = proxy.HitLog.GetAll().ToList();
            if (view.SelectedCombat != string.Empty)
            {
                hitLogList = proxy.HitLog.FindHitLogsByCombatId(view.SelectedCombatId);
            }
            view.HitLogBindingSource = hitLogList;
        }
        private void LoadPlayerTable()
        {
            playerList = proxy.Player.GetAll().ToList();
            if (view.ValidEmailCBStatus)
            {
                playerList = proxy.Player.FindUsersByValidEmail().ToList();
            }
            view.PlayerBindingSource = playerList;
        }
        private void SavePlayerTable()
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
        }
        private void SaveTransactionTable()
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
        }
        private void SaveCombatTable()
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
        }
        private void SaveHitLogTable()
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
        }
    }
}
