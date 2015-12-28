using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1adress
{
    //Задание 1
    //Создать экземпляр класса.
    //В поля экземпляра записать информацию о почтовом адресе.
    //Выведите на экран значения полей, описывающих адрес.
    class Program
    {
        static void Main(string[] args)
        {
            Adress first = new Adress();
            first.RecordInfo(79019, "Ukrane", "Lviv", "Medova", 6, 1);
            first.ShowInfo();
        }
    }
}
