using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
            char z;
            Console.WriteLine("Enter the first number");
            x = Helper.InputValidationDouble();
            Console.WriteLine("Enter the operation");
            z = (Char)Console.Read();
            Console.WriteLine("Enter the second number");
            y = Helper.InputValidationDouble();
            Console.WriteLine("Result:");
            switch (z)
            {
                case '+':
                    {
                        Console.WriteLine(Calculate.Addition(x, y));
                        break;
                    }
                case '-':
                    {
                        Console.WriteLine(Calculate.Substraction(x, y));
                        break;
                    }
                case '/':
                    {
                        Console.WriteLine(Calculate.Division(x, y));
                        break;
                    }
                case '*':
                    {
                        Console.WriteLine(Calculate.Multiplication(x, y));
                        break;
                    }
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }
            Console.ReadLine();
        }
    }
}
