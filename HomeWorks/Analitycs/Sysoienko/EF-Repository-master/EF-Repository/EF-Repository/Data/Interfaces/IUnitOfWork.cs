using System;
using EF_Repository.Model;
using EF_Repository.Repository;
using EF_Repository.Repository.Interfaces;

namespace EF_Repository.Data.Interfaces
{
 public  interface IUnitOfWork:IDisposable
    {
        IRepository<Player> PlayersRepo { get; }
        IRepository<Combat> CombatsRepo { get; }
        IRepository<HitLog> HitLogsRepo { get; }
        IRepository<Pve> PvesRepo { get; }
        IRepository<Pvp> PvpsRepo { get; }
        IRepository<Transaction> TransactionsRepo { get; }
        void Commit();
    }
}