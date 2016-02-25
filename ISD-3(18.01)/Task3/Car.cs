using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Car : Vehicle
    {
        public Car()
        {
            this.N = 15.2342f;
            this.E = 43.4566f;
            this.price = 8500;
            this.speed = 170;
            this.year = new DateTime(2010, 5, 18);
        }
    }
}
