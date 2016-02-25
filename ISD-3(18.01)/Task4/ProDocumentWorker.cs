using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class ProDocumentWorker : DocumentWorker
    {
        public override void OpenDocument()
        {
            base.OpenDocument();
        }
        public override void EditDocument()
        {
            Console.WriteLine("The document is edited");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("The document is stored in the old format, preserving the rest of the formats available in the Expert version");
        }
    }
}
