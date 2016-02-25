using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            int i = 0;
            Console.WriteLine("Enter your string");
            s = Console.ReadLine();
            Console.WriteLine("Enter the number of color");
            Console.WriteLine("1 - Green");
            Console.WriteLine("2 - Blue");
            Console.WriteLine("3 - Magenta");
            Console.WriteLine("4 - Yellow");
            i = Helper.InputValidationInt();
            MonitorColor.Print(s,i);
            Console.ReadLine();
        }
    }
}
