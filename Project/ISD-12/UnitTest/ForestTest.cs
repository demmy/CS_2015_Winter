using System;
using NUnit.Framework;
using ISD_12;

namespace UnitTest
{
    [TestFixture]
    public class ForestTest
    {
        private IForest forest;
        private IFirTree firTree;
        [SetUp]
        public void SetUp()
        {
            forest = new Forest();
            firTree = new FirTree();
        }
        [Test]
        public void TestAddNewFirTreeInForest()
        {
            bool born = forest.AddFirTree(firTree);
            Assert.That(born, Is.True);
        }
        [Test]
        public void TestWinterIncrease()
        {
            int currentHight = firTree.Hight;
            int increase = forest.WinterIncrease(firTree);
            Assert.That(increase, Is.EqualTo(1));
            Assert.That(firTree.Hight, Is.EqualTo(currentHight + 1));
        }
        [Test]
        public void TestSummerIncrease()
        {
            int currentHight = firTree.Hight;
            int increase = forest.SummerIncrease(firTree);
            Assert.That(increase, Is.EqualTo(5));
            Assert.That(firTree.Hight, Is.EqualTo(currentHight + 5));
        }
        [Test]
        public void TestShowHightFirTree()
        {
            int hight = forest.ShowHightFirTree(5, firTree);
            Assert.That(hight, Is.EqualTo(30));
        }
    }
}
