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
            IForest testForest = new Forest();

            //act
            testForest.AddTree(new FirTree());

            //assert
            Assert.AreEqual(1, testForest.TreeCount);
            Assert.IsTrue(testForest.Trees.FirstOrDefault() is FirTree);
        }

        [Test]
        public void ChangeSeason()
        {
            //arrange
            while (NatureEnvironment.CurrentSeason != Season.Winter)
            {
                NatureEnvironment.ChangeSeason();
            }

            //act
            NatureEnvironment.ChangeSeason();

            //assert
            Assert.AreEqual(Season.Spring , NatureEnvironment.CurrentSeason);
        }

        [Test]
        public void ChangeSeasonOneYear()
        {
            //arrange
            while (NatureEnvironment.CurrentSeason != Season.Winter)
            {
                NatureEnvironment.ChangeSeason();
            }
            Season seasonYearAgo = NatureEnvironment.CurrentSeason;

            //act
            NatureEnvironment.ChangeSeason();
            NatureEnvironment.ChangeSeason();
            NatureEnvironment.ChangeSeason();
            NatureEnvironment.ChangeSeason();

            //assert
            Assert.AreEqual(seasonYearAgo, NatureEnvironment.CurrentSeason);
        }

        [Test]
        public void AllUseCase()
        {
            IForest testForest = new Forest();
            testForest.AddTree(new FirTree());
            while (NatureEnvironment.CurrentSeason != Season.Winter)
            {
                NatureEnvironment.ChangeSeason();
            }

            Assert.AreEqual(1 , testForest.TreeCount);  // В лесу родилась
            Assert.IsTrue(testForest.Trees.LastOrDefault() is FirTree);  // ёлочка
            Assert.AreEqual(Season.Winter , NatureEnvironment.CurrentSeason);  // Зимой
            Assert.AreEqual(TreeShape.Shapely, testForest.Trees.LastOrDefault(x => x is FirTree).Shape);  // стройная
            Assert.AreEqual(TreeColor.Green, testForest.Trees.LastOrDefault(x => x is FirTree).Color);  // зеленая была

            NatureEnvironment.ChangeSeason();
            NatureEnvironment.ChangeSeason();

            Assert.AreEqual(testForest.Trees.LastOrDefault(x => x is FirTree).GrowthSpeed * 2, testForest.Trees.LastOrDefault(x => x is FirTree).Height);  // В лесу она росла
            Assert.AreEqual(Season.Summer, NatureEnvironment.CurrentSeason);  // и летом
            Assert.AreEqual(TreeShape.Shapely, testForest.Trees.LastOrDefault(x => x is FirTree).Shape);  // стройная
            Assert.AreEqual(TreeColor.Green, testForest.Trees.LastOrDefault(x => x is FirTree).Color);  // зеленая была           
        }
    }
}
