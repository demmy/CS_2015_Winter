/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 16.03.2016
 * Time: 13:37
 */
using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Forest
{
    [TestFixture]
    public class ForestTest
    {
        Forest forest;
        Tree first;
            
        [SetUp]
        public void SetUp()
        {
            forest = new Forest();
//            forest.CurrentSeason = forest.GetSeason(DateTime.Now);
            forest.Add(TypeOfTree.Fir);
            first = forest.TreesInForest[0];
        }

        [Test]
        public void ForestCreateTest()
        {
            Assert.AreEqual(Season.Spring, forest.CurrentSeason , "Wrong current season in Forest");
        }
        
        [Test]
        public void AddFirTest()
        {
                Assert.IsTrue(forest.TreesInForest.Find(x => x.Type.Equals(TypeOfTree.Fir)) == first );
        }

        [Test]
        public void FirWinterColorTest()
        {
            forest.CurrentSeason = Season.Winter;
            Assert.That(forest.TreesInForest.Find(x=> x.Type.Equals(TypeOfTree.Fir)).Color, Is.EqualTo("Green"));
        }

        [Test]
        public void FirSummerColorTest()
        {
            forest.CurrentSeason = Season.Summer;
            Assert.That(forest.TreesInForest.Find(x=> x.Type.Equals(TypeOfTree.Fir)).Color, Is.EqualTo("Green"));
        }
        
        [Test]
        public void FirGrowningTest()
        {
            Tree tempFir = forest.TreesInForest.Find(x => x.Type.Equals(TypeOfTree.Fir));
            int tempFirLenght = tempFir.Lenght;
            tempFir.Grow();
            Assert.Greater(tempFir.Lenght, tempFirLenght);
        }

        [Test]
        public void FirIsShapelyTest()
        {
            Assert.IsTrue(forest.TreesInForest.Find(x => x.Type.Equals(TypeOfTree.Fir)).Shapely);
        }
        
    }
}
