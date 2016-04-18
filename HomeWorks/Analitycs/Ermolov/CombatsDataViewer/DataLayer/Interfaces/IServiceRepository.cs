/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 11.04.2016
 * Time: 15:57
 */
using System;
using DataLayer.Entities;

namespace DataLayer.Interfaces
{
    /// <summary>
    /// Description of IServiceRepository.
    /// </summary>
    public interface IServiceRepository : IDisposable
    {
        IUserRepository Users { get;}
        IUserTransactionRepository UserTransactions { get;}
        IPlayerRepository Players { get;}
        IBattleRepository Battles { get;}
        IBattleLogRepository BattleLogs { get;}
        void Save();
    }
}
