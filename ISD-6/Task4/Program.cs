using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = DateTime.MinValue;
            DateTime n = DateTime.Now;
            int t = 0;
            Console.WriteLine("Please insert your date of birth dd/mm/yyyy");
            try
            {
                d = DateTime.Parse(Console.ReadLine());
                t = d.DayOfYear - n.DayOfYear;
                Console.WriteLine(t);
            }
            catch
            {
                Console.WriteLine("Date error");
            }
            Console.ReadLine();
        }
    }
}
