using System;

namespace Forest.Interfaces
{
     interface ITree
    {
        Color Colour { get;  }
        Shape TreeShape { get; }
        int CountOfDays { get; set; }
        void Appear();
        void Grow();
        void DisplayTree();
        event EventHandler Born;
        event EventHandler Grown;
        event EventHandler Die;
    }
}