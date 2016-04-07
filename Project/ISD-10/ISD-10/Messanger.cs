using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameCore;

namespace Combats
{    
    public class Messanger : IMessanger
    {
        IPlayer player;
        IBot bot;
        IMainForm view;
        StringBuilder str = new StringBuilder();
        public Messanger(IPlayer player, IBot bot, IMainForm view)
        {
            this.player = player;
            this.bot = bot;
            this.view = view;
        }
        public void Message()
        {
            player.Wound += player_Wound;
            player.Block += player_Block;
            player.Death += player_Death;
            bot.Wound += player_Wound;
            bot.Block += player_Block;
            bot.Death += player_Death;
        }
        private void player_Wound(object sender, InfoEventArgs e)
        {
            str.Append("Игрок ");
            str.Append(e.Name.ToUpper());
            str.Append(" получил урон ");
            str.Append(e.Damage);
            str.Append(" хп. ");
            str.Append(" Осталось ");
            str.Append(e.Hp);
            str.Append(" хп. ");
            view.Log = str.ToString();
            str.Clear();
        }
        private void player_Block(object sender, InfoEventArgs e)
        {
            str.Append("Игрок ");
            str.Append(e.Name.ToUpper());
            str.Append(" заблокировал удар ");
            view.Log = str.ToString();
            str.Clear();
        }
        private void player_Death(object sender, InfoEventArgs e)
        {
            str.Append("Игрок ");
            str.Append(e.Name.ToUpper());
            str.Append(" получил урон ");
            str.Append(e.Damage);
            str.Append(" хп. ");
            str.Append(" Осталось ");
            str.Append(e.Hp);
            str.AppendLine(" хп. ");
            str.Append("Игрок ");
            str.Append(e.Name.ToUpper());
            str.Append(" повержен ");
            view.Log = str.ToString();
            str.Clear();
        }
    }
}
