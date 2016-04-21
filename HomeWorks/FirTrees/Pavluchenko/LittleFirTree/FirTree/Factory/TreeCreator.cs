using Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirTree.Factory
{
    public static class TreeCreator
    {
        public static FirTree FirTree(int number, double deltaHeight, int needleLength, int numberOfCones)
        {
            FirTree newTree = new FirTree(number, deltaHeight, needleLength, numberOfCones);
            return newTree;
        }

        public static SomeTree SomeTree(int number, double deltaHeight)
        {
            SomeTree newTree = new SomeTree(number, deltaHeight);
            return newTree;
        }
    }
}
