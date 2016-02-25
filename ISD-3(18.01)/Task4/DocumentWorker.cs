using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Document is open");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Editing a document is available in a version Pro");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Save the document available in the Pro version");
        }
    }
}
