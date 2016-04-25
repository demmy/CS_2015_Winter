using FirTree.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirTree
{
    public class SomeTree: BaseTree, ISomeTree 
    {
        public SomeTree(int number, double deltaHeight) :base (number, deltaHeight)
        {

        }
        
    }
}
