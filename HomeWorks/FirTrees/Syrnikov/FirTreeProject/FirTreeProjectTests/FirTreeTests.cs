using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FirTreeProject;

namespace FirTreeProjectTests
{
    [TestFixture]
    class FirTreeTests
    {
        [SetUp]
        public void SetUp()
        {
        }

        [Test]
        public void FirTreeBornAndGrow()
        {
            //arrange
            ITree firTree = new FirTree();

            //act
            firTree.GrowUp(10.0);

            //assert
            Assert.AreEqual(10.0 , firTree.Height);
        }

        [Test]
        public void ChangeGrowthSpeed()
        {
            //arrange
            ITree firTree = new FirTree();

            //act
            firTree.GrowUp(10.0);
            firTree.GrowthSpeed = 1.3;
            firTree.GrowUp();

            //assert
            Assert.AreEqual(11.3, firTree.Height);
        }

        [Test]
        public void ColorOfFirTreeIsGreen()
        {
            //arrange
            ITree firTree = new FirTree();

            //act

            //assert
            Assert.AreEqual(TreeColor.Green, firTree.Color);
        }

        [Test]
        public void InWinterGreenAndShapely()
        {
            //arrange
            IForest testForest = new Forest();
            testForest.AddTree(new FirTree());

            //act
            while (NatureEnvironment.CurrentSeason != Season.Winter)
            {
                NatureEnvironment.ChangeSeason();
            }

            //assert
            Assert.AreEqual(Season.Winter, NatureEnvironment.CurrentSeason);
            Assert.AreEqual(TreeShape.Shapely , testForest.Trees.LastOrDefault(x => x is FirTree).Shape);
            Assert.AreEqual(TreeColor.Green, testForest.Trees.LastOrDefault(x => x is FirTree).Color);
        }

        [Test]
        public void InSummerGreenAndShapely()
        {
            //arrange
            IForest testForest = new Forest();
            testForest.AddTree(new FirTree());

            //act
            NatureEnvironment.ChangeSeason();
            NatureEnvironment.ChangeSeason();

            //assert
            Assert.AreEqual(Season.Summer, NatureEnvironment.CurrentSeason);
            Assert.AreEqual(TreeShape.Shapely, testForest.Trees.LastOrDefault(x => x is FirTree).Shape);
            Assert.AreEqual(TreeColor.Green, testForest.Trees.LastOrDefault(x => x is FirTree).Color);
        }
    }
}
