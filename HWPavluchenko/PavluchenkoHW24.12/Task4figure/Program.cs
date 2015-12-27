using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4figure
{
    //    Задание 4
    //Требуется:
    //Создать классы Point и Figure.
    //Класс Point должен содержать два целочисленных поля и одно строковое поле.
    //Создать три свойства с одним методом доступа get.
    //Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями аргументов. 
    //Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти аргументов типа Point.
    //Создать два метода: double LengthSide(Point A, Point B), который рассчитывает длину стороны многоугольника; 
    //    void PerimeterCalculator(), который рассчитывает периметр многоугольника.
 
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(22, 42, "A");
            Point b = new Point(15, 25, "B");
            Point c = new Point(12, 65, "C");
            Point d = new Point(56, 34, "D");
            Point e = new Point(28, 22, "E");
            Figure figure1 = new Figure(a, b, c, d, e);
            figure1.ShowInfo();    
        }
    }
}
