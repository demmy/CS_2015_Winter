using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightClub
{
    class GameController
    {
        Random rand = new Random();
        IPlayer player = new Player();
        IPlayer bot = new NPC();

        public GameController(IPlayer player, IPlayer bot)
        {
            this.player = player;
            this.bot = bot;
        }
        public void Battle()
        {
            bot.Hit = rand.Next(1, 4);
            player.GetHit((Parts)bot.Hit);
            bot.SetBlock((Parts)rand.Next(1, 4));
            bot.GetHit((Parts)player.Hit);
        }
    }
}
