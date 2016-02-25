using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil excelentPupil = new ExcelentPupil();
            Pupil goodPupil = new GoodPupil();
            Pupil badPupil = new BadPupil();
            ClassRoom firstClass = new ClassRoom(excelentPupil, goodPupil, badPupil);
            Console.WriteLine("\nFirstClass info");
            firstClass.PupilInfo();
            ClassRoom secondClass = new ClassRoom(excelentPupil, goodPupil);
            Console.WriteLine("\nSecondClass info");
            secondClass.PupilInfo();
            Console.ReadKey();
        }
    }
}
