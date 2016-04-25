using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirTreeProject;

namespace FirTreeProjectTests
{
    [TestFixture]
    public class ForestTests
    {
        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        public void FirTreeWasBornInForest()
        {
            //arrange
            Forest testForest = new Forest();

            //act
            testForest.AddTree(new FirTree());

            //assert
            Assert.AreEqual(1, testForest.TreeCount);
        }

        [Test]
        public void ChangeSeason()
        {
            //arrange
            Forest testForest = new Forest();
            testForest.AddTree(new FirTree());

            //act
            testForest.ChangeSeason();

            //assert
            Assert.AreEqual(Season.Spring , testForest.CurrentSeason);
        }

        [Test]
        public void ChangeSeasonOneYear()
        {
            //arrange
            Forest testForest = new Forest();
            testForest.AddTree(new FirTree());

            //act
            testForest.ChangeSeason();
            testForest.ChangeSeason();
            testForest.ChangeSeason();
            testForest.ChangeSeason();

            //assert
            Assert.AreEqual(Season.Winter, testForest.CurrentSeason);
            //Assert.AreEqual(TreeShape.Shapely , testForest.GetTree(TreeType.FirTree).Shape);
            //Assert.AreEqual(TreeColor.Green, testForest.GetTree(TreeType.FirTree).Color);
        }

        [Test]
        public void AllUseCase()
        {
            Forest testForest = new Forest();
            testForest.AddTree(new FirTree());

            Assert.AreEqual(1 , testForest.TreeCount);  // В лесу родилась
            Assert.AreEqual(TreeType.FirTree, testForest.GetTree(TreeType.FirTree).Type);  // ёлочка
            Assert.AreEqual(Season.Winter , testForest.CurrentSeason);  // Зимой
            Assert.AreEqual(TreeShape.Shapely, testForest.GetTree(TreeType.FirTree).Shape);  // стройная
            Assert.AreEqual(TreeColor.Green, testForest.GetTree(TreeType.FirTree).Color);  // зеленая была

            testForest.ChangeSeason();
            testForest.ChangeSeason();

            Assert.AreEqual(testForest.GetTree(TreeType.FirTree).GrowingSpeed * 2, testForest.GetTree(TreeType.FirTree).Height);  // В лесу она росла
            Assert.AreEqual(Season.Summer, testForest.CurrentSeason);  // и летом
            Assert.AreEqual(TreeShape.Shapely, testForest.GetTree(TreeType.FirTree).Shape);  // стройная
            Assert.AreEqual(TreeColor.Green, testForest.GetTree(TreeType.FirTree).Color);  // зеленая была           
        }
    }
}
