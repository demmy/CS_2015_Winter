using DataLayer.Interfaces;
using DataLayer.Repositories;
using LogicLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LogicLayer.DataObject;
using DataLayer.Entities;

namespace LogicLayer.Services
{
    public class UserTransactionService : IUserTransactionService
    {
        IServiceRepository db;
        public UserTransactionService(string connectionService)
        {
            db = new ServiceRepository(connectionService);
        }

        public void AddTransaction(string user, UserTransactionDTO ut)
        {
            UserTransaction utdb = new UserTransaction
            {
                Id = db.UserTransactions.GetLastUsedUserTransactionId() + 1,
                Date = ut.Date,
                User = db.Users.GetUserByLogin(user),
                Description = ut.Description,
                Sum = ut.Sum
            };
            db.UserTransactions.Create(utdb);
            db.Save();
        }

        public List<UserTransactionDTO> GetLastUserTransactions(int userId, int num)
        {
            List<UserTransactionDTO> ut = new List<UserTransactionDTO>();
            List<UserTransaction> utdb = db.UserTransactions.GetAll().Where(u => u.User.Id == userId).ToList();
            if (utdb.Count >= num)
            {
                utdb = utdb.Skip(Math.Max(0, utdb.Count() - num)).ToList();
            }
            foreach (UserTransaction u in utdb)
            {
                ut.Add(new UserTransactionDTO
                       {
                           Id = u.Id,
                           Date = u.Date,
                           Description = u.Description,
                           Sum = u.Sum
                       });
            }
            return ut;
        }

        public List<UserTransactionDTO> GetTransactionsByDate(int userId, DateTime date)
        {
            return GetUserTransactions(userId).OrderBy(x => x.Date).ToList();
        }

        public List<UserTransactionDTO> GetUserTransactions(int userId)
        {
            List<UserTransactionDTO> ut = new List<UserTransactionDTO>();
            List<UserTransaction> utdb = db.UserTransactions.GetUserTransactions(userId);
            foreach (UserTransaction u in utdb)
            {
                ut.Add(new UserTransactionDTO
                       {
                           Id = u.Id,
                           Date = u.Date,
                           Description = u.Description,
                           Sum = u.Sum
                       });
            }
            return ut;
        }

        public List<UserTransactionDTO> GetUserTransactionsDescByMaxSum(int userId)
        {
            return GetUserTransactions(userId).OrderBy(x => x.Sum).Reverse().ToList();
        }
        
        public void EditUserTransaction(UserTransactionDTO transaction)
        {
            UserTransaction utdb = db.UserTransactions.GetById(transaction.Id);
            utdb.Description = transaction.Description;
            utdb.Sum = transaction.Sum;
            db.UserTransactions.Update(utdb);
            db.Save();
        }
        
        public void DeleteUserTransaction(UserTransactionDTO transaction)
        {
            UserTransaction t = db.UserTransactions.GetById(transaction.Id);
            db.UserTransactions.Delete(t);
            db.Save();
        }
    }
}
