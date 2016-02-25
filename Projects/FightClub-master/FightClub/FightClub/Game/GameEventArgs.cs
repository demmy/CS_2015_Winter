using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
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
