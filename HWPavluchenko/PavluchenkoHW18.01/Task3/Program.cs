using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Plane AN255 = new Plane(43, 22, 900000000, 800, 1998, 18, 190);
            AN255.ShowInfo();
            Car nissan = new Car(15, 66, 12000, 220, 2005);
            nissan.ShowInfo();
            Ship yellowSubmarine = new Ship(43, 22, 12300, 800, 1964, "Liverpool", 4);
            yellowSubmarine.ShowInfo();

        }
    }
}
