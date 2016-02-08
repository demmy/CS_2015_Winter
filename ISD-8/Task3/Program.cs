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
            Console.WriteLine("--------------------StandartDictionary--------------------");
            Dictionary<int, string> StandartDictionary = new Dictionary<int, string>();
            StandartDictionary.Add(5,"apple");
            StandartDictionary.Add(12, "orange");
            StandartDictionary.Add(8, "bread");
            StandartDictionary.Add(2, "milk");
            Console.WriteLine("Result {0}", StandartDictionary[8]);
            Console.WriteLine("We have {0} pair of key-value", StandartDictionary.Count());

            Console.WriteLine("--------------------MyDictionary--------------------");
            MyDictionary<int,string> ModifyDictionary = new MyDictionary<int,string>();
            ModifyDictionary.Add(5,"apple");
            ModifyDictionary.Add(12,"orange");
            ModifyDictionary.Add(8,"bread");
            ModifyDictionary.Add(2,"milk");
            Console.WriteLine("Result {0}", ModifyDictionary[8]);
            Console.WriteLine("We have {0} pair of key-value", ModifyDictionary.Count);   
            Console.ReadLine();
        }
    }
}
