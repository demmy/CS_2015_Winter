using FirTree.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enums;
using FirTree.Factory;

namespace FirTree
{
    public class Forest: IForest
    {
        
        public double Age{ get; private set; }
        public List<BaseTree> AllTrees { get; private set; }
        public List<FirTree> FirTrees { get; private set; }
        public List<SomeTree> SomeTrees { get; private set; }

        public Forest ()
        {
            FirTrees = new List<FirTree>();
            SomeTrees = new List<SomeTree>();
            AllTrees = new List<BaseTree>();

            Nature.changeSeason += Nature_changeSeason;
        }

        private void Nature_changeSeason(object sender, EventArgs e)
        {
            Age += ConstantsLib.DeltaAge;
        }
        
        public void BornFirTree(double deltaHeight, int needleLength, int numberOfCones)
        {
            FirTree ft = TreeCreator.FirTree( FirTrees.Count + 1, deltaHeight, needleLength, numberOfCones);
            AllTrees.Add(ft);
            FirTrees.Add(ft); 
        }

        public  void BornSomeTree(double deltaHeight)
        {
            SomeTree st = TreeCreator.SomeTree(SomeTrees.Count + 1, deltaHeight);
            AllTrees.Add(st);
            SomeTrees.Add(st);
        }

        public void DeleteFirTree(FirTree ft)
        {
            AllTrees.Remove(ft);
            FirTrees.Remove(ft);
        }

        public void DeleteSomeTree(SomeTree st)
        {
            AllTrees.Remove(st);
            SomeTrees.Remove(st);
        }
        
    }
}
