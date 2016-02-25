using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCore
{
    public interface IGameController
    {
        void Fight(Position Hit, Position Block);
        void SetBotStat();       
        void NextBatle();
        void LoadPlayer(List<Character> table);
        void PlayerBonussSub();
        void PlayerStrengthAdd();
        void PlayerStrengthSub();
        void PlayerArmorAdd();
        void PlayerArmorSub();
    }
}
