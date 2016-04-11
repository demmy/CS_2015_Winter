using ISD_13.Data;
using ISD_13.Repository.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_13.Repository
{
    public class TransactionRepository : Repository<Transaction>, ITransactionRepository
    {
        public TransactionRepository(Context db)
            : base(db)
        {
        }

        public List<Transaction> FindTransactionsByUserId(int id)
        {
            var query = db.Transactions.Where(t => t.Player.Id == id).ToList();
            return query;
        }
        

        public void Delete(List<Transaction> transactionList)
        {
            var query = GetAll().Except(transactionList);
            foreach (var t in query)
            {
                Delete(t.Id);
            }
        }
        public void DeleteWhithSelectedPlayer(List<Transaction> transactionList)
        {
            foreach (Transaction t in transactionList)
            {
                var query = GetAll().Where(x => x.Player == t.Player).Except(transactionList);
                foreach (var d in query)
                {
                    Delete(d.Id);
                }
            }
        }
    }
}
