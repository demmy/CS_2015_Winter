using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forest
{
    class Program
    {
        static void Main(string[] args)
        {
            MyForest forest = new MyForest();
            forest.Trees[0].Grow();
            forest.Trees[0].DisplayTree();
            Console.ReadLine();
        }
    }
}
