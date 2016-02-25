using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1abstract
{
    public class TXTHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("Метод изменения для TXT");
        }

        public override void Create()
        {
            Console.WriteLine("Метод создания для TXT");
        }

        public override void Open()
        {
            Console.WriteLine("Метод открытия для TXT");
        }

        public override void Save()
        {
            Console.WriteLine("Метод сохранения для TXT");
        }
    }
}
