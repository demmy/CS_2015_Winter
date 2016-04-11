using Enums.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubReports.Entitys
{
    public class Transaction : BaseEntity
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public virtual Player Player { get; set; } 
        public decimal Sum { get; set; }
    }
}
