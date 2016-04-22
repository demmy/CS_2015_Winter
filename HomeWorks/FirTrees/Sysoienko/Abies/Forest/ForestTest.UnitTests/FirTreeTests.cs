using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forest;
using Forest.Enums;
using Forest.Interfaces;
using NUnit.Framework;

namespace ForestTest.UnitTests
{
    [TestFixture]
    public class FirTreeTests
    {
        private bool wascalled = false;
        [Test]
        public void Options_Winter_GreenAndSlender()
        {
            IFirTree tree = new FirTree();
            tree.TreeOption(Season.Summer);
            Assert.AreEqual(Color.Green, tree.Colour);
            Assert.AreEqual(Shape.Slender, tree.Shape);
        }
        [Test]
        public void Options_Summer_GreenAndSlender()
        {
            IFirTree tree = new FirTree();
            tree.TreeOption(Season.Summer);
            Assert.AreEqual(Color.Green, tree.Colour);
            Assert.AreEqual(Shape.Slender, tree.Shape);
        }
        [Test]
        public void Options_Autumn_DarkGreenAndNormal()
        {
            IFirTree tree = new FirTree();
            tree.TreeOption(Season.Autumn);
            Assert.AreEqual(Color.DarkGreen, tree.Colour);
            Assert.AreEqual(Shape.Normal, tree.Shape);
        }
        [Test]
        public void BornEvent_Work_Called()
        {
            IFirTree tree = new FirTree();
            tree.TreeOption(Season.Autumn);
            tree.Born += (o, e) => wascalled = true;
            tree.Appear();
            Assert.IsTrue(wascalled);
        }
        [Test]
        public void GrownEvent_Work_Called()
        {
            IFirTree tree = new FirTree();
            tree.TreeOption(Season.Autumn);
            tree.Grown += (o, e) => wascalled = true;
            tree.Grow();
            Assert.IsTrue(wascalled);
        }
        [Test]
        public void Grow_Work_RiseHeightAndWidth()
        {
            IFirTree tree = new FirTree();
            tree.TreeOption(Season.Summer);
            tree.Grow();
            Assert.AreEqual(10, tree.Width);
            Assert.AreEqual(10, tree.Height);
        }
    }
}
