/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 11.04.2016
 * Time: 17:15
 */
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DataLayer.EF;
using DataLayer.Entities;
using DataLayer.Interfaces;

namespace DataLayer.Repositories
{
    /// <summary>
    /// Description of UserTransactionRepository.
    /// </summary>
    public class UserTransactionRepository : BaseRepository<UserTransaction>, IUserTransactionRepository
    {
        public UserTransactionRepository(Context db) : base(db) { }

        public int GetLastUsedUserTransactionId()
        {
            if (db.UserTransactions.Any())
            {
                return db.UserTransactions.OrderByDescending(u => u.Id).FirstOrDefault().Id;
            }
            else
            {
                return 0;
            }
        }

        public List<UserTransaction> GetUserTransactions(int userId)
        {
            return db.UserTransactions.Where(u => u.User.Id == userId).ToList();
        }
    }
}
