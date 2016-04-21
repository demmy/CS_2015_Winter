using FirTreeApp.Interfaces;
using FirTreeApp.Season;
using FirTreeApp.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirTreeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ISeason seasonSummer = new Summer();
            ISeason seasonWinter = new Winter();
            IForest forest = new Forest();
            ITree firTree1 = new FirTree();
            ITree firTree2 = new FirTree();
            
            firTree1.Grow(seasonSummer);
            for (int i = 0; i < 15; i++ )
            {                
                firTree2.Grow(seasonSummer);
            }

            firTree1.ChangeColor(seasonSummer);
            firTree2.ChangeColor(seasonWinter);

            forest.TreeBorn(firTree1);
            forest.TreeBorn(firTree2);

            foreach (IFirTree tree in forest.AllTree)
            {
                Console.WriteLine("Kind {0} --- Age {1} --- Height {2} --- Color {3} --- Cones {4}",
                    tree.Kind, tree.Age, tree.Height, tree.Color, tree.Cones);
            }

            Console.WriteLine(forest.AllTree.Count);
            Console.ReadLine();
        }
    }
}
