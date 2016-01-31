using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = { 11, 5, 7, 9, 4, 15, 3, 22 };
            Console.WriteLine("\nBefore sort");
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write("{0},", mass[i]);
            }
            Console.WriteLine();
            mass.MySort();
            Console.WriteLine("\nAfter sort");
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write("{0},", mass[i]);
            }
            Console.WriteLine();
            MySortArray.MySort(mass, false);
            Console.WriteLine("\nAfter sort with trend");
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write("{0},", mass[i]);
            }
            Console.ReadLine();
        }
    }
}
