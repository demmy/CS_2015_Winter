using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_12
{
    public interface IFirTree
    {
        int GrowFirTree(int increase);
        int Hight { get; }
        string Form { get; }
        string Color { get; }
    }
}
