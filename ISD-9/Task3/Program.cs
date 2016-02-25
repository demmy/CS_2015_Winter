using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> car = new MyDictionary<string, string>();
            car.Add("Opel","2.2L");
            car.Add("Mazda","1.8D");
            car.Add("Toyota", "1.3");
            car.Add("Ford", "2.0D");
            car.Add("BMW", "4.8D");
            car.Add("Lada", "1.6");
            Console.WriteLine(car.Count);

            foreach (string s in car.GetDictionaryKey())
            {
                Console.WriteLine(s);
            }
            
            foreach (string s in car.GetDictionaryVal())
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
