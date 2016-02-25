using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook book1 = new Notebook("SAMSUNG", "SamsungElectonics", 320);
            book1.PrintInfo();
            Console.ReadLine();
        }
    }
}
