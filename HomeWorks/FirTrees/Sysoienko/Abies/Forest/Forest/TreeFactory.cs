using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forest.Interfaces;

namespace Forest
{
    internal abstract class Creator
    {
        public abstract ITree CreateTree();
    }
    class TreeFactory:Creator
    {
        public override ITree CreateTree()
        {
            return new FirTree();
        }
    }
}
