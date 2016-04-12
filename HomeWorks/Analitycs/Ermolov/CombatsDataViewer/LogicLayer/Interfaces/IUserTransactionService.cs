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
        IEnumerable<UserTransactionDTO> GetUserTransactions(int userId);
        IEnumerable<UserTransactionDTO> GetTransactionsByDate(DateTime date);
        IEnumerable<UserTransactionDTO> GetLastTransactions(int num);
    }
}
