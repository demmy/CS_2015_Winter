using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7employee
{
    //    Задание 7
    //Требуется:
    //Создать класс Employee.
    //В теле класса создать пользовательский конструктор, который принимает два строковых аргумента, 
    //и инициализирует поля, соответствующие фамилии и имени сотрудника.
    //Создать метод рассчитывающий оклад сотрудника (в зависимости от должности и стажа) и налоговый сбор.
    //Написать программу, которая выводит на экран информацию о сотруднике (фамилия, имя, должность), оклад и налоговый сбор.
  
    class Program
    {
        static void Main(string[] args)
        {
            Employee worker = new Employee("Alexandr", "Tkachuk");
            int post, exp;
            worker.ChoosePosts();
            post = Helper.EnterInt("post");
            worker.ChooseExp();
            exp = Helper.EnterInt("experience");
            worker.SalaryAndTax(post, exp);
        }
    }
}
