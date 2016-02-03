using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Helper
    {
        //Method checks input, until is entered int.
        public static int InputValidationInt()
        {
            string s = "";
            int i = 0;
            do
            {
                s = Console.ReadLine();
            }
            while (!int.TryParse(s, out i));
            return i;
        }
        //Method checks input, until is entered double.
        public static double InputValidationDouble()
        {
            string s = "";
            double d = 0;
            do
            {
                s = Console.ReadLine();
            }
            while (!double.TryParse(s, out d));
            return d;
        }
    }
}
