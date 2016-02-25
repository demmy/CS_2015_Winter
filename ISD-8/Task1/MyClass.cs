using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class MyClass<T>
    {
        public static T FactoryMathod(T obj)
        {
            T typeObj = obj;
            return typeObj;
        }
    }
}
