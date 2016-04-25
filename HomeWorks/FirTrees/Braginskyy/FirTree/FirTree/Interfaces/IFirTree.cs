using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirTreeApp.Interfaces
{
    public interface IFirTree : ITree
    {
        bool Cones { get; }
    }
}
