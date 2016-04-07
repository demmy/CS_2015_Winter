using ISD_13.Data;
using ISD_13.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_13.Repository
{
    class TransactionRepository : ITransactionRepository
    {
        private Context db;
        public TransactionRepository()
        {
            this.db = new Context();
        }
        public IEnumerable<Transaction> TopTenBySum()
        {
            var query = GetList().OrderBy(t => t.Sum).Take(10).ToList();
            return query;
        }

        public IEnumerable<Transaction> GetList()
        {
            return db.Transaction;
        }

        public Transaction Get(int id)
        {
            return db.Transaction.Find(id);
        }

        public void Create(Transaction transaction)
        {
            db.Transaction.Add(transaction);
        }

        public void Update(Transaction transaction)
        {
            db.Entry(transaction).State = EntityState.Modified;
        }

        public void Delate(int id)
        {
            Transaction transaction = db.Transaction.Find(id);
            if (transaction != null)
            {
                db.Transaction.Remove(transaction);
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
