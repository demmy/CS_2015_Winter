using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Enums;
using FirTree;
using FirTree.Interfaces;

namespace NunitTests
{
    [TestFixture]
    public class FirTreeTests
    {
        IForest forest;
        IFirTree firTree;
        [SetUp]
        public void SetUp()
        {
            double deltaHeight = 1.2;
            int needleLength = 11;
            int numberOfCones = 24;
            forest = new Forest();
            forest.BornFirTree(deltaHeight, needleLength, numberOfCones);
            firTree = forest.FirTrees[0];
        }

        [Test]
        public void FormFirTreeForSeason()
        {
            Nature.NextSeason();

            Shape form = firTree.Form;
            Assert.AreEqual(Shape.Shapely, form);

            Nature.NextSeason();

            form = firTree.Form;
            Assert.AreEqual(Shape.Shapely, form);
        }

        [Test]
        public void StateFirTreeForSeason()
        {
            Color state = firTree.State;
            Assert.AreEqual(Color.Green, state);
            
            Nature.NextSeason();
            Nature.NextSeason();

            state = firTree.State;
            Assert.AreEqual(Color.Green, state);
        }

        [Test]
        public void AgeFirTreeForSeason()
        {
            double age = firTree.Age;
            Assert.AreEqual(0, age);

            Nature.NextSeason();
            Nature.NextSeason();

            age = firTree.Age;
            Assert.AreEqual(0.5, age);
        }

        [Test]
        public void HeightFirTreeForSeason()
        {
            double height = firTree.Height;
            Assert.AreEqual(0, height);

            Nature.NextSeason();
            Nature.NextSeason();

            height = firTree.Height;
            Assert.AreEqual(2.4, height);

            Nature.NextSeason();
            Nature.NextSeason();
            Nature.NextSeason();

            height = firTree.Height;
            Assert.AreEqual(6, height);
        }

        [Test]
        public void SeasonActuality()
        {
            Assert.AreEqual(PartOfYear.Winter, Nature.actualSeason);

            Nature.NextSeason();
            Assert.AreEqual(PartOfYear.Spring, Nature.actualSeason);

            Nature.NextSeason();
            Assert.AreEqual(PartOfYear.Summer, Nature.actualSeason);
        }

        [Test]
        public void AgeForestForSeason()
        {
            double age = forest.Age;
            Assert.AreEqual(0, age);

            Nature.NextSeason();
            Nature.NextSeason();

            age = forest.Age;
            Assert.AreEqual(0.5, age);
        }

        [Test]
        public void FirTreeBornAndDelete()
        {
            double deltaHeight = 0.6;
            int needleLength = 12;
            int numberOfCones = 15;

            int count = forest.FirTrees.Count;
            Assert.AreEqual(1, count);

            forest.BornFirTree(deltaHeight, needleLength, numberOfCones);
            forest.BornFirTree(deltaHeight, needleLength, numberOfCones);
            forest.BornFirTree(deltaHeight, needleLength, numberOfCones);

            count = forest.FirTrees.Count;
            Assert.AreEqual(4, count);

            forest.DeleteFirTree(forest.FirTrees[1]);

            count = forest.FirTrees.Count;
            Assert.AreEqual(3, count);
        }
    }
}
