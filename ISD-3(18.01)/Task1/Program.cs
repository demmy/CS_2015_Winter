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
            Printer p1 = new Printer();
            p1.Print("This is a base printer");
            Printer p2 = new RedPrinter();
            p2.Print("This is a RED printer");
            Printer p3 = new BluePrinter();
            p3.Print("This is a BLUE printer");
            Printer p4 = new GreenPrinter();
            p4.Print("This is a GREEN printer");
            Console.ReadKey();
        }
    }
}
