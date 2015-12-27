using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2figure
{
    public static class Helper
    {
        public static double EnterDouble(string name)
        {
            bool correct = true;
            double side = 0;

            do
            {
                correct = true;
                Console.WriteLine("Enter {0}:", name);
                try
                {
                    side = Double.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("incorrect value, try again");
                    correct = false;
                }

                finally
                {
                    if (side == 0)
                    {
                        side = 1;
                    }

                }

            } while (!correct);

            return side;
        }

        public static int EnterInt(string name)
        {
            bool correct = true;
            int side = 0;

            do
            {
                correct = true;
                Console.WriteLine("Enter {0}:", name);
                try
                {
                    side = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("incorrect value, try again");
                    correct = false;
                }

                finally
                {
                    if (side == 0)
                    {
                        side = 1;
                    }

                }

            } while (!correct);

            return side;
        }
    }
}
