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
            string key = "";
            DocumentWorker doc;
            Console.WriteLine("Enter access key PRO or EXP or press Enter");
            key = Console.ReadLine().ToUpper();
            if (key == "PRO")
            {
                doc = new ProDocumentWorker(); 
            }
            else if (key == "EXP")
            {
                doc = new ExpertDocumentWorker();
            }
            else 
            {
                doc = new DocumentWorker();
            }
            doc.OpenDocument();
            doc.EditDocument();
            doc.SaveDocument();
            Console.ReadLine();
        }        
    }
}
