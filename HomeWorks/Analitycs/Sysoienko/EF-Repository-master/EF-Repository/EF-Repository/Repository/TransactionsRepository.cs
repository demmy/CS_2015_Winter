using System;
using System.Linq;
using EF_Repository.Data;
using EF_Repository.Model;
using EF_Repository.Repository.Interfaces;

namespace EF_Repository.Repository
{
    class TransactionsRepository:  ITransactionsRepository,IDisposable
    {
        private readonly EfContext _entity;
        public TransactionsRepository(EfContext entity)
        {
            _entity = entity;
        }
        public void Add(Transcation entity)
        {
            _entity.Transactions.Add(entity);
        }
        public void Delete(Transcation entity)
        {
            _entity.Transactions.Remove(entity);
        }
        public Transcation[] GetTranscations()
        {
            return _entity.Transactions.ToArray();
        }
        public void SaveChanges()
        {
            _entity.SaveChanges();
        }
        public void Dispose()
        {
            if (_entity != null)
            {
                _entity.Dispose();
            }
        }
    }
}
