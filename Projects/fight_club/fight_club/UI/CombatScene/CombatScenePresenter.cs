using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fight_club
{
    public enum GameType { PvP, PvE, EvE }
    public class CombatScenePresenter
    {
        #region Fields
        CombatUserControl view = null;
        public GameControl game; // = new GameControl();
        public GameType gameType;
        public AbstractPlayer player1;
        AbstractPlayer player2;
        #endregion

        #region Constructors
        public CombatScenePresenter(CombatUserControl view, AbstractPlayer player1, AbstractPlayer player2)
        {
            game = new GameControl(player1, player2);
            this.view = view;

            if (game.player2 is NPC)
            {
                gameType = GameType.PvE;
            }
            else
            {
                gameType = GameType.PvP;
            }
            DrawPlayersInfo();
        }
        #endregion

        #region Methods
        public void DrawPlayersInfo()
        {
            view.DrawPlayersInfo(game.player1.Name, game.player1.Hp, game.player1.MaxHp, game.player2.Name, game.player2.Hp, game.player2.MaxHp);
        }

        public void EndTurn(int player1punch, int player1block, int player2punch, int player2block)
        {
            view.DrawTextLog(game.Turn((BodyPart)player1punch, (BodyPart)player1block, (BodyPart)player2punch, (BodyPart)player2block));
            DrawPlayersInfo();
        } 
        #endregion
    }
}
