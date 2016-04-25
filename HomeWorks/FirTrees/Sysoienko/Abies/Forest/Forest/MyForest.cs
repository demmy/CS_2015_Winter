using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forest.Enums;
using Forest.Interfaces;

namespace Forest
{
    internal class MyForest : IForest
    {
        private ITree _tree;
        private readonly Creator _creator = new TreeFactory();
        private readonly List<ITree> _trees = new List<ITree>();

        public MyForest()
        {
            this._tree = _creator.CreateTree();
            _trees.Add(_tree);
            this._tree.Appear();
        }
        public MyForest(ITree tree)
        {
            this._tree = tree;
            _trees.Add(tree);
        }
        public void SetSeason(Season season)
        {
            foreach (var tree in _trees)
            {
                tree.TreeOption(season);
            }
        }
        public void Add(ITree tree)
        {
            _trees.Add(tree);
            this._tree = tree;
        }
        public void Remove(ITree tree)
        {
            _trees.Remove(tree);
        }
    }
}
