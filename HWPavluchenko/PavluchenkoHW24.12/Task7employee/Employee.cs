using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7employee
{
    class Employee
    {
        string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        string secondName;

        public string SecondName
        {
            get { return secondName; }
            set { secondName = value; }
        }
        public Employee(string first, string second)
        {
            firstName = first;
            secondName = second;
        }
        public void SalaryAndTax(int post, int experience)
        {
            double postCoef = 0, expCoef = 0;
            switch (post)
            {
                case 1:
                    postCoef = 500;
                    break;
                case 2:
                    postCoef = 1000;
                    break;
                case 3:
                    postCoef = 1500;
                    break;
                default:
                    break;
            }
            switch (experience)
            {
                case 1:
                    expCoef = 1;
                    break;
                case 2:
                    expCoef = 2;
                    break;
                case 3:
                    expCoef = 3;
                    break;
                default:
                    break;
            }
            Console.WriteLine("Salary = {0}$\nTax = {1}$", (postCoef * expCoef), (postCoef * expCoef * 0.015));
            Console.ReadLine();

        }
        public void ChoosePosts()
        {
            Console.WriteLine("Choose your destiny:\n");
            Console.WriteLine("1. Junior");
            Console.WriteLine("2. Middle");
            Console.WriteLine("3. Senior\n");

        }
        public void ChooseExp()
        {
            Console.WriteLine("Enter your experience:\n");
            Console.WriteLine("1. 1 year");
            Console.WriteLine("2. 2 years");
            Console.WriteLine("3. 3 years\n");

        }
    }
}
