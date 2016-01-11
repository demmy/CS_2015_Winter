using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Plane : Vehicle
    {
        public Plane()
        {
            this.N = 22.0015f;
            this.E = 31.1861f;
            this.price = 3500000;
            this.speed = 850;
            this.year = new DateTime(2014, 1, 7);
        }
        private int height = 10000;
        private int passengers = 167;
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Height : {0}\nPassengers : {1}", height, passengers);
        }
    }
}
