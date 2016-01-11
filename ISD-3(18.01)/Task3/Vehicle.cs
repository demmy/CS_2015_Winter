using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Task3
{
    abstract class Vehicle
    {
        protected float N = 0f;
        protected float E = 0F;
        protected int price = 0;
        protected int speed = 0;
        protected DateTime year = new DateTime(1, 1, 1);
        virtual public void PrintInfo()
        {
            Console.WriteLine("\n-----------------------");
            Console.WriteLine("N{0}\u00B0\nE{1}\u00B0\nPrice : {2:c}\nSpeed : {3} km/h\nYear : {4}",
                N, E, price, speed, year.ToString("d", DateTimeFormatInfo.InvariantInfo));
        }
    }
}
