using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Pupil
    {
        public virtual void Study() 
        {
            Console.WriteLine("Level of stady: ");
        }
        public virtual void Read()
        {
            Console.WriteLine("Level of reading: ");
        }
        public virtual void Write()
        {
            Console.WriteLine("Level of writing: ");
        }
        public virtual void Relax()
        {
            Console.WriteLine("Level of relaxation:  \n");
        }
        
        public virtual void Show()
        {
            Console.WriteLine("New pupil");
            Study();
            Write();
            Read();
            Relax();
        }
        

    }
}
