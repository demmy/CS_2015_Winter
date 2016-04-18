using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubStatistics
{
    public class Transaction
    {
        public int TransactionId { get; set; } 
        [Required] 
        public virtual User User { get; set; }
        public decimal Sum { get; set; }
        public DateTime Date { get; set; }
    }
}
