using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2figure
{
    //Задание 2
    //Требуется: Создать класс с именем Rectangle.
    //В теле класса создать два поля, описывающие длины сторон double side1, side2.
    //Создать пользовательский конструктор Rectangle(double side1, double side2), в теле которого поля side1 и side2 инициализируются значениями аргументов.
    //Создать два метода, вычисляющие площадь прямоугольника - double AreaCalculator() и периметр прямоугольника - double PerimeterCalculator().
    //Создать два свойства double Area и double Perimeter с одним методом доступа get.
    //Написать программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит на экран периметр и площадь.

    class Program
    {
        static void Main(string[] args)
        {
            double side1 = 0, side2 = 0;
            side1 = Helper.EnterDouble("Side1");
            side2 = Helper.EnterDouble("Side2");
            Rectangle figure = new Rectangle(side1, side2);
            figure.ShowInfo();
        }
    }
}
