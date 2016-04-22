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
   public class MyForestTests
    {
        readonly IForest forest = new MyForest();
        [Test]
        public void Optons_Summer_GreenAndSlender()
        {
            IFirTree treedTree = new FirTree();
            forest.Add(treedTree);
            forest.SetSeason(Season.Summer);
            Assert.AreEqual(treedTree.Colour, Color.Green);
            Assert.AreEqual(treedTree.Shape, Shape.Slender);
        }
        [Test]
        public void Optons_Winter_GreenAndSlender()
        {
            IFirTree treedTree = new FirTree();
            forest.Add(treedTree);
            forest.SetSeason(Season.Winter);
            Assert.AreEqual(treedTree.Colour, Color.Green);
            Assert.AreEqual(treedTree.Shape, Shape.Slender);
        }
    }
}
