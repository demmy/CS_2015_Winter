using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int code = Helper.EnterInt("code");
            switch (code)
            {
                case 123456:
                    DocumentWorker PDW = new ProDocumentWorker();
                    break; 
                case 654321:
                    DocumentWorker EDW = new ExpertDocumentWorker();
                    break;
                default:
                    DocumentWorker DW = new DocumentWorker();
                    break; 
            }
        }
    }
}
