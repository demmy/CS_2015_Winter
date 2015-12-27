using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class ClassRoom
    {
        Pupil first;
        Pupil second;
        Pupil third;
        Pupil fourth;

        public ClassRoom(Pupil firstInput, Pupil secondInput, Pupil thirdInput, Pupil fourthInput)
        {
            first = firstInput;
            second = secondInput;
            third = thirdInput;
            fourth = fourthInput;
        }
        public ClassRoom(Pupil firstInput, Pupil secondInput, Pupil thirdInput)
        {
            first = firstInput;
            second = secondInput;
            third = thirdInput;
        }
        public ClassRoom(Pupil firstInput, Pupil secondInput)
        {
            first = firstInput;
            second = secondInput;
        }
            
        public void ShowInfo()
        {
            first.Show();
            second.Show();
            if (!(third == null))
            third.Show();
            if (!(fourth == null))
            fourth.Show();
        }
            

        
    }
}
