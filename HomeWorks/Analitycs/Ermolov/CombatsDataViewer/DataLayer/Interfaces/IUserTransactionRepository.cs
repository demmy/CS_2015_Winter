/*
 * Created by Mad Nomad
 * User: Mad Nomad
 * Date: 12.04.2016
 * Time: 3:26
 */
using System;
using DataLayer.Entities;
using System.Collections.Generic;

namespace DataLayer.Interfaces
{
    /// <summary>
    /// Description of IUserTransactionRepository.
    /// </summary>
    public interface IUserTransactionRepository : IRepository<UserTransaction>
    {
        int GetLastUsedUserTransactionId();
        List<UserTransaction> GetUserTransactions(int userId);
    }
}
