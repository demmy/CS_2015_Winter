using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FightClub.UI.Interfaces;

namespace FightClub.UnitTests
{
    class FakeForm:IGame
    {
        public string PlayerName { get; set; }
        public int PlayerHp { get; set; }
        public string BotName { get; set; }
        public int BotHp
        {
            get;
            set;
        }
        public string BotDamage
        {
            get;
            set;
        }
        public string PlayerDamage
        {
            get;
            set;

        }
        public FightClub.Game.Level Difficulty
        {
            get;
            set;
        }
        public Game.Style Kind { get; set; }

        public event Game.Interfaces.GameForceHandler Battle;
    }
}
