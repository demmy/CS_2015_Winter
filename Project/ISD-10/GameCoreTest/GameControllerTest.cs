using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using GameCore;


namespace GameCoreTest
{
    [TestFixture]
    public class GameControllerTest
    {
        IPlayer player;
        IBot bot;
        IGameController controller;
        List<Character> table;
        const int bonus = 0;
        const int maxHp = 100;
        [SetUp]
        public void Init()
        {
            player = new Player();
            bot = new Bot();
            controller = new GameController(player, bot);
            table = new List<Character> 
            {
                new Character
                {
                    Name ="Player",
                    MaxHp = 1,
                    Hp = 1,
                    Strength = 1,
                    Armor = 1,
                    Bonus =1
                },
                 new Character
                {
                    Name ="Bot",
                    MaxHp = 2,
                    Hp = 2,
                    Strength = 2,
                    Armor = 2,
                    Bonus =2
                }    
            };
            player.MaxHp = maxHp;
            player.Bonus = bonus;
            bot.MaxHp = maxHp;
            bot.Bonus = bonus;
        }
        [Test]
        public void PlayerBonussSub_Substraction_One()
        {
            int bonus = player.Bonus;

            controller.PlayerBonussSub();

            Assert.AreEqual(player.Bonus, bonus - 1);
        }
        [Test]
        public void PlayerStrengthAdd_Adding_One()
        {
            int strength = player.Strength;

            controller.PlayerStrengthAdd();

            Assert.AreEqual(player.Strength, strength + 1);
        }
        [Test]
        public void PlayerStrengthSub_Substraction_One()
        {
            int strength = player.Strength;

            controller.PlayerStrengthSub();

            Assert.AreEqual(player.Strength, strength - 1);
        }
        [Test]
        public void PlayerArmorAdd_Adding_One()
        {
            int armor = player.Armor;

            controller.PlayerArmorAdd();

            Assert.AreEqual(player.Armor, armor + 1);
        }
        [Test]
        public void PlayerArmorSub_Substraction_One()
        {
            int armor = player.Armor;

            controller.PlayerArmorSub();

            Assert.AreEqual(player.Armor, armor - 1);
        }
        #region LoadPlayer
        [Test]
        public void LoadPlayer_Set_PlayeName()
        {
            controller.LoadPlayer(table);
            Assert.That(player.Name, Is.EqualTo("Player"));
        }
        [Test]
        public void LoadPlayer_Set_PlayeMaxHp()
        {
            controller.LoadPlayer(table);
            Assert.That(player.MaxHp, Is.EqualTo(1));
        }
        [Test]
        public void LoadPlayer_Set_PlayeHp()
        {
            controller.LoadPlayer(table);
            Assert.That(player.Hp, Is.EqualTo(1));
        }
        [Test]
        public void LoadPlayer_Set_PlayeStrength()
        {
            controller.LoadPlayer(table);
            Assert.That(player.Strength, Is.EqualTo(1));
        }
        [Test]
        public void LoadPlayer_Set_PlayeArmor()
        {
            controller.LoadPlayer(table);
            Assert.That(player.Armor, Is.EqualTo(1));
        }
        [Test]
        public void LoadPlayer_Set_PlayeBonus()
        {
            controller.LoadPlayer(table);
            Assert.That(player.Bonus, Is.EqualTo(1));
        }
        [Test]
        public void LoadPlayer_Set_BotName()
        {
            controller.LoadPlayer(table);
            Assert.That(bot.Name, Is.EqualTo("Bot"));
        }
        [Test]
        public void LoadPlayer_Set_BotMaxHp()
        {
            controller.LoadPlayer(table);
            Assert.That(bot.MaxHp, Is.EqualTo(2));
        }
        [Test]
        public void LoadPlayer_Set_BotHp()
        {
            controller.LoadPlayer(table);
            Assert.That(bot.Hp, Is.EqualTo(2));
        }
        [Test]
        public void LoadPlayer_Set_BotStrength()
        {
            controller.LoadPlayer(table);
            Assert.That(bot.Strength, Is.EqualTo(2));
        }
        [Test]
        public void LoadPlayer_Set_BotArmor()
        {
            controller.LoadPlayer(table);
            Assert.That(bot.Armor, Is.EqualTo(2));
        }
        [Test]
        public void LoadPlayer_Set_BotBonus()
        {
            controller.LoadPlayer(table);
            Assert.That(bot.Bonus, Is.EqualTo(2));
        }
        #endregion
        #region NextBatle
        [Test]
        public void NextBatle_PlayerHpZeroBotHpOne_MaxHpAndBonus()
        {
            player.Hp = 0;
            bot.Hp = 1;

            controller.NextBatle();

            Assert.That(player.Hp, Is.EqualTo(maxHp));
            Assert.That(player.MaxHp, Is.EqualTo(maxHp));
            Assert.That(player.Bonus, Is.EqualTo(bonus));
            Assert.That(bot.Hp, Is.EqualTo(maxHp + 20));
            Assert.That(bot.MaxHp, Is.EqualTo(maxHp + 20));
            Assert.That(bot.Bonus, Is.EqualTo(bonus + 10));
        }
        [Test]
        public void NextBatle_PlayerHpZeroBotHpMax_MaxHpAndBonus()
        {
            player.Hp = 0;
            bot.Hp = int.MaxValue;

            controller.NextBatle();

            Assert.That(player.Hp, Is.EqualTo(maxHp));
            Assert.That(player.MaxHp, Is.EqualTo(maxHp));
            Assert.That(player.Bonus, Is.EqualTo(bonus));
            Assert.That(bot.Hp, Is.EqualTo(maxHp + 20));
            Assert.That(bot.MaxHp, Is.EqualTo(maxHp + 20));
            Assert.That(bot.Bonus, Is.EqualTo(bonus + 10));
        }
        [Test]
        public void NextBatle_PlayerHpOneBotHpZero_MaxHpAndBonus()
        {
            player.Hp = 1;
            bot.Hp = 0;

            controller.NextBatle();

            Assert.That(player.Hp, Is.EqualTo(maxHp + 10));
            Assert.That(player.MaxHp, Is.EqualTo(maxHp + 10));
            Assert.That(player.Bonus, Is.EqualTo(bonus + 5));
            Assert.That(bot.Hp, Is.EqualTo(maxHp));
            Assert.That(bot.MaxHp, Is.EqualTo(maxHp));
            Assert.That(bot.Bonus, Is.EqualTo(bonus));
        }
        [Test]
        public void NextBatle_PlayerHpMaxBotHpZero_MaxHpAndBonus()
        {
            player.Hp = int.MaxValue;
            bot.Hp = 0;

            controller.NextBatle();

            Assert.That(player.Hp, Is.EqualTo(maxHp + 10));
            Assert.That(player.MaxHp, Is.EqualTo(maxHp + 10));
            Assert.That(player.Bonus, Is.EqualTo(bonus + 5));
            Assert.That(bot.Hp, Is.EqualTo(maxHp));
            Assert.That(bot.MaxHp, Is.EqualTo(maxHp));
            Assert.That(bot.Bonus, Is.EqualTo(bonus));
        }
        [Test]
        public void NextBatle_PlayerHpZeroBotHpZero_MaxHpAndBonus()
        {
            player.Hp = 0;
            bot.Hp = 0;

            controller.NextBatle();

            Assert.That(player.Hp, Is.EqualTo(maxHp + 5));
            Assert.That(player.MaxHp, Is.EqualTo(maxHp + 5));
            Assert.That(player.Bonus, Is.EqualTo(bonus));
            Assert.That(bot.Hp, Is.EqualTo(maxHp + 5));
            Assert.That(bot.MaxHp, Is.EqualTo(maxHp + 5));
            Assert.That(bot.Bonus, Is.EqualTo(bonus));
        }
        [Test]
        public void NextBatle_PlayerHpOneBotHpOne_MaxHpAndBonus()
        {
            player.Hp = 1;
            bot.Hp = 1;

            controller.NextBatle();

            Assert.That(player.Hp, Is.EqualTo(maxHp));
            Assert.That(player.MaxHp, Is.EqualTo(maxHp));
            Assert.That(player.Bonus, Is.EqualTo(bonus));
            Assert.That(bot.Hp, Is.EqualTo(maxHp));
            Assert.That(bot.MaxHp, Is.EqualTo(maxHp));
            Assert.That(bot.Bonus, Is.EqualTo(bonus));
        }
        [Test]
        public void NextBatle_PlayerHpMaxBotHpMax_MaxHpAndBonus()
        {
            player.Hp = int.MaxValue;
            bot.Hp = int.MaxValue;

            controller.NextBatle();

            Assert.That(player.Hp, Is.EqualTo(maxHp));
            Assert.That(player.MaxHp, Is.EqualTo(maxHp));
            Assert.That(player.Bonus, Is.EqualTo(bonus));
            Assert.That(bot.Hp, Is.EqualTo(maxHp));
            Assert.That(bot.MaxHp, Is.EqualTo(maxHp));
            Assert.That(bot.Bonus, Is.EqualTo(bonus));
        } 
        #endregion
        [Test]
        public void SetBotStat_RandomSet_BotStrengthBotArmor()
        {
            controller.SetBotStat();

            Assert.That(bot.Bonus, Is.EqualTo(bot.Strength + bot.Armor));
        }
    }    
}
