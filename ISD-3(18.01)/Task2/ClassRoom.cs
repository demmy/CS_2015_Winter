using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class ClassRoom
    {
        Pupil[] myClass = new Pupil[4];

        public ClassRoom(Pupil first, Pupil second)
        {
            myClass[0] = first;
            myClass[1] = second;
            myClass[2] = first;
            myClass[3] = second;
        }
        public ClassRoom(Pupil first, Pupil second, Pupil third)
        {
            myClass[0] = first;
            myClass[1] = second;
            myClass[2] = third;
            myClass[3] = first;
        }
        public void PupilInfo()
        {
            for (int i = 0; i < myClass.Length; i++)
            {
                Console.WriteLine("------------------------");
                myClass[i].Study();
                myClass[i].Read();
                myClass[i].Write();
                myClass[i].Relax();
            }   
        }
    }
}
