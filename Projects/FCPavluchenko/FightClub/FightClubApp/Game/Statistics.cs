using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FightClubApp.Inerfaces;
using System.Windows.Forms;
using FightClubApp.UI.Fight;
using System.Threading.Tasks;
using FightClubApp.FightersClasses;

namespace FightClubApp
{
    
    class Statistics: IStatistics
    {
        int hitLegs = 0;
        int hitTors = 0;
        int hitHead = 0;
        int blockLegs = 0;
        int blockTors = 0;
        int blockHead = 0;
        private readonly IView view;
        private readonly ITextInfo textInfo;

        public Statistics(IView view, ITextInfo textInfo)
        {
            this.view = view;
            this.textInfo = textInfo;
            view.FightClick += onFightClick;
            view.StatisticsClick += onStatisticsClick;
            view.NextFightClick += onNextFightClick;
        }
        public int HitLegs
        {
            get { return hitLegs; }
        }
        public int HitTors
        {
            get { return hitTors; }
        }
        public int HitHead
        {
            get { return hitHead; }
        }
        public int BlockLegs
        {
            get { return blockLegs; }
        }
        public int BlockTors
        {
            get { return blockTors; }
        }
        public int BlockHead
        {
            get { return blockHead; }
        }
        public void ShowInfo()
        {
            int round = hitHead + hitLegs + hitTors;

            StringBuilder s = new StringBuilder();
            s.AppendFormat("Количество проведенных раундов: {0}", round).AppendLine().AppendLine(); 
            s.Append("Статистика ударов игрока: ").AppendLine();
            s.AppendFormat("В голову: {0}\nВ корпус: {1}\nВ ноги:{2}\n", hitHead, hitTors, hitLegs).AppendLine();
            s.Append("Статистика блоков игрока: ").AppendLine();
            s.AppendFormat("Голова: {0}\nКрпус: {1}\nНоги:{2}\n", blockHead, blockTors, blockLegs).AppendLine();
            s.AppendFormat("Всего за эту сессию боев: {0}\nиз них побед: {1}, ничьи: {2}, поражений: {3}",
                            textInfo.NumberOfFight, textInfo.NumberOfWin, textInfo.NumberOfTie, textInfo.NumberOfLoss);
 
            MessageBox.Show(s.ToString(), "Итоги боя", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }

        public void FightStatis()
        {
            switch (view.Block)
            {
                case PartOfBody.Unknown:
                    break;
                case PartOfBody.Head:
                    blockHead++;
                    break;
                case PartOfBody.Tors:
                    blockTors++;
                    break;
                case PartOfBody.Legs:
                    blockLegs++;
                    break;
                default:
                    break;
            }
            switch (view.Hit)
            {
                case PartOfBody.Unknown:
                    break;
                case PartOfBody.Head:
                    hitHead++;
                    break;
                case PartOfBody.Tors:
                    hitTors++;
                    break;
                case PartOfBody.Legs:
                    hitLegs++;
                    break;
                default:
                    break;
            }
        }
        private void onStatisticsClick(object sender, EventArgs e)
        {
            ShowInfo();
        }

        public void onFightClick(object sender, EventArgs e)
        {
            FightStatis();
        }

        public void onNextFightClick (object sender, EventArgs e)
        {
            hitLegs = hitTors = hitHead = blockLegs = blockTors = blockHead = 0;
        }


       
        
    }
}
