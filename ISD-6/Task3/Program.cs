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
            MyClass mClass = new MyClass();
            MyStruct mStruct = new MyStruct();
            mClass.change = "NO change";
            mStruct.change = "NO change";            
            ClassTaker(mClass);
            StructTaker(mStruct);
            Console.WriteLine(mClass.change);
            Console.WriteLine(mStruct.change);
            Console.ReadLine();
        }
        static void ClassTaker(MyClass mClass)
        {
            mClass.change = "change";
        }
        static void StructTaker(MyStruct mStruct)
        {
            mStruct.change = "change"; 
        }
        
    }
}
