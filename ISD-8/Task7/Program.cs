using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList newArr = new ArrayList();
            newArr.Add(1);
            newArr.Add(2);
            newArr.Add(3);
            newArr.Add(4);
            newArr.Add(5);
            newArr.Add(6);
            newArr.Add(7);
            newArr.Add(8);
            newArr.Add(9);
            newArr.Add(10);            
            newArr[7] = "new element";
            Console.WriteLine("Capacity {0}",newArr.Capacity);
            newArr.Capacity = 20;
            Console.WriteLine("Capacity {0}", newArr.Capacity);            
            Console.WriteLine("----------------");
            for (int i = 0; i < newArr.Count; i++)
            {
                Console.WriteLine(newArr[i]);
            }   
            Console.ReadLine();
        }
    }
}
