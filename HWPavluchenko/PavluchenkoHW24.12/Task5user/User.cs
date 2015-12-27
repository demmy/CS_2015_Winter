using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5user
{
    class User
    {
        string login = "Orange";

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        string firstName = "Alexandr";

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        string secondName = "Tkachuk";

        public string SecondName
        {
            get { return secondName; }
            set { secondName = value; }
        }
        int age = 20;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        readonly DateTime date = DateTime.Now;

        public void ShowInfo()
        {
            Console.WriteLine("Login: {0}\nFirst name: {1}\nSecond name: {2}\nAge: {3}\nDate of registration:\n{4}",
                               login, firstName, secondName, age, date);
            Console.ReadLine();

        }
    }
}
