using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            string adress = "file.TXT";
            bool coincidence;

            coincidence = adress.Contains(".XML");
            if (coincidence)
            {
                XMLHandler firstFile = new XMLHandler();
                firstFile.Change();
                firstFile.Create();
                firstFile.Open();
                firstFile.Save();
            }

            coincidence = adress.Contains(".TXT");
            if (coincidence)
            {
                TXTHandler firstFile = new TXTHandler();
                firstFile.Change();
                firstFile.Create();
                firstFile.Open();
                firstFile.Save();
            }

            coincidence = adress.Contains(".DOC");
            if (coincidence)
            {
                DOCHandler firstFile = new DOCHandler();
                firstFile.Change();
                firstFile.Create();
                firstFile.Open();
                firstFile.Save();
            }
        }
    }
}
