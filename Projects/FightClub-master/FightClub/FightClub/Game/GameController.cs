using System;
using FightClub.Game.Interfaces;

namespace FightClub.Game
{
    class GameController
    {
        readonly Random _rand = new Random();
        readonly IPlayerModel _playerModel;
        readonly IPlayerModel _bot;

        public GameController(IPlayerModel playerModel, IPlayerModel bot)
        {
            this._playerModel = playerModel;
            this._bot = bot;
        }
        public void Battle()
        {
            _bot.Hit = _rand.Next(1, 4);
            _playerModel.GetHit((Part)_bot.Hit);
            _bot.SetBlock((Part)_rand.Next(1, 4));
            _bot.GetHit((Part)_playerModel.Hit);
        }
    }
}
