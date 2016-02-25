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
            Console.WriteLine("----------------------------StandartList-------------------------------");
            List<int> StandartList = new List<int>();
            StandartList.Add(3);
            StandartList.Add(6);
            StandartList.Add(8);
            StandartList.Add(9);
            Console.WriteLine(StandartList.Count());
            Console.WriteLine(StandartList[1]);
            Console.WriteLine("-------");
            for (int i = 0; i < StandartList.Count; i++)
            {
                Console.WriteLine(StandartList[i]);
            }
            Console.WriteLine("-----------------------------MyList------------------------------");
            MyList<int> ModifyList = new MyList<int>();
            ModifyList.Add(3);
            ModifyList.Add(6);
            ModifyList.Add(8);
            ModifyList.Add(9);
            Console.WriteLine(ModifyList.Count);
            Console.WriteLine(ModifyList[1]);
            Console.WriteLine("-------");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(ModifyList[i]);
            }
            Console.WriteLine("----------------------------Task4--------------------------------");
            int[] values = ModifyList.GetArray();
            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine(values[i]);
            }            
            Console.ReadLine();
        }
    }
}
