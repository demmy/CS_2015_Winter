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
            CarCollection<string> car1 = new CarCollection<string>();
            car1.Add("Mazda", "2014");
            car1.Add("Opel", "2010");
            car1.Add("Toyota", "1999");
            car1.Add("Ford", "2016");
            Console.WriteLine(car1.Count);
            for (int i = 0; i < car1.Count; i++) 
            {
                Console.WriteLine(car1[i]);
            }
            Console.ReadLine();
        }
    }
}
