using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubReports.Repository.Interfaces
{
    public interface IServiceRepository
    {
        IPlayerRepository Players { get; }
        ICombatRepository Combats { get; }
        ITransactionRepository Transactions { get; }
        void Dispose();
        void Save();

    }
}
