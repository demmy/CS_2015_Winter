using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("I bad study");
        }
        public override void Relax()
        {
            Console.WriteLine("I rest always");
        }
        public override void Read()
        {
            base.Read();
        }
        public override void Write()
        {
            base.Write();
        }        
    }
}
