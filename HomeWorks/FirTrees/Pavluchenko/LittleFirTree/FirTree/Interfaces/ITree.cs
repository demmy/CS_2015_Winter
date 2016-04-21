using Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirTree.Interfaces
{
    public interface ITree
    {
        Color State { get; }
        Shape Form { get; }
        int Number { get; }
        double Height { get; }
        double Age { get; }
    }
}
