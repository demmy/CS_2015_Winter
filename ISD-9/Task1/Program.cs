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
            int[] mass = new int[100];       
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = i*3;
            }        
            MyClass m = new MyClass();
            foreach (int i in m.GetMass(mass))
            {
                Console.WriteLine(i); 
            }
            Console.ReadLine();
        }        
    }
}
