using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1abstract
{
    class XMLHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("Метод изменения для XML");
        }

        public override void Create()
        {
            Console.WriteLine("Метод создания для XML");
        }

        public override void Open()
        {
            Console.WriteLine("Метод открытия для XML");
        }

        public override void Save()
        {
            Console.WriteLine("Метод сохранения для XML");
        }
    }
}
