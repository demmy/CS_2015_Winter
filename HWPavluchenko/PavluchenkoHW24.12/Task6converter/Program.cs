using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6converter
{
    class Program
    {
        //    Задание 6
        //Требуется:
        //Создать класс Converter.
        //В теле класса создать пользовательский конструктор, который принимает три вещественных аргумента, 
        //    и инициализирует поля соответствующие курсу 3-х основных валют, 
        //    по отношению к гривне - public Converter(double usd, double eur, double rub).
        //Написать программу, которая будет выполнять конвертацию из гривны в одну из указанных валют, 
        //также программа должна производить конвертацию из указанных валют в гривну.
        static void Main(string[] args)
        {
            Converter cours1 = new Converter(25.18, 27.39, 0.37);
            cours1.ToUah(100);
            cours1.UahTo(300);
        }
    }
}
