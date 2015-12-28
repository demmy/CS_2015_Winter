using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class ExelentPupil : Pupil
    {
        public override void Study()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Level of study: *****");
            Console.ResetColor(); 
        }
        public override void Read()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Level of reading: *****");
            Console.ResetColor(); 
        }
        public override void Write()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Level of writing: *****");
            Console.ResetColor(); 
        }
        public override void Relax()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Level of relaxation: ***\n");
            Console.ResetColor(); 
        }
        public override void Show()
        {
            Console.WriteLine("Exelent pupil");
            Study();
            Write();
            Read();
            Relax();
        }
    }
}
