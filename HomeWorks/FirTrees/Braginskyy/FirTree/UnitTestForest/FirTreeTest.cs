using FirTreeApp;
using FirTreeApp.Interfaces;
using FirTreeApp.Season;
using FirTreeApp.Trees;
using NUnit.Framework;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestForest.Interfaces
{
    [TestFixture]
    public class FirTreeTest
    {
        private IFirTree firTree;
        [SetUp]
        public void Setup()
        {
            firTree = new FirTree();
        }
        [Test]
        public void SummerGrow()
        {
            int height = firTree.Height;
            ISeason summer = Mock.Of<ISeason>(d => d.NameOfSeason == "Summer");
            firTree.Grow(summer);
            Assert.That(firTree.Height, Is.EqualTo(height + 7));
        }
        [Test]
        public void SummerGrowNegative()
        {
            int height = firTree.Height;
            ISeason summer = Mock.Of<ISeason>(d => d.NameOfSeason == "Summer");
            firTree.Grow(summer);
            Assert.That(firTree.Height - height, Is.GreaterThanOrEqualTo(0));
        }
        [Test]
        public void SummerChangeColor()
        {
            ISeason summer = Mock.Of<ISeason>(d => d.NameOfSeason == "Summer");
            firTree.ChangeColor(summer);
            Assert.That(firTree.Color, Is.EqualTo("Green"));
        }
        [Test]
        public void SummerAgeIncrease()
        {
            ISeason summer = Mock.Of<ISeason>(d => d.NameOfSeason == "Summer");
            int age = firTree.Age;
            firTree.Grow(summer);
            Assert.That(firTree.Age, Is.EqualTo(age + 1));
        }
        [Test]
        public void TenSummerAgeIncrease()
        {
            ISeason summer = Mock.Of<ISeason>(d => d.NameOfSeason == "Summer");
            int age = firTree.Age;
            for (int i = 0; i < 10; i++)
            {
                firTree.Grow(summer);
            }
            Assert.That(firTree.Age, Is.EqualTo(age + 10));
        }
        [Test]
        public void WinterGrow()
        {
            int height = firTree.Height;
            ISeason winter = Mock.Of<ISeason>(d => d.NameOfSeason == "Winter");
            firTree.Grow(winter);
            Assert.That(firTree.Height, Is.EqualTo(height));
        }
        [Test]
        public void WinterGrowNegative()
        {
            int height = firTree.Height;
            ISeason winter = Mock.Of<ISeason>(d => d.NameOfSeason == "Winter");
            firTree.Grow(winter);
            Assert.That(firTree.Height - height, Is.GreaterThanOrEqualTo(0));
        }
        [Test]
        public void WinterChangeColor()
        {
            ISeason winter = Mock.Of<ISeason>(d => d.NameOfSeason == "Winter");
            firTree.ChangeColor(winter);
            Assert.That(firTree.Color, Is.EqualTo("Green"));
        }
        [Test]
        public void WinterAgeIncrease()
        {
            ISeason winter = Mock.Of<ISeason>(d => d.NameOfSeason == "Winter");
            int age = firTree.Age;
            firTree.Grow(winter);
            Assert.That(firTree.Age, Is.EqualTo(age));
        }
        [Test]
        public void TenWinterAgeIncrease()
        {
            ISeason winter = Mock.Of<ISeason>(d => d.NameOfSeason == "Winter");
            int age = firTree.Age;
            for (int i = 0; i < 10; i++)
            {
                firTree.Grow(winter);
            }
            Assert.That(firTree.Age, Is.EqualTo(age));
        }
        [Test]
        public void ConeExistenceAfterFourYears()
        {
            ISeason summer = Mock.Of<ISeason>(d => d.NameOfSeason == "Summer");
            for (int i = 1; i <= 4; i++)
            {
                firTree.Grow(summer);
            }
            Assert.That(firTree.Cones, Is.EqualTo(false));
        }
        [Test]
        public void ConeExistenceAfterFiveYears()
        {
            ISeason summer = Mock.Of<ISeason>(d => d.NameOfSeason == "Summer");
            for (int i = 1; i <= 5; i++)
            {
                firTree.Grow(summer);
            }
            Assert.That(firTree.Cones, Is.EqualTo(true));

        }
    }
}
