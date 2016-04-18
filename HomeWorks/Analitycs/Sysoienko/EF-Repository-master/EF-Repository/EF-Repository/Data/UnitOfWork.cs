using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Repository.Data.Interfaces;
using EF_Repository.Model;
using EF_Repository.Repository;
using EF_Repository.Repository.Interfaces;

namespace EF_Repository.Data
{
   public class UnitOfWork:IUnitOfWork, IDisposable
    {
        private DbContext _DbContext = null;
        private bool _Disposed = false;

        private IRepository<Player> _PlayersRepo = null;
        private IRepository<Combat> _CombatsRepo = null;
        private IRepository<HitLog> _HitLogsRepo = null;
        private IRepository<Transaction> _TransactionsRepo = null;
        private IRepository<Pve> _PvesRepo = null;
        private IRepository<Pvp> _PvpsRepo = null;

        public UnitOfWork(DbContext context)
        {
            _DbContext = context;
        }
        public UnitOfWork()
        {
            _DbContext = new EfContext();
        }

        public IRepository<Player> PlayersRepo
        {
            get { 
            if(_PlayersRepo == null)
                _PlayersRepo = new Repository<Player>(_DbContext);
            return _PlayersRepo;
            }
        }

        public IRepository<Combat> CombatsRepo
        {
            get
            {
                if (_CombatsRepo == null)
                    _CombatsRepo = new Repository<Combat>(_DbContext);
                return _CombatsRepo;
            }
        }

        public IRepository<HitLog> HitLogsRepo
        {
            get
            {
                if (_HitLogsRepo == null)
                    _HitLogsRepo = new Repository<HitLog>(_DbContext);
                return _HitLogsRepo;
            }
        }

        public IRepository<Transaction> TransactionsRepo
        {
            get
            {
                if (_TransactionsRepo == null)
                    _TransactionsRepo = new Repository<Transaction>(_DbContext);
                return _TransactionsRepo;
            }
        }
        public IRepository<Pve> PvesRepo
        {
            get
            {
                if (_PvesRepo == null)
                    _PvesRepo = new Repository<Pve>(_DbContext);
                return _PvesRepo;
            }
        }
        public IRepository<Pvp> PvpsRepo
        {
            get
            {
                if (_PvpsRepo == null)
                    _PvpsRepo = new Repository<Pvp>(_DbContext);
                return _PvpsRepo;
            }
        }
        #region Public Methods
        public virtual void Commit()
        {
            _DbContext.SaveChanges();
        }

        #endregion

        #region Protected Methods
        protected virtual void Dispose(bool disposing)
        {
            if (!this._Disposed)
            {
                if (disposing)
                    _DbContext.Dispose();
            }
            this._Disposed = true;
        }

        #endregion

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
