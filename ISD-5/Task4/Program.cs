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
            string s = "Is an example of the line to test the code";
            string substring = "";
            Console.WriteLine(s);
            //My method    
            Console.WriteLine("\n-----------------------My method-----------------------");
            Console.WriteLine(substring = s.MySubstring(6, 7));
            Console.WriteLine(s.MyIndexOf("amp"));
            Console.WriteLine(substring = s.MyReplace("the", "_______________"));

            //Standart method
            Console.WriteLine("\n-----------------------Standert method-----------------------");
            Console.WriteLine(substring = s.Substring(6, 7));
            Console.WriteLine(s.IndexOf("amp"));
            Console.WriteLine(substring = s.Replace("the", "_______________"));

            Console.ReadLine();
        }
    }
}
