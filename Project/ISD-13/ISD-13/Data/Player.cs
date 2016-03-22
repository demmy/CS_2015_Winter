using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_13.Data
{
    public class Player
    {
        public int ID { get; set; }
        public string Login { get; set; }
        public string EMail { get; set; }        
        public bool EMailValid { get; set; }
        public DateTime Date { get; set; }
    }
}
