using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FightClubApp.UI.Login;
using FightClubApp.FightersClasses;
using FightClubApp.Inerfaces;
using FightClubApp.Game.Inerfaces;
using FightClubApp.Game; 
using System.Threading.Tasks;

namespace FightClubApp
{
    public enum PartOfBody
    { Unknown, Head, Tors, Legs }
    public enum Constant //или константы
    {
        StartHP = 100,
        WoundHP = 20,
        DeathHP = 0,
        FirstRound = 1
    }


    public class Presenter
    {
        private readonly IPlayer player;
        private readonly IBot bot;
        private readonly IView view;
        private readonly ITextInfo textInfo;
        private readonly IGameController controller;
        private readonly IStatistics statistics;
        

        public Presenter(IView view)
        {
            Player player = new Player();
            Bot bot = new Bot();
            this.controller = new GameController(player, bot);
            this.textInfo = new TextInfo(player, bot, view, statistics);
            this.statistics = new Statistics(view, textInfo);

            this.player = player;
            this.bot = bot;
            this.view = view;

            view.NextFightClick += onNextFightClick;
            view.FightClick += onFightClick;
            view.Save += onSave;
            View();
            textInfo.SetMessage();
        }

        public void Setup()
        {
            player.Name = LoginUserControl.ChooseName;
            player.HitPart = view.Hit;
            player.BlockPart = view.Block;
        }
        
        public void View()
        {
            view.PlayerHp = player.HP;
            view.BotName = bot.Name;
            view.PlayerName = LoginUserControl.ChooseName;
            view.BotHp = bot.HP;
        }

        public void onFightClick(object sender, EventArgs e)
        { 
            Setup();
            controller.Fight();
            View();
        }

        public void onNextFightClick (object sender, EventArgs e)
        {
            controller.SetHp();
        }

        public void onSave (object sender, EventArgs e)
        {
            controller.saveData(textInfo.NumberOfFight, textInfo.NumberOfWin, textInfo.NumberOfTie, textInfo.NumberOfLoss);
        }

    }

}
    

