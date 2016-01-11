using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class RedPrinter : Printer
    {
        override public void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            base.Print(value);
            Console.ResetColor();
        }
    }
}
