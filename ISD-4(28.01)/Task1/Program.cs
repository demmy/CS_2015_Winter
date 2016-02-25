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
            string filename = "";
            string action = "";
            AbstarctHandler file = null;
            Console.WriteLine("Enter the filename");
            filename = Console.ReadLine().ToUpper();
            if (filename.EndsWith(".XML"))
            {
                file = new XMLHandler();
            }
            else if (filename.EndsWith(".TXT"))
            {
                file = new TXTHandler();
            }
            else if (filename.EndsWith(".DOC"))
            {
                file = new DOCHandler();
            }
            else
            {
                Console.WriteLine("You entered invalid format file.\n");
                System.Threading.Thread.Sleep(3000);
                return;
            }
            Console.WriteLine("Selec an action");
            Console.WriteLine(" OPEN / CREATE / CHANGE / SAVE");
            action = Console.ReadLine().ToUpper();
            if (action == "OPEN") { file.Open(); }
            else if (action == "CREATE") { file.Create(); }
            else if (action == "CHANGE") { file.Change(); }
            else if (action == "SAVE") { file.Save(); }
            else { Console.WriteLine("You entered invalid command"); }
            Console.ReadLine();
        }
    }
}
