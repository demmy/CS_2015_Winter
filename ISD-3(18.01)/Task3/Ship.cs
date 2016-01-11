using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Ship : Vehicle
    {
        public Ship()
        {
            this.N = 18.2789f;
            this.E = 52.1212f;
            this.price = 1000000;
            this.speed = 30;
            this.year = new DateTime(2012, 7, 10);
        }
        private string port = "Congo";
        private int passengers = 450;
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Port : {0}\nPassengers : {1}", port, passengers);
        }
    }
}
