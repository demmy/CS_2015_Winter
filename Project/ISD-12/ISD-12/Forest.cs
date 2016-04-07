using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_12
{
    public class Forest : IForest
    {
        IFirTree firTree = null;
        public bool AddFirTree(IFirTree firTree)
        {
            this.firTree = firTree;
            if (firTree!= null) { return true; }
            else { return false; }
        }
        public int WinterIncrease(IFirTree firTree)
        {
            int winterIncrease = 1;
            firTree.GrowFirTree(winterIncrease);            
            return winterIncrease; 
        }
        public int SummerIncrease(IFirTree firTree)
        {
            int summerIncrease = 5;
            firTree.GrowFirTree(summerIncrease);            
            return summerIncrease; 
        }
        public int ShowHightFirTree(int year, IFirTree firTree)
        {           
            return (WinterIncrease(firTree)+SummerIncrease(firTree)) * year;
        }
    }
}
