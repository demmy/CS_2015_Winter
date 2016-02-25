using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class XMLHandler : AbstarctHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open XML file");
        }
        public override void Create()
        {
            Console.WriteLine("Create XML file");
        }
        public override void Change()
        {
            Console.WriteLine("Change XML file");
        }
        public override void Save()
        {
            Console.WriteLine("Save XML file");
        }
    }
}
