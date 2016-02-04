using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        delegate int MyDelegate(int x, int y, int z);
        static void Main(string[] args)
        {
            int average;
            MyDelegate Exampl = delegate(int x, int y, int z) {return (x+y+z)/3 ;};
            average = Exampl(3,6,8);
            Console.WriteLine(average);
            Console.ReadLine();
        }
    }
}
