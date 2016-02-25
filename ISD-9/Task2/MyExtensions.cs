using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public static class MyExtensions
    {
        public static T[] GetArray<T>(this IEnumerable<T> list)
        {
            int i = 0;
            T[] arr1 = new T[i];
            foreach (T obj in list)
            {
                T[] arr2 = new T[arr1.Length + 1];
                arr1.CopyTo(arr2, 0);
                arr2[arr1.Length] = obj;
                arr1 = arr2;
            }
            return arr1;
        }
    }
}
