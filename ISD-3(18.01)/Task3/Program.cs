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
            Vehicle Car = new Car();
            Car.PrintInfo();
            Vehicle Ship = new Ship();
            Ship.PrintInfo();
            Vehicle Plane = new Plane();
            Plane.PrintInfo();
            Console.ReadKey();
        }
    }
}
