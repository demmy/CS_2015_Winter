using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Car: Vehicle
    {
        
             public Car(int inputX, int inputY, decimal inputPrice, int inputSpeed, int inputYear)
        {
            PointX = inputX;
            PointY = inputY;
            Price = inputPrice;
            Speed = inputSpeed;
            YearOfRelease = inputYear;
        }
             public override void ShowInfo()
             {
                 Console.WriteLine("Type: car");
                 base.ShowInfo();
             }
    }
}
