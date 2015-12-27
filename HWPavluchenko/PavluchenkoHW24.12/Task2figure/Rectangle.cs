using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2figure
{
    class Rectangle
    {
        double side1;
        double side2;

        public double Side2
        {
            get { return side2; }
            set { side2 = value; }
        }

        public double Side1
        {
            get { return side1; }
            set { side1 = value; }
        }
        public Rectangle(double side1, double side2)
        {
            Side1 = side1;
            Side2 = side2;
        }
        public double AreaCalculator()
        {
            return Side1 * Side2;
        }
        public double PerimetrCalculator()
        {
            return (Side1 + Side2) * 2;
        }

        public double Area
        {
            get { return AreaCalculator(); }
        }
        public double Perimetr
        {
            get { return PerimetrCalculator(); }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Area of rectangle = {0}\nPerimetr of rectangle = {1}\n", Area, Perimetr);
        }
    }
}
