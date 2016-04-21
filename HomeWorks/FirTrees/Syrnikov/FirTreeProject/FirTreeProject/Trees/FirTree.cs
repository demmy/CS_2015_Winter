using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirTreeProject
{
    public class FirTree : AbstractTree , IFirTree
    {
        public FirTree()
        {
            height = 0;
            color = TreeColor.Green;
            shape = TreeShape.Shapely;
        }

        public override void ChangeColor(Season season)
        {
            //color = TreeColor.Green;
        }
    }
}
