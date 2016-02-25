using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    static class MyExtensions
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            int i = 0;
            T[] mas = new T[10];
            while (!list[i].Equals(mas[i]))
            {
                mas[i] = list[i];
                i++;
            }
            return mas;
        }
    }
}
