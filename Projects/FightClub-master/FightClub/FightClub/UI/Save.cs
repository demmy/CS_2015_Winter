using System;

namespace FightClub.UI
{
    [Serializable]
    class Save : IComparable
    {
       public string Name { get; set; }
       public int Win { get; set; }
       public int CompareTo(object obj)
       {
           Save saver = (Save)obj;
           return String.Compare(this.Name, saver.Name, StringComparison.Ordinal);
       }
    }
}
