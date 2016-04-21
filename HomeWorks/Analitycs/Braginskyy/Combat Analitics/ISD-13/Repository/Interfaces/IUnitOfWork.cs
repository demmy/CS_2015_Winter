using ISD_13.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_13.Repository.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IPlayerRepository Player { get; }
        ICombatRepository Combat { get; }
        IHitLogRepository HitLog { get; }
        ITransactionRepository Transaction { get; }
        void Save();
    }
}
