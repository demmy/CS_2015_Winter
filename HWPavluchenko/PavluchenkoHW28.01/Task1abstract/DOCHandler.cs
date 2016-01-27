using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1abstract
{
    class DOCHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("Метод изменения для DOC");
        }

        public override void Create()
        {
            Console.WriteLine("Метод создания для DOC");
        }

        public override void Open()
        {
            Console.WriteLine("Метод открытия для DOC");
        }

        public override void Save()
        {
            Console.WriteLine("Метод сохранения для DOC");
        }
    }
}
