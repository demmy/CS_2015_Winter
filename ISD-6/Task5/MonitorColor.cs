using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    static class MonitorColor
    {
        enum Mycolor { Green = 1, Blue, Magenta, Yellow }
        public static void Print(string stroka, int color)
        {
            switch (color)
            {
                case (int)Mycolor.Green:
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    }
                case (int)Mycolor.Blue:
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    }
                case (int)Mycolor.Magenta:
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    }
                case (int)Mycolor.Yellow:
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    }
            }
            Console.WriteLine(stroka);
            Console.ResetColor();
        }
    }
}
