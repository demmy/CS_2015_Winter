/*
 * Created by Mad Nomad
 * User: Mad Nomad
 * Date: 12.04.2016
 * Time: 5:08
 */
using System;
using System.Collections.Generic;
using LogicLayer.DataObject;

namespace LogicLayer.Interfaces
{
    /// <summary>
    /// Description of IUserTransactionService.
    /// </summary>
    public interface IUserTransactionService
    {
        List<UserTransactionDTO> GetUserTransactions(int userId);
        List<UserTransactionDTO> GetTransactionsByDate(int userId, DateTime date);
        List<UserTransactionDTO> GetLastUserTransactions(int userId, int num);
        List<UserTransactionDTO> GetUserTransactionsDescByMaxSum(int userId);
        void EditUserTransaction(UserTransactionDTO transaction);
        void DeleteUserTransaction(UserTransactionDTO transaction);
    }
}
