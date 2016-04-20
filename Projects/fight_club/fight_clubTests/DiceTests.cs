using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fight_club;

namespace fight_clubTests
{
    [TestFixture]
    class DiceTests
    {
        [Test]
        public void Throw()
        {
            //arrange
            //var number = 0;

            //act
            //number = Dice.Throw();

            //assert
            for (int i = 0; i < 100; i++)
            {
                Assert.LessOrEqual(Dice.Throw(), 20);
                Assert.GreaterOrEqual(Dice.Throw(), 1);
            }
            //for (int i = 0; i < 100; i++)
            //{
                
            //}
        }
    }
}
