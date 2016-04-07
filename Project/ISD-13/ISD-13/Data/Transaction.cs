using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_13.Data
{
    public class Transaction
    {
        public int ID { get; set; }
        public Player Player { get; set; }
        public int Sum { get; set; }
    }
}
