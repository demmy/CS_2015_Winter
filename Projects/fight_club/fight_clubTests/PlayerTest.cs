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
    class PlayerTest
    {
        [Test]
        public void SetBlock()
        {
            //arrange
            Player player = new Player(1, "TestPlayer", 3, 2, 3);

            //act
            player.SetBlock(BodyPart.LeftHand);

            //assert
            Assert.AreEqual(BodyPart.LeftHand , player.blockedPart);
        }

        [Test]
        public void AddExp()
        {
            //arrange
            Player player = new Player(1, "TestPlayer", 3, 2, 3);

            //act
            player.AddExp(100);

            //assert
            Assert.AreEqual(100, player.Exp);
        }

        // добавить подписку на обработку событий
        //[Test]
        //public void GetHitIfHit()
        //{
        //    //arrange
        //    Player player = new Player(1, "TestPlayer", 3, 2, 3);
        //    var fightparams = new FightPapams(1, 10);

        //    //act
        //    player.SetBlock(BodyPart.Body);
        //    player.GetHit(BodyPart.Head, fightparams);

        //    //assert
        //    Assert.AreEqual(player.MaxHp - 5, player.Hp);
        //}
    }
}
