using FightClub.Game;
using FightClub.Game.Interfaces;

namespace FightClub.UI.Interfaces
{
    interface IGame
    {
        string PlayerName { get; set; }
        int PlayerHp { get; set; }
        string BotName { get; set; }
        int BotHp { get; set; }
        string BotDamage { get; set; }
        string PlayerDamage { get; set; }
        Level Difficulty { get; set; }
        Style Kind { get; set; }
        event GameForceHandler Battle;
    }
}
