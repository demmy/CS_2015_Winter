using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the expression in fofmat  X (operation) Y");
            string s = "";
            string s1 = "";
            string s2 = "";
            int i = 0;
            double x = 0;
            double y = 0;
            char z;
            s = Console.ReadLine();
            if (s.IndexOf('+') != -1){i = s.IndexOf('+');}
            if (s.IndexOf('-') != -1){i = s.IndexOf('-');}
            if (s.IndexOf('/') != -1){i = s.IndexOf('/');}
            if (s.IndexOf('*') != -1){i = s.IndexOf('*');}
            z = s[i];
            s1 = s.Substring(0, i);
            s2 = s.Substring(i + 1, s.Length - i - 1);
            try
            {
                x = double.Parse(s1);
                try
                {
                    y = double.Parse(s2);
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
                            Console.WriteLine("Invalid expression");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid expression");
                }
            }
            catch
            {
                Console.WriteLine("Invalid expression");
            }
            Console.ReadLine();
        }
    }
}
