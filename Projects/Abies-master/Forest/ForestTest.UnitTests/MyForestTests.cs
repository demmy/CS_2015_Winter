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
   public class MyForestTests
    {
        readonly IForest forest = new MyForest();
        [Test]
        public void Optons_Summer_GreenAndSlender()
        {
           forest.TreeSeason = Season.Summer;
           Assert.AreEqual(Color.Green,forest.TreeColor);
           Assert.AreEqual(Shape.Slender, forest.TreeShape);
        }
        [Test]
        public void Optons_Winter_GreenAndSlender()
        {
            forest.TreeSeason = Season.Winter;
            Assert.AreEqual(Color.Green, forest.TreeColor);
            Assert.AreEqual(Shape.Slender, forest.TreeShape);
        }
    }
}
