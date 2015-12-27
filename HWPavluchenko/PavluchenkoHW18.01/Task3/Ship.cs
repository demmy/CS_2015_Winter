using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Ship: Vehicle
    {

        string homePort;
        int numberOfPassengers;

        public int NumberOfPassengers
        {
            get { return numberOfPassengers; }
            set { numberOfPassengers = value; }
        }

        public string HomePort
        {
            get { return homePort; }
            set { homePort = value; }
        }
         public Ship(int inputX, int inputY, decimal inputPrice, int inputSpeed, 
                     int inputYear, string inputPort, int inputNumberOfPass)
        { 
            PointX = inputX;
            PointY = inputY;
            Price = inputPrice;
            Speed = inputSpeed;
            YearOfRelease = inputYear;
            HomePort = inputPort;
            NumberOfPassengers = inputNumberOfPass;
        }

         public override void ShowInfo()
         {
             Console.WriteLine("Type: ship\nHome port: {0}\nNumper of pessengers: {1}", homePort, numberOfPassengers);
             base.ShowInfo();
         }
    }
}
