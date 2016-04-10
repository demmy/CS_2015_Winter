using System;
using EF_Repository.Repository;
using EF_Repository.Repository.Interfaces;

namespace EF_Repository.Data.Interfaces
{
    interface IUnitOfWork:IDisposable
    {
        IPlayersRepository PlayersRepo { get; }
        ICombatsRepository CombatsRepo { get; }
        IPvesRepository PvesRepo { get; }
        IPvpsRepository PvpsRepo { get; }
        IHitLogsRepository HitLogsRepo { get; }
        ITransactionsRepository TransactionsRepo { get; }
        void Save();
    }
}