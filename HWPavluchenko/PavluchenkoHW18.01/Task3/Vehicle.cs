using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    abstract class Vehicle
    {
        int pointX;

        public int PointX
        {
            get { return pointX; }
            set { pointX = value; }
        }
        int pointY;

        public int PointY
        {
            get { return pointY; }
            set { pointY = value; }
        }
        decimal price;

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        int speed;

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        int yearOfRelease;

        public int YearOfRelease
        {
            get { return yearOfRelease; }
            set { yearOfRelease = value; }
        }


        public virtual void ShowInfo()
        {
            Console.WriteLine("Coordinates: X:{0}Y:{1}\nPrice: {2}\nSpeed: {3}\nYear of release: {4}", 
                                                      PointX, PointY, Price, Speed, YearOfRelease);
            Console.WriteLine("");
        }
    }
}
