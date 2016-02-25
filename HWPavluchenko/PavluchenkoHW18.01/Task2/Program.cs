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
            Pupil first = new Pupil();
            Pupil second = new GoodPupil();
            Pupil third = new BadPupil();
            Pupil fourth = new ExelentPupil();

            ClassRoom juniors = new ClassRoom( first, second, third, fourth);
            juniors.ShowInfo();
        }
    }
}
