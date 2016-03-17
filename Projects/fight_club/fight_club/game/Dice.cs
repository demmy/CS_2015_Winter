using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fight_club
{
    public static class Dice
    {
        private static Random rnd = new Random();
        public static int Throw()
        {
            return rnd.Next(20) + 1;
        }
    }
}
