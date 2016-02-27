using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FightClubApp.FightersClasses;
using FightClubApp.Game.Inerfaces;
using FightClubApp.Inerfaces;
using FightClubApp.Game;
using System.Threading.Tasks;

namespace FightClubApp
{  
    public class GameController: IGameController
    {
        private readonly IPlayer player;
        private readonly IBot bot;
        IData data;
        
        public GameController(IPlayer player, IBot bot)
        {
            this.player = player;
            this.bot = bot;
        }
        public void Fight()
        {
            player.GetHit(bot.BotHit);
            player.SetBlock(player.BlockPart);
            bot.SetBlock(bot.BotBlock);
            bot.GetHit(player.HitPart);
        }

        public void SetHp()
        {
            player.HP = bot.HP = (int)Constant.StartHP; 
        }

        public void saveData(int fight, int win, int tie, int loss)
        {
            data = new Data(player.Name, fight, win, tie, loss);//прокинуть
            WorkWithFile stream = new WorkWithFile(data);
            stream.AddData();
        }

        

        
        

        








    }
}
