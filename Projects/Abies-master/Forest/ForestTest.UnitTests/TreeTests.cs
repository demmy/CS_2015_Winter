using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forest;
using Forest.Interfaces;
using NUnit.Framework;

namespace ForestTest.UnitTests
{
    [TestFixture]
    public class TreeTests
    {
        private bool wascalled = false;
        [Test]
        public void Options_Winter_GreenAndSlender()
        {
            ITree tree = new Tree(Season.Winter);
            Assert.AreEqual(Color.Green,tree.Colour);
            Assert.AreEqual(Shape.Slender, tree.TreeShape);
        }
        [Test]
        public void Options_Summer_GreenAndSlender()
        {
            ITree tree = new Tree(Season.Summer);
            Assert.AreEqual(Color.Green, tree.Colour);
            Assert.AreEqual(Shape.Slender, tree.TreeShape);
        }
        [Test]
        public void Options_Autumn_DarkGreenAndNormal()
        {
            ITree tree = new Tree(Season.Autumn);
            Assert.AreEqual(Color.DarkGreen, tree.Colour);
            Assert.AreEqual(Shape.Normal, tree.TreeShape);
        }
        [Test]
        public void BornEvent_Work_Called()
        {
            ITree tree = new Tree(Season.Autumn);
            tree.Born += (o,e) => wascalled = true;            
            tree.Appear();
            Assert.IsTrue(wascalled);
        }
        public void GrownEvent_Work_Called()
        {
            ITree tree = new Tree(Season.Autumn);
            tree.Grown += (o, e) => wascalled = true;
            tree.Grow();
            Assert.IsTrue(wascalled);
        }
        public void DieEvent_Work_Called()
        {
            ITree tree = new Tree(Season.Autumn);
            tree.Die += (o, e) => wascalled = true;
            tree.CountOfDays = 0;
            tree.Grow();
            Assert.IsTrue(wascalled);
        }
    }
}
