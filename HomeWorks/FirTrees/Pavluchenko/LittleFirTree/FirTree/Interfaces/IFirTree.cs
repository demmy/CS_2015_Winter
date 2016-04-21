using Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirTree.Interfaces
{
    public interface IFirTree : ITree
    {
        void Prick();
        int NeedleLength { get; }
        int NumberOfCones { get; }
    }
}
