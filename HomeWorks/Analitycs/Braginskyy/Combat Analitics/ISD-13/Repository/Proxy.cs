using ISD_13.Data;
using ISD_13.Repository;
using ISD_13.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_13.Repository
{
    class Proxy : IProxy
    {
        private readonly Context db;
        private IPlayerRepository playerRepository;
        private ICombatRepository combatRepository;
        private IHitLogRepository hitLogRepository;
        private ITransactionRepository transactionRepository;
        public Proxy()
        {
            this.db = new Context();
        }
        public IPlayerRepository Player
        {
            get 
            {
                if (playerRepository == null)
                {
                    playerRepository = new PlayerRepository(db);
                }
                return playerRepository;
            }
        }

        public ICombatRepository Combat
        {
            get
            {
                if (combatRepository == null)
                {
                    combatRepository = new CombatRepository(db);
                }
                return combatRepository;
            }
        }

        public IHitLogRepository HitLog
        {
            get
            {
                if (hitLogRepository == null)
                {
                    hitLogRepository = new HitLogRepository(db);
                }
                return hitLogRepository;
            }
        }

        public ITransactionRepository Transaction
        {
            get 
            {
                if (transactionRepository == null)
                {
                    transactionRepository = new TransactionRepository(db);
                }
                return transactionRepository;
            }
        }       

        public void Dispose()
        {
            db.Dispose();
        }
        public void Save()
        {
            db.SaveChanges();
        }
    }
}
