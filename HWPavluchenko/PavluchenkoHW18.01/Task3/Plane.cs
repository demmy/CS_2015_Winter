using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Plane: Vehicle
    {
        double height;
        int numberOfPassengers;

        public int NumberOfPassengers
        {
            get { return numberOfPassengers; }
            set { numberOfPassengers = value; }
        } 

        public double Height
        {
            get { return height; }
            set { height = value; }
        }



        public Plane(int inputX, int inputY, decimal inputPrice, int inputSpeed, 
                     int inputYear, double inputHeight, int inputNumberOfPass)
        {
            PointX = inputX;
            PointY = inputY;
            Price = inputPrice;
            Speed = inputSpeed;
            YearOfRelease = inputYear;
            Height = inputHeight;
            NumberOfPassengers = inputNumberOfPass;
        }

        public override void ShowInfo()
        {

            Console.WriteLine("Type: plane\nHeight: {0}\nNumber of pessengeres:{1}", height, numberOfPassengers);
            base.ShowInfo();

        }
    }
}
