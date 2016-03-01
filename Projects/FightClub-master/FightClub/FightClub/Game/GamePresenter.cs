using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightClub
{
   public enum Level { Easy, Medium }
   public enum Hero { Striker, Defender, Usual }
   class Presenter 
   {
       IGame view;
       IPlayer player;
       IPlayer npc;
       GameController controller;
       public Presenter(IGame view, IPlayer player, IPlayer npc)
       {
           this.player = player;
           this.npc = npc;
           this.view = view;
           controller = new GameController(player, npc);

           player.Name = view.PlayerName;
           view.PlayerHp = player.HP;
           npc.Name = "Bot";
           view.BotName = npc.Name;
           view.BotHp = npc.HP;

           player.Block += player_Block;
           player.Death += player_Death;
           player.Wound += player_Wound;

           npc.Block += npc_Block;
           npc.Death += npc_Death;
           npc.Wound += npc_Wound;
           view.Battle += view_Battle;
       }

       public void Difficulty()
       {
           switch (view.difficulty)
           {
               case Level.Easy:
                  
                   switch(view.hero)
                   {
                       case Hero.Usual:
                           ChangeDmg();
                           break;
                       case Hero.Striker:
                           Striker();
                           break;
                       case Hero.Defender:
                           Defender();
                           break;
                   }
                   break;
               case Level.Medium:
                   player.Damage = 10;
                   switch (view.hero)
                   {
                       case Hero.Usual:
                           ChangeDmg();
                           break;
                       case Hero.Striker:
                           Striker();
                           break;
                       case Hero.Defender:
                           Defender();
                           break;
                   }
                   break;
           }
       }

       private void Defender()
       {
           player.BonusHp();
           player.ImproveDmg();
           ChangeDmg();
       }

       private void Striker()
       {
           npc.ImproveDmg();
           npc.BonusHp();
           ChangeDmg();
       }

       private void ChangeDmg()
       {
           view.BotDamage = npc.Damage.ToString();
           view.PlayerDamage = player.Damage.ToString();
       }

       void view_Battle(object sender, GameEventArgs e)
       {
           controller.Battle();
       }

       void npc_Wound(object sender, GameEventArgs e)
       {
           if (sender is NPC)
           {
               NPC bot = (NPC)sender;
               npc.log = String.Format("{0} {1} {2}: left Bot HP:{3}", player.Name, e.msg, bot.Name ,bot.HP);
           }
       }

       void npc_Death(object sender, GameEventArgs e)
       {
           if (sender is NPC)
           {
               StaticValues.player_count_win++;
               NPC bot = (NPC)sender;
               npc.log = String.Format("{0} {1}: left Bot HP:{2}",bot.Name, e.msg, bot.HP);
               MessageForm playerForm = new MessageForm();
               playerForm.Show();
           }
       }

       void npc_Block(object sender, GameEventArgs e)
       {
           if (sender is NPC)
           {
               NPC bot = (NPC)sender;
               npc.log = string.Format("{0} {1}: left Bot HP:{2}", bot.Name, e.msg, bot.HP);
           }
       }

       void player_Wound(object sender, GameEventArgs e)
       {
           if (sender is Player)
           {
               Player user = (Player)sender;
               player.log = String.Format("{0} {1} {2}: left {3} HP:{4}", npc.Name, e.msg, player.Name, player.Name, player.HP);
           }
       }

       void player_Death(object sender, GameEventArgs e)
       {
           if (sender is Player)
           {
               StaticValues.bot_count_win++;
               Player user = (Player)sender;
               player.log = String.Format("{0} {1}: left {2} HP:{3}", player.Name, e.msg, player.Name, player.HP);
               MessageForm endForm = new MessageForm();
               endForm.Show();
           }
       }

       void player_Block(object sender, GameEventArgs e)
       {
           if (sender is Player)
           {
               Player user = (Player)sender;
               player.log = String.Format("{0} {1}: left {2} HP:{3}", player.Name, e.msg, player.Name, player.HP);
           }
       }
   }
}
