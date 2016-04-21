using System;

namespace FightClub.Game
{
    public class GameEventArgs:EventArgs
    {
        public readonly string msg;
        public GameEventArgs(string message)
        {
            msg = message;
        }
    }
}
