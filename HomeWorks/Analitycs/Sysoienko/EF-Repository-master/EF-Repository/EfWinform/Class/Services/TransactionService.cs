using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfWinform.Class.Services
{
    class TransactionService : Service
    {
        public override Array Get()
        {
            var transactions = (from p in UnitOfWork.TransactionsRepo.GetAll()
                                select new { p.TransactId, p.Sum, p.Date }).ToArray();
            return transactions;
        }
        public override void DeleteById(int id)
        {
            throw new NotImplementedException();
        }
        public Array TopTransactionsBySum()
        {
            var transactions = (from p in UnitOfWork.TransactionsRepo.GetAll()
                                orderby p.Sum descending
                                select new { p.TransactId, p.PlayerId, p.Sum, p.Date }).
                Take(3).ToArray();
            return transactions;
        }
        public Array TransactionsOrderByDate()
        {
            var transactions = (from p in UnitOfWork.TransactionsRepo.GetAll()
                                orderby p.Date descending
                                select new { p.PlayerId, p.Sum, p.Date }).ToArray();
            return transactions;
        }
    }

}
