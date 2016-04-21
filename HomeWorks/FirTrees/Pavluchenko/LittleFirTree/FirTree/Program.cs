using Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Forest sherwood = new Forest();

            Display.ShowActualSeason();
            Nature.NextSeason();

            Display.ShowActualSeason();
            Nature.NextSeason();

            Display.ShowActualSeason();
            Nature.NextSeason();

            Display.ShowActualSeason();

            Nature.NextSeason();
            sherwood.BornFirTree( 1.2, 12, 23);
            sherwood.BornSomeTree(0.7);

            Nature.NextSeason();
            sherwood.BornSomeTree(1.2);

            Nature.NextSeason();
            sherwood.BornFirTree(0.3, 12, 21);
            FirTree ft = sherwood.FirTrees[0];

            ft.Prick();

            Nature.NextSeason();
            sherwood.BornSomeTree(1.3);

            Display.ShowActualSeason();

            Display.ShowForest(sherwood);

            sherwood.FirTrees[1].Prick();
        }
    }
}
