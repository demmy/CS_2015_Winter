using FirTreeApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FirTreeApp
{
    public class Forest : IForest
    {
        List<ITree> forest;
        public Forest()
        {
            forest = new List<ITree>();
        }
        public List<ITree> AllTree
        {
            get { return forest; }
        }
        public void TreeBorn(ITree tree)
        {
            AllTree.Add(tree);
        }
    }
}
