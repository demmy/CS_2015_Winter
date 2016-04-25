using System;
using Forest.Enums;

namespace Forest.Interfaces
{
     interface ITree
    {
        Color Colour { get; }
        Shape Shape { get; }
        int Height { get; }
        int Width { get; }
        void Appear();
        void Grow();
        void TreeOption(Season season);
        event EventHandler Born;
        event EventHandler Grown;
    }
}