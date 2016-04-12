/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 11.04.2016
 * Time: 17:36
 */
using System;
using DataLayer.EF;
using DataLayer.Entities;
using DataLayer.Interfaces;

namespace DataLayer.Repositories
{
    /// <summary>
    /// Description of UnitOfWork.
    /// </summary>
    public class ServiceRepository : IServiceRepository
    {
        private Context db;
        private IUserRepository userRepository;
        private IUserTransactionRepository userTransactionRepository;
        private IPlayerRepository playerRepository;
        private IBattleRepository battleRepository;
        private IBattleLogRepository battleLogRepository;
        
        public ServiceRepository()
        {
            this.db = new Context();
        }

        public IUserRepository Users
        {
            get
            {
                if (userRepository == null)
                {
                    userRepository = new UserRepository(db);
                }
                return userRepository;
            }
        }

        public IUserTransactionRepository UserTransactions
        {
            get
            {
                if (userTransactionRepository == null)
                {
                    userTransactionRepository = new UserTransactionRepository(db);
                }
                return userTransactionRepository;
            }
        }

        public IPlayerRepository Players
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

        public IBattleRepository Battles
        {
            get
            {
                if (battleRepository == null)
                {
                    battleRepository = new BattleRepository(db);
                }
                return battleRepository;
            }
        }

        public IBattleLogRepository BattleLogs
        {
            get
            {
                if (battleLogRepository == null)
                {
                    battleLogRepository = new BattleLogRepository(db);
                }
                return battleLogRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
