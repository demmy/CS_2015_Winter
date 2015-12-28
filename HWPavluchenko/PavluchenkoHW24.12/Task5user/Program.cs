using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5user
{   //    Задание 5
    //Требуется:
    //Создать класс User, содержащий информацию о пользователе (логин, имя, фамилия, возраст, дата заполнения анкеты). 
    //    Поле дата заполнения анкеты должно быть проинициализировано только один раз (при создании экземпляра данного класса) 
    //    без возможности его дальнейшего изменения.
    //Реализуйте вывод на экран информации о пользователе.
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            user1.ShowInfo();
            user1.ShowInfo();
        }
    }
}
