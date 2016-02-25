using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class SecondInheritor : Printer
    {
        public override void Print (string value)
        {
            Console.ForegroundColor = ConsoleColor.Green; 
            Console.WriteLine(value);
            Console.ResetColor();
        }
    }
}
