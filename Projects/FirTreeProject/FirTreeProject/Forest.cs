using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirTreeProject
{
    public class Forest : IForest
    {
        private List<ITree> trees;
        private Season currentSeason;

        public int TreeCount
        {
            get
            {
                return trees.Count;
            }
        }
        public Season CurrentSeason
        {
            get
            {
                return currentSeason;
            }
        }

        public Forest()
        {
            trees = new List<ITree>();
            currentSeason = Season.Winter;
        }

        public void AddTree(ITree newTree)
        {
            trees.Add(newTree);
        }

        public ITree GetTree(TreeType treeType)
        {
            ITree returnedTree = null;
            foreach (var item in trees)
            {
                if (treeType == item.Type)
                {
                    returnedTree = item;
                    break;
                }
            }
            return returnedTree;
        }

        public void ChangeSeason()
        {
            if (currentSeason == Season.Autumn)
            {
                currentSeason = Season.Winter;
            }
            else
            {
                currentSeason++;
            }
            foreach (var item in trees)
            {
                item.GrowUp();
                item.ChangeColor(currentSeason);
            }
        }
    }
}
