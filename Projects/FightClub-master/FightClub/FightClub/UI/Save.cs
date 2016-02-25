using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
    [Serializable]
    class Save : IComparable
    {
       public string Name { get; set; }
       public int Win { get; set; }
       public int CompareTo(object obj)
       {
           Save saver = (Save)obj;
           return this.Name.CompareTo(saver.Name);
       }
    }
}
