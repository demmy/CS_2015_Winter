using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FightClub.Game;
using FightClub.Game.Interfaces;
using FightClub.UI.Interfaces;
using NUnit.Framework;

namespace FightClub.UnitTests
{
  [TestFixture]
  public  class PlayerTests
  {
      private IGame mockGame;
      private IPlayerModel player;
      private Presenter presenter;
      private bool wascalled = false;

      [SetUp]
      public void SetUp()
      {
           mockGame = GetMock();
           player = new Player();
           presenter = new Presenter(mockGame, player);
      }
      [Test]
      public void PlayerName_Equals_SameName()
      {
          Assert.AreEqual(mockGame.PlayerName, presenter.PlayerName());
      }
      [Test]
      public void PlayerHp_Equals_SameHp()
      {
          Assert.AreEqual(mockGame.PlayerHp, presenter.PlayerHp());
      }
      [Test]
      public void GetHit_PlayerReceiveDamage_ReductionHp()
      {
            for (int i = player.Hp; player.Hp > 0; i--)
            {
                player.SetBlock(Part.Body);
                player.GetHit(Part.Head);
            }
            Assert.AreEqual(presenter.PlayerHp(), player.Hp);    
       }
      [Test]
      public void GetHit_PlayerBlock_WithoutChangesHp()
      {
          for (int i = 0; i < 5; i++)
          {
              player.SetBlock(Part.Head);
              player.GetHit(Part.Head);
          }
          Assert.AreEqual(mockGame.PlayerHp, presenter.PlayerHp());
      }
      [Test]
      public void Difficulty_Medium_ImproveDamage()
      {
          mockGame.Difficulty = Level.Medium;
          presenter.Difficulty();
          player.SetBlock(Part.Body);
          player.GetHit(Part.Head);
          Assert.AreEqual(90, presenter.PlayerHp());
      }
      [Test]
      public void Style_MediumDefender_RandomDamage([Random(5, 13, 15)] int damage)
      {
          mockGame.Difficulty = Level.Medium;
          mockGame.Kind = Style.Defender;
          presenter.Difficulty();
          player.SetBlock(Part.Body);
          player.GetHit(Part.Head);
          Assert.AreEqual(damage, presenter.Damage());
      }
      [Test]
      public void BlockEvent_Work_Called()
      {
          player.Block += (o, e) => wascalled = true;
          player.SetBlock(Part.Body);
          player.GetHit(Part.Body);
          Assert.IsTrue(wascalled);
      }
      [Test]
      public void WoundEvent_Work_Called()
      {
          player.Wound += (o, e) => wascalled = true;
          player.SetBlock(Part.Head);
          player.GetHit(Part.Body);
          Assert.IsTrue(wascalled);
      }
      [Test]
      public void DeathEvent_Work_Called()
      {
          player.Death += (o, e) => wascalled = true;
          for (int i = player.Hp; player.Hp > 0; i--)
          {
              player.SetBlock(Part.Body);
              player.GetHit(Part.Head);
          }
          Assert.IsTrue(wascalled);
      }
      private IGame GetMock()
      {
            IGame mock = new FakeForm();
            mock.PlayerName = "User";
            mock.PlayerHp = 100;
            return mock;
      }
    }
}
