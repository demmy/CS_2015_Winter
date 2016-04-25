using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirTreeProject
{
    public class Forest : IForest
    {
        public List<ITree> Trees { get; }

        public int TreeCount
        {
            get
            {
                return Trees.Count;
            }
        }        

        public Forest()
        {
            NatureEnvironment.SeasonChanged += ChangeSeason;
            Trees = new List<ITree>();
        }

        public void AddTree(ITree newTree)
        {
            Trees.Add(newTree);
        }

        private void ChangeSeason(Season currentSeason)
        {
            foreach (var item in Trees)
            {
                item.GrowUp();
                item.ChangeColor(currentSeason);
            }
        }
    }
}
