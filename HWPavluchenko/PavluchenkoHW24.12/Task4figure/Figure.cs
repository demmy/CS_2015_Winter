using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4figure
{
    public class Figure
    {
        double side1;

        public double Side1
        {
            get { return side1; }
        }
        double side2;

        public double Side2
        {
            get { return side2; }
        }
        double side3;

        public double Side3
        {
            get { return side2; }
        }
        double side4;

        public double Side4
        {
            get { return side4; }
        }
        double side5;

        public double Side5
        {
            get { return side5; }
        }
        string type;

        public string Type
        {
            get { return type; }
        }

        public Figure(Point inputA, Point inputB, Point inputC)
        {
            side1 = LengthSide(inputA, inputB);
            side2 = LengthSide(inputB, inputC);
            side3 = LengthSide(inputC, inputA);
            type = "Triangle";

        }

        public Figure(Point inputA, Point inputB, Point inputC, Point inputD)
        {
            side1 = LengthSide(inputA, inputB);
            side2 = LengthSide(inputB, inputC);
            side3 = LengthSide(inputC, inputD);
            side4 = LengthSide(inputD, inputA);
            type = "Quadrangle";
        }

        public Figure(Point inputA, Point inputB, Point inputC, Point inputD, Point inputE)
        {
            side1 = LengthSide(inputA, inputB);
            side2 = LengthSide(inputB, inputC);
            side3 = LengthSide(inputC, inputD);
            side4 = LengthSide(inputD, inputE);
            side5 = LengthSide(inputE, inputA);
            type = "Pentagon";
        }

        public double LengthSide(Point a, Point b)
        {
            return Math.Sqrt((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y));
        }

        void PerimeterCalculator()
        {
            Console.WriteLine(side1 + side2 + side3 + side4 + side5);
        }
        public void ShowInfo()
        {
            Console.WriteLine("Type of figure:\n{0}\nPerimetr of figure:", type);
            PerimeterCalculator();
            Console.ReadLine();
        }
    }
}
