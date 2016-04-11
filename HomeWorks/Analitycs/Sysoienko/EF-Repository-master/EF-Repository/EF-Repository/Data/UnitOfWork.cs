using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Repository.Data.Interfaces;
using EF_Repository.Repository;
using EF_Repository.Repository.Interfaces;

namespace EF_Repository.Data
{
    class UnitOfWork:IUnitOfWork
    {
        private IPlayersRepository _playersRepo;
        private ICombatsRepository _combatsRepo;
        private ITransactionsRepository _transactionsRepo;
        private IHitLogsRepository _hitLogsRepo;
        private IPvesRepository _pvesRepo;
        private IPvpsRepository _pvpsRepo;

        private readonly EfContext _entity;

        public UnitOfWork()
        {
            _entity = new EfContext();
        }
        public UnitOfWork(EfContext context)
        {
            _entity = context;
        }
        public IPlayersRepository PlayersRepo
        {
            get { return (_playersRepo ?? (_playersRepo = new PlayersRepository(_entity))); }
        }
        public ICombatsRepository CombatsRepo
        {
            get { return (_combatsRepo ?? (_combatsRepo = new CombatsRepository(_entity))); }
        }
        public IPvesRepository PvesRepo
        {
            get { return (_pvesRepo ?? (_pvesRepo = new PvesRepository(_entity))); }
        }
        public IPvpsRepository PvpsRepo
        {
            get { return (_pvpsRepo ?? (_pvpsRepo = new PvpsRepository(_entity))); }
        }
        public ITransactionsRepository TransactionsRepo
        {
            get { return (_transactionsRepo ?? (_transactionsRepo = new TransactionsRepository(_entity))); }
        }
        public IHitLogsRepository HitLogsRepo
        {
            get { return (_hitLogsRepo ?? (_hitLogsRepo = new HitLogsRepository(_entity))); }
        }
        public void Save()
        {
            _entity.SaveChanges();
        }

        public void Dispose()
        {
           _entity.Dispose();
        }
    }
}
