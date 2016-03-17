using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FirTree;
using Enums;

namespace NunitTests
{
    [TestFixture]
    public class FirTreeTests
    {
        Forest forest;
        [SetUp]
        public void SetUp()
        {
            forest = new Forest(PartOfYear.Winter);
            forest.FirTreeBorn(); 
        }

        [Test]
        public void FormFirTreeForSeason()
        {
            // ёлочка родилась (зимой. должна быть стройной)

            Shape form = forest.GetFormFirTree();
            Assert.AreEqual(Shape.Shapely, form);

            forest.NextSeason(); // весна
            // в описании ничего не указано по поводу формы ёлочки весной и осенью
            // стройность в эти сезоны не должна быть определена

            form = forest.GetFormFirTree();
            Assert.AreEqual(Shape.Unknown, form);

            forest.NextSeason(); // лето. ёлочка по условию опять стройная
            form = forest.GetFormFirTree();
            Assert.AreEqual(Shape.Shapely, form);

            forest.NextSeason(); // осень. стройность неизвестна
            form = forest.GetFormFirTree();
            Assert.AreEqual(Shape.Unknown, form);
        }

        [Test]
        public void ConditionFirTreeForSeason()
        {
            //цвет ёлочки меняется по сезонам аналогично форме
            
            Colour condition = forest.GetConditionFirTree();
            Assert.AreEqual(Colour.Green, condition);

            forest.NextSeason(); 
            condition = forest.GetConditionFirTree();
            Assert.AreEqual(Colour.Unknown, condition);

            forest.NextSeason(); 
            condition = forest.GetConditionFirTree();
            Assert.AreEqual(Colour.Green, condition);

            forest.NextSeason();
            condition = forest.GetConditionFirTree();
            Assert.AreEqual(Colour.Unknown, condition);
        }

        [Test]
        public void AgeFirTreeForSeason()
        {
            //при рождении ёлочки ее возраст = 0
            //с каждым новым сезоном возраст увеличивается на 0,25 года (константа)

            double age = forest.GetAgeFirTree();
            Assert.AreEqual(0, age);

            forest.NextSeason();
            forest.NextSeason();
            
            age = forest.GetAgeFirTree();
            Assert.AreEqual(0.5, age);
        }

        [Test]
        public void HeightFirTreeForSeason()
        {
            //при рождении ёлочки ее рост = 0
            //с каждым новым сезоном возраст увеличивается на 0,5 метра (константа)

            double height = forest.GetHeightFirTree();
            Assert.AreEqual(0, height);

            forest.NextSeason();
            forest.NextSeason();

            height = forest.GetHeightFirTree();
            Assert.AreEqual(1, height);
        }
        [Test]
        public void SeasonActuality()
        {
            //циклическая последовательность сезонов зима -> весна -> лето -> осень и тд.
            Assert.AreEqual(PartOfYear.Winter, forest.ActualSeason);

            forest.NextSeason();
            Assert.AreEqual(PartOfYear.Spring, forest.ActualSeason);

            forest.NextSeason();
            Assert.AreEqual(PartOfYear.Summer, forest.ActualSeason);

            forest.NextSeason();
            Assert.AreEqual(PartOfYear.Autumn, forest.ActualSeason);

            forest.NextSeason();
            Assert.AreEqual(PartOfYear.Winter, forest.ActualSeason);
        }

        [Test]
        public void AgeForestForSeason()
        {
            //при рождении леса его возраст = 0
            //с каждым новым сезоном возраст увеличивается на 0,25 года

            double age = forest.Age;
            Assert.AreEqual(0, age);

            forest.NextSeason();
            forest.NextSeason();

            age = forest.Age;
            Assert.AreEqual(0.5, age);
        }
    }
}
