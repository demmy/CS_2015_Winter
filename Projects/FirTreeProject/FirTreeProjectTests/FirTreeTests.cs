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
            FirTree firTree = new FirTree();

            //act
            firTree.GrowUp(10.0);

            //assert
            Assert.AreEqual(10.0 , firTree.Height);
        }

        [Test]
        public void ChangeGrowingSpeed()
        {
            //arrange
            FirTree firTree = new FirTree();

            //act
            firTree.GrowUp(10.0);
            firTree.GrowingSpeed = 1.3;
            firTree.GrowUp();

            //assert
            Assert.AreEqual(11.3, firTree.Height);
        }

        [Test]
        public void ColorOfFirTreeIsGreen()
        {
            //arrange
            FirTree firTree = new FirTree();

            //act

            //assert
            Assert.AreEqual(TreeColor.Green, firTree.Color);
        }

        [Test]
        public void InWinterGreenAndShapely()
        {
            //arrange
            Forest testForest = new Forest();
            testForest.AddTree(new FirTree());

            //act
            //testForest.ChangeSeason();

            //assert
            Assert.AreEqual(TreeShape.Shapely , testForest.GetTree(TreeType.FirTree).Shape);
            Assert.AreEqual(TreeColor.Green, testForest.GetTree(TreeType.FirTree).Color);
        }

        [Test]
        public void InSummerGreenAndShapely()
        {
            //arrange
            Forest testForest = new Forest();
            testForest.AddTree(new FirTree());

            //act
            testForest.ChangeSeason();
            testForest.ChangeSeason();

            //assert
            Assert.AreEqual(TreeShape.Shapely, testForest.GetTree(TreeType.FirTree).Shape);
            Assert.AreEqual(TreeColor.Green, testForest.GetTree(TreeType.FirTree).Color);
        }
    }
}
