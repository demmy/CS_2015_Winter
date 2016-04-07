using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_12
{
    class Program
    {
        static void Main(string[] args)
        {
            IForest myForest = new Forest();
            IFirTree myFirTree = new FirTree();
            myForest.AddFirTree(myFirTree);
            Console.WriteLine("Зимой елка приросла на {0} см", myForest.WinterIncrease(myFirTree));            
            Console.WriteLine("Летом елка приросла на {0} см", myForest.SummerIncrease(myFirTree));                        
            Console.WriteLine("Высота елки равна {0} см", myForest.ShowHightFirTree(4, myFirTree)); 
        }
    }
}
