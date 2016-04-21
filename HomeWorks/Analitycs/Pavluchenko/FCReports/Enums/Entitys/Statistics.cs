using Enums.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubReports.Data.Entitys
{
    public class Statistics: BaseEntity 
    {
        public int Id { get; set; }
        public int Combats { get; set; }
        public int Wins{ get; set; }
        public int Draws { get; set; }

        public override string ToString()
        {
            return string.Format("W = {0}, D = {1}", Wins, Draws);
        }
    }
}
