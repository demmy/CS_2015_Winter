using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("I good study");
        }
        public override void Relax()
        {
            Console.WriteLine("I have a rest on the weekend");
        }
        public override void Read()
        {
            Console.WriteLine("I read on 4");
        }
        public override void Write()
        {
            Console.WriteLine("I wrire on 4");
        }       
    }
}
