using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirTreeProject
{
    public interface IForest
    {
        List<ITree> Trees { get; }
        int TreeCount { get; }

        void AddTree(ITree tree);
    }
}
