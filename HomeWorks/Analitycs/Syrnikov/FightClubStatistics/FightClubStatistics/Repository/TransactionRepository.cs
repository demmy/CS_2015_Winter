using FightClubStatistics.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubStatistics
{
    class TransactionRepository : AbstractRepository, IRepository<Transaction> , ITransactionRepository
    {
        public void Add(Transaction item)
        {
            context.Transactions.Add(item);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            Transaction transaction = context.Transactions.Find(id);
            if (transaction != null)
            {
                context.Transactions.Remove(transaction);
                context.SaveChanges();
            }
        }

        public Transaction Get(int id)
        {
            return context.Transactions.Find(id);
        }

        public IEnumerable<Transaction> GetAll()
        {
            return context.Transactions;
        }

        public void Update(Transaction item)
        {
            Transaction oldTranasction;
            oldTranasction = context.Transactions.Where(x => x.TransactionId == item.TransactionId).FirstOrDefault();
            oldTranasction.User = new User
            {
                Login = item.User.Login,
                Password = item.User.Password,
                EMail = item.User.EMail,
                IsEmailValid = item.User.IsEmailValid,
                CreationDate = item.User.CreationDate,
                PlayerData = new Player
                {
                    Name = item.User.PlayerData.Name,
                    Exp = item.User.PlayerData.Exp
                }
            };
            oldTranasction.Sum = item.Sum;
            oldTranasction.Date = item.Date;

            context.SaveChanges();
        }
    }
}
