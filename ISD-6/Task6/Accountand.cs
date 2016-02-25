using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    enum Post
    {
        Guard = 100,
        Cliner = 110,
        Director = 120,
        Menager = 160,
    }
    class Accountand
    {
        public static bool AskForBonus(Post worker, int hour)
        {
            if ((int)worker < hour)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
