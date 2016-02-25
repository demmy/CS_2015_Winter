using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCore
{
    public class GameController : IGameController
    {
        Random ran = new Random();
        IPlayer player;
        IBot bot;
        public GameController()
        {
        }
        public GameController(IPlayer player, IBot bot)
        {
            this.player = player;
            this.bot = bot;
        }
        public void Fight(Position Hit, Position Block)
        {
            bot.Rand = ran.Next(Setup.MinHit, Setup.MaxHit);
            player.Rand = ran.Next(Setup.MinHit, Setup.MaxHit);
            player.GetHit(bot.RandomHit, bot.Damage);
            bot.SetBlock(bot.RandomBlock);
            player.SetBlock(Block);
            bot.GetHit(Hit, player.Damage);
        }
        public void SetBotStat()
        {
            bot.Strength = ran.Next(bot.Bonus + 1);
            bot.Armor = bot.Bonus - bot.Strength;
        }       
        public void NextBatle()
        {
            if (player.Hp == 0 && bot.Hp != 0)
            {                
                bot.MaxHp = bot.MaxHp + Setup.BonusHp * 2;               
                bot.Bonus += Setup.BonusStat * 2;
            }
            if (bot.Hp == 0 && player.Hp != 0)
            {
                player.MaxHp = player.MaxHp + Setup.BonusHp;                
                player.Bonus += Setup.BonusStat;
            }
            if (player.Hp == 0 && bot.Hp == 0)
            {
                player.MaxHp = player.MaxHp + Setup.BonusHp / 2;
                bot.MaxHp = bot.MaxHp + Setup.BonusHp / 2;
            }
            bot.Hp = bot.MaxHp;
            player.Hp = player.MaxHp;
            SetBotStat();
        }
        public void LoadPlayer(List<Character> table)
        {
            if (table.Count != 0)
            {
                player.Name = table[0].Name;
                player.MaxHp = table[0].MaxHp;
                player.Hp = table[0].Hp;
                player.Strength = table[0].Strength;
                player.Armor = table[0].Armor;
                player.Bonus = table[0].Bonus;
                bot.Name = table[1].Name;
                bot.MaxHp = table[1].MaxHp;
                bot.Hp = table[1].Hp;
                bot.Strength = table[1].Strength;
                bot.Armor = table[1].Armor;
                bot.Bonus = table[1].Bonus;
            }
        }
        public void PlayerBonussSub()
        {
            player.Bonus -= 1;
        }
        public void PlayerStrengthAdd()
        {
            player.Strength += 1;
        }
        public void PlayerStrengthSub()
        {
            player.Strength -= 1;
        }
        public void PlayerArmorAdd()
        {
            player.Armor += 1;
        }
        public void PlayerArmorSub()
        {
            player.Armor -= 1;
        }
    }
}
