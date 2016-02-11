using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_10
{

    public class Presenter
    {
        private readonly IPlayer _player;
        private readonly IBot _bot;
        private readonly IMainForm _view;


        public Presenter(IPlayer player, IMainForm view, IBot bot)
        {
            _player = player;
            _bot = bot;
            _view = view;

            _view.PlayerName = _player.PlayerName;
            _view.BotName = _bot.BotName;
            _view.PlayerHp = _player.PlayerHp;
            _view.BotHp = _bot.BotHp;

            _view.FightClick += _view_FightClick;

            _player.Wound += _player_Wound;
            _player.Block += _player_Block;
            _player.Death += _player_Death;
            _bot.Wound += _bot_Wound;
            _bot.Block += _bot_Block;
            _bot.Death += _bot_Death;
        }

        void _bot_Death(int damage, int xp, string name)
        {
            _view.Log = "Игрок " + name.ToUpper() + " повержен " + xp + "хп.";
        }

        void _bot_Block(int damage, int xp, string name)
        {
            _view.Log = "Игрок " + name.ToUpper() + " заблокировал удар ";
        }

        void _bot_Wound(int damage, int xp, string name)
        {
            _view.Log = "Игрок " + name.ToUpper() + " получил урон " + damage + " хп. " + " Осталось " + xp + " хп. ";
        }

        void _player_Death(int damage, int xp, string name)
        {
            _view.Log = "Игрок " + name.ToUpper() + " повержен " + xp + "хп."; 
        }

        void _player_Block(int damage, int xp, string name)
        {
            _view.Log = "Игрок " + name.ToUpper() + " заблокировал удар ";
        }

        void _player_Wound(int damage, int xp, string name)
        {
            _view.Log = "Игрок "+name.ToUpper()+" получил урон "+damage+" хп. " + " Осталось " +xp +" хп. ";
        }  
        void _view_FightClick(object sender, EventArgs e)
        {
            _player.SetBlock((Position)_view.GetBlock);
            _player.GetHit((Position)_bot.RandomHit);
            _bot.SetBlock((Position)_bot.RandomBlock);
            _bot.GetHit((Position)_view.GetHit);

            _view.BotHp = _bot.BotHp;
            _view.PlayerHp = _player.PlayerHp;
        }
    }
}
