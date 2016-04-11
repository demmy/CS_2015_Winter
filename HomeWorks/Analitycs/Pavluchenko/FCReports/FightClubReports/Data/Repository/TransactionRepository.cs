using FightClubReports.Data;
using FightClubReports.Entitys;
using FightClubReports.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubReports.Repository
{
    public class TransactionRepository : BaseRepository<Transaction>, ITransactionRepository
    {

        public TransactionRepository(Context db) : base(db)
        {
            
        }

        public IEnumerable<Transaction> GetTransactionsByDate()
        {
            return db.Transactions
                .OrderBy(d => d.Date)
                .ToList();
        }

        public IEnumerable<Transaction> GetTransactionsByLogin(string login)
        {
            return db.Transactions
                .Where(p => p.Player.Login == login)
                .ToList();
        }

        public IEnumerable<Transaction> GetTransactionsBySum()
        {
            return db.Transactions
                .OrderByDescending(s => s.Sum)
                .ToList();
        }
    }
}
