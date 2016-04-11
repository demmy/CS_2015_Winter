using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_13.Data
{
    public class Transaction : AbstractPlayer
    {
        public virtual Player Player { get; set; }
        public int Sum { get; set; }       
    }
}
