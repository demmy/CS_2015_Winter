using System;
using NUnit.Framework;
using ISD_12;

namespace UnitTest
{
    [TestFixture]
    public class FirTreeTest
    {
        private IFirTree firTree;
        [SetUp]
        public void SetUp()
        {
            firTree = new FirTree();
        }   
        [Test]
        public void TestGrowFirTree()
        {
            firTree.GrowFirTree(2);
            Assert.That(firTree.Hight, Is.EqualTo(2));
        }
        [Test]
        public void TestTwoGrowFirTree()
        {
            firTree.GrowFirTree(2);
            firTree.GrowFirTree(3);
            Assert.That(firTree.Hight, Is.EqualTo(5));
        }
        [Test]
        public void TestColorFirTree()
        {
            string color = firTree.Color;
            Assert.That(color, Is.EqualTo("Green"));
        }
        [Test]
        public void TestFormFirTree()
        {
            string form = firTree.Form;
            Assert.That(form, Is.EqualTo("Slim"));
        }
    }
}
