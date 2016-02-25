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
            Console.WriteLine(MyClass<int>.FactoryMathod(5).GetType());
            Console.WriteLine(MyClass<string>.FactoryMathod("5").GetType());            
            Console.ReadLine();
        }
    }
}
