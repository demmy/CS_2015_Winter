using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_12
{
    public interface IForest
    {
        bool AddFirTree(IFirTree firTree);
        int WinterIncrease(IFirTree firTree);
        int SummerIncrease(IFirTree firTree);
        int ShowHightFirTree(int year, IFirTree firTree);
        
    }
}
