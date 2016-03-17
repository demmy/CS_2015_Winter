using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirTreeProject
{
    public enum Season
    {
        Winter,
        Spring,
        Summer,
        Autumn,
    }
    public interface IForest
    {
        int TreeCount { get; }
        Season CurrentSeason { get; }

        void AddTree(ITree tree);
        ITree GetTree(TreeType treeType);
        void ChangeSeason();
    }
}
