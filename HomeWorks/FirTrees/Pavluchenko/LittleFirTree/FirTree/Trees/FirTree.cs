using Enums;
using FirTree.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FirTree
{
    public class FirTree: BaseTree, IFirTree  
    {
        public int NeedleLength { get; private set; }
        public int NumberOfCones { get; private set; }

        public FirTree(int number, double deltaHeight, int needleLength, int numberOfCones) : base(number, deltaHeight)
        {
            NeedleLength = needleLength;
            NumberOfCones = numberOfCones;
            State = Color.Green;
            Form = Shape.Shapely;
        }

        public void Prick()
        {
            Display.FirTreePrick(Number); 
        }
    }
}
