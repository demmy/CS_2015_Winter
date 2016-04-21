using Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirTree.Interfaces
{
    public interface IForest
    {
        double Age { get;  }
        List<BaseTree> AllTrees { get; }
        List<FirTree> FirTrees { get; }
        List<SomeTree> SomeTrees { get; }
        void BornFirTree(double deltaHeight, int needleLength, int numberOfCones);
        void BornSomeTree(double deltaHeight); 
        void DeleteFirTree(FirTree ft);
        void DeleteSomeTree(SomeTree st);
    }
}
