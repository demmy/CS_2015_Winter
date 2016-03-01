using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameCore;

namespace Combats
{
    public class ScorePresenter 
    {
        IScore score;
        ILog log;
        ILoader load;
        IGameController controller;            
        public ScorePresenter(IScore score)
        {             
            this.score = score;
            this.log = new Log();
            this.load = new Loader();
            this.controller = new GameController();
            score.ShowTableStat(log.ReadFile());                       
        }             
    }
}
