using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_13.Data
{
    public class Player : AbstractPlayer
    {        
        public string Login { get; set; }
        public string Password { get; set; }
        public string EMail { get; set; }        
        public bool EMailValid { get; set; }       
        public virtual List<Transaction> Transactions { get; set; }
        public virtual List<Combat> Combats { get; set; }
        public Player()
        {
            Combats = new List<Combat>();
        }
        public override string ToString()
        {
            return Login;
        }
    }
}
