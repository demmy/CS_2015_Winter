using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirTreeApp.Interfaces
{
    public interface IForest
    {
        List<ITree> AllTree { get;}
        void TreeBorn (ITree tree);
    }
}
