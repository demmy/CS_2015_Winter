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
            MyList<int> list = new MyList<int>();
            list.Add(1);
            list.Add(3);
            list.Add(4);
            list.Add(9);
            list.Add(9);
            list.Add(4);
            list.Add(2);
            list.Add(7);
            list[5] = 12;
            Console.WriteLine("Element [4]   =   {0}", list[4]);
            Console.WriteLine("List length   =   {0}", list.Count);
            foreach (int i in list.GetList())
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("--------------------------------------------------");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list.GetArray()[i]);
            }
            Console.ReadLine();
        }
    }
}
