using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameCore;

namespace Combats
{
    public interface IScore
    {
        string NamePlayer { get; }
        bool LoadStatus { get; set; }
        void ShowTableStat(Result[] table);
        void StartWindow();       
    }
}
