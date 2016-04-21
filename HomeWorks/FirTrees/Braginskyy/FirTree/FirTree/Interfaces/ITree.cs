using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirTreeApp.Interfaces
{
    public interface ITree
    {
        string Kind { get; }
        int Height { get; }
        string Color { get; }
        int Age { get; }
        void Grow(ISeason season);
        void ChangeColor(ISeason season);
    }
}
