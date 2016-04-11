using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forest.Interfaces;

namespace Forest
{
    class MyForest:IForest
    {
        ITree tree;
        public List<ITree> Trees = new List<ITree>();
        private Season season = Season.Summer;
        public MyForest()
        {
            this.tree = Createtree();
            Trees.Add(tree);
            this.tree.Appear();
        }
        public MyForest(ITree teTree)
        {
            this.tree = teTree;
            Trees.Add(tree);
            this.tree.Appear();
        }
        private Tree Createtree()
        {
            Tree myTree = new Tree(this.season);
            return myTree;
        }
        public Season TreeSeason
        {
            get{return season;}
            set { season = value; }
        }

        public Color TreeColor { get { return tree.Colour; }}
        public Shape TreeShape { get { return tree.TreeShape; } }
    }
}
