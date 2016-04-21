using System;
using NUnit.Framework;
using FirTreeApp.Interfaces;
using FirTreeApp.Trees;
using FirTreeApp;

namespace UnitTestForest
{
    [TestFixture]
    public class ForestTest
    {
        private IForest forest;        
        [SetUp]
        public void Setup()
        {
            forest = new Forest();
        }
        [Test]
        public void TestCountFirTreeInForest()
        {
            int countTree = forest.AllTree.Count;
            forest.TreeBorn(new FirTree());
            Assert.That(forest.AllTree.Count, Is.EqualTo(countTree + 1));
        }
        [Test]
        public void TestAddFirTreeInForest()
        {            
            IFirTree tree = new FirTree();
            forest.TreeBorn(tree);
            Assert.That(forest.AllTree[forest.AllTree.Count - 1], Is.EqualTo(tree));           
        }
    }
}
