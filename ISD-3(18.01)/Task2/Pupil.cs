using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    abstract class Pupil
    {
        abstract public void Study();
        abstract public void Relax();
        virtual public void Read()
        {
            Console.WriteLine("I can read");
        }
        virtual public void Write()
        {
            Console.WriteLine("I can write");
        }                
    }
}
