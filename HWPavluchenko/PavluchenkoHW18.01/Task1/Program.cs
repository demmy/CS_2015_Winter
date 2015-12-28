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
            string value = "Text";
            Printer pr = new Printer();           //создаем объект базового класса
            pr.Print(value);                      // текст будет обычного цвета                  
            Printer first = new FirstInheritor(); // создаем объект производного класса, и сохраняем в ссылке типа базового 
            first.Print(value);                   // текст будет отличного от цвета базовой реализации из-за метки override
            SecondInheritor second = new SecondInheritor(); // создаем объект второго производного класса
            second.Print(value);                            // у него соответствующий цвет
            FirstInheritor up = (FirstInheritor) first;     // явно приводим объект производного класса, 
                                                            //хранящегося в ссылке базового типа обратно в производный тип
            up.Print(value);

            
        }
    }
}
