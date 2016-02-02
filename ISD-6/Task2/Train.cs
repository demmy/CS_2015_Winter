using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public struct Train
    {
        public string destination;
        public int trainNumber;
        public int departure;

        public Train(string destination, int trainNumber, int departure)
        {
            this.destination = destination;
            this.trainNumber = trainNumber;
            this.departure = departure;
        }
    }
}
