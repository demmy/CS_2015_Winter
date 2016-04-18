using FightClubStatistics.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubStatistics.UI.TransactionScene
{
    class TransactionPresenter
    {
        private ITransactionUserControl view;
        private List<Transaction> transactionsList;
        private ITransactionRepository transactionsRepository;
        private IUserRepository usersRepository;
        public List<User> usersList;
        private int showingCount;

        public TransactionPresenter(ITransactionUserControl ctrl)
        {
            view = ctrl;
            transactionsRepository = new TransactionRepository();
            transactionsList = new List<Transaction>();
            transactionsList = transactionsRepository.GetAll().ToList();
            usersRepository = new UserRepository(new MyContext());
            usersList = usersRepository.GetAll().ToList();
            showingCount = transactionsList.Count;

            view.DrawTransactionsTable(transactionsList);
        }

        public void TurnEditTransactionControl(int id)
        {
            view.SwitchScene(Scene.EditTransactionScene, transactionsRepository.Get(id));
        }

        public void EditTransaction(Transaction transaction)
        {
            transactionsRepository.Update(transaction);
            UpdateTransactionsList();
        }

        public void DeleteTransaction(int id)
        {
            transactionsRepository.Delete(id);
            UpdateTransactionsList();
        }

        public void TurnAddTransactionControl()
        {
            view.SwitchScene(Scene.EditTransactionScene);
        }

        public void AddTransaction(Transaction newTransaction)
        {
            transactionsRepository.Add(newTransaction);
            UpdateTransactionsList();
        }

        private void UpdateTransactionsList()
        {
            transactionsList = transactionsRepository.GetAll().ToList();
            view.DrawTransactionsTable(transactionsList);
        }

        public void ChangeTransactionsShowingCount(int count)
        {
            showingCount = count;
            if (showingCount <= transactionsRepository.GetAll().Count())
            {
                view.DrawTransactionsTable(transactionsList.Take(showingCount).ToList());
            }
            else
            {

            }
        }

        public void ShowAllTransactions()
        {
            UpdateTransactionsList();
        }
    }
}
