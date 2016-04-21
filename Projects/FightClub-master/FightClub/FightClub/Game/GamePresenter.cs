using System;
using FightClub.Game.Interfaces;
using FightClub.UI;
using FightClub.UI.Interfaces;

namespace FightClub.Game
{
    public enum Level { Easy, Medium }
    public enum Style { Striker, Defender, Usual }

    internal class Presenter
    {
        readonly IGame _view;
        readonly IPlayerModel _playerModel;
        readonly IPlayerModel _npc;
        readonly GameController _controller;


        public Presenter(IGame view)
        {
            this._playerModel = new Player();
            this._npc = new Npc();
            this._view = view;
            _controller = new GameController(_playerModel, _npc);
            Settings(_view);
        }
        public Presenter(IGame view,IPlayerModel player)
        {
            this._playerModel = player;
            this._npc = new Npc();
            this._view = view;
            Settings(_view);
        }
        private void Settings(IGame view)
        {
            _playerModel.Name = view.PlayerName;
            view.PlayerHp = _playerModel.Hp;
            _npc.Name = "Bot";
            view.BotName = _npc.Name;
            view.BotHp = _npc.Hp;

            _playerModel.Block += PlayerModelBlock;
            _playerModel.Death += PlayerModelDeath;
            _playerModel.Wound += PlayerModelWound;

            _npc.Block += npc_Block;
            _npc.Death += npc_Death;
            _npc.Wound += npc_Wound;
            view.Battle += view_Battle;
        }
        public void Difficulty()
        {
            switch (_view.Difficulty)
            {
                case Level.Easy:

                    switch (_view.Kind)
                    {
                        case Style.Usual:
                            ChangeDmg();
                            break;
                        case Style.Striker:
                            Striker();
                            break;
                        case Style.Defender:
                            Defender();
                            break;
                    }
                    break;
                case Level.Medium:
                    _playerModel.Damage = 10;
                    switch (_view.Kind)
                    {
                        case Style.Usual:
                            ChangeDmg();
                            break;
                        case Style.Striker:
                            Striker();
                            break;
                        case Style.Defender:
                            Defender();
                            break;
                    }
                    break;
            }
        }

        private void Defender()
        {
            _playerModel.BonusHp();
            _playerModel.ImproveDmg();
            ChangeDmg();
        }

        private void Striker()
        {
            _npc.ImproveDmg();
            _npc.BonusHp();
            ChangeDmg();
        }

        private void ChangeDmg()
        {
            _view.BotDamage = _npc.Damage.ToString();
            _view.PlayerDamage = _playerModel.Damage.ToString();
        }
        public int BotRecovery(bool h)
        {
            int result = _npc.Recovery(h);
            return result;
        }
        public int PlayerRecovery(bool h)
        {
            int result = _playerModel.Recovery(h);
            return result;
        }
        public string PlayerName()
        {
            return _playerModel.Name;
        }

        public string PlayerLog
        {
            get { return _playerModel.Log; }
        }

        public string BotLog
        {
            get { return _npc.Log; }
        }
        public int PlayerHit
        {
            get { return _playerModel.Hit; }
            set { _playerModel.Hit = value; }
        }
        public void PlayerSetBlock(Part part)
        {
            _playerModel.SetBlock(part);
        }
        public int PlayerSet
        {
            get { return _playerModel.Set; }
        }
        public int PlayerHp()
        {
            return _playerModel.Hp;
        }
        public int Damage()
        {
            return _playerModel.Damage;
        }
        public string BotName()
        {
            return _npc.Name;
        }
        public int BotHp()
        {
            return _npc.Hp;
        }

        public int BotHit()
        {
            return _npc.Hit;
        }

        public int BotSet()
        {
            return _npc.Set;
        }
        void view_Battle(object sender, GameEventArgs e)
        {
            _controller.Battle();
        }

        void npc_Wound(object sender, GameEventArgs e)
        {
            if (!(sender is Npc)) return;
            var bot = (Npc)sender;
            _npc.Log = string.Format("{0} {1} {2}: left Bot HP:{3}", _playerModel.Name, e.msg, bot.Name, bot.Hp);
        }

        void npc_Death(object sender, GameEventArgs e)
        {
            if (!(sender is Npc)) return;
            PlayerOptions.PlayerCountWin++;
            var bot = (Npc)sender;
            _npc.Log = string.Format("{0} {1}: left Bot HP:{2}", bot.Name, e.msg, bot.Hp);
            var playerForm = new MessageForm();
            playerForm.Show();
        }

        void npc_Block(object sender, GameEventArgs e)
        {
            if (!(sender is Npc)) return;
            var bot = (Npc)sender;
            _npc.Log = string.Format("{0} {1}: left Bot HP:{2}", bot.Name, e.msg, bot.Hp);
        }

        void PlayerModelWound(object sender, GameEventArgs e)
        {
            if (!(sender is Player)) return;
            var user = (Player)sender;
            _playerModel.Log = string.Format("{0} {1} {2}: left {3} HP:{4}", _npc.Name, e.msg, _playerModel.Name, _playerModel.Name, _playerModel.Hp);
        }

        void PlayerModelDeath(object sender, GameEventArgs e)
        {
            if (!(sender is Player)) return;
            PlayerOptions.BotCountWin++;
            var user = (Player)sender;
            _playerModel.Log = String.Format("{0} {1}: left {2} HP:{3}", _playerModel.Name, e.msg, _playerModel.Name, _playerModel.Hp);
            var endForm = new MessageForm();
            endForm.Show();
        }

        void PlayerModelBlock(object sender, GameEventArgs e)
        {
            if (!(sender is Player)) return;
            var user = (Player) sender;
            _playerModel.Log = string.Format("{0} {1}: left {2} HP:{3}", _playerModel.Name, e.msg, _playerModel.Name, _playerModel.Hp);
        }
    }
}

