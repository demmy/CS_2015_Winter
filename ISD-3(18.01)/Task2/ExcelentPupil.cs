using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("I excelent study");
        }
        public override void Relax()
        {
            Console.WriteLine("I have a little rest");
        }
        public override void Read()
        {
            Console.WriteLine("I read on 5");
        }
        public override void Write()
        {
            Console.WriteLine("I wrire on 5");
        }        
    }
}
