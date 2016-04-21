using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_13.Data
{
    public enum BodyPart { Head = 1, Body = 2, Legs = 3 };
    public class HitLog : AbstractPlayer
    {
        public int HitValue { get; set; }
        public BodyPart Part { get; set; }
        public int Result { get; set; }        
        public virtual Combat Combat { get; set; }
    }
}
