using System;
using System.Collections.Generic;
using System.Linq;
using FightClubApp.FightersClasses;
using System.Windows.Forms;
using System.Text;
using FightClubApp.UI.Fight;
using FightClubApp.Inerfaces;
using System.Threading.Tasks;

namespace FightClubApp
{
    

    class TextInfo: ITextInfo
    {
        IStatistics statistics;
        IPlayer player;
        IBot bot;
        IView view;
        int numberOfFight = 0;
        int numberOfTie = 0;
        int numberOfWin = 0;
        int numberOfLoss = 0;

        public int NumberOfFight
        {
            get { return numberOfFight; }
        }
        public int NumberOfTie
        {
            get { return numberOfTie; }
        }
        public int NumberOfWin
        {
            get { return numberOfWin; }
        }
        public int NumberOfLoss
        {
            get { return numberOfLoss; }
        }

        public TextInfo(IPlayer player, IBot bot, IView view, IStatistics statistics)
        {
            this.player = player;
            this.bot = bot;
            this.view = view;
            this.statistics = statistics;
        }


        public void SetMessage()
        {
            player.Wound += onWound;
            player.Block += onBlock;
            player.Death += onDeath;
            bot.Wound += onWound;
            bot.Block += onBlock;
            bot.Death += onDeath;
            view.EndRound += onEndRound;
            view.Save += onSave;
        }

        public string PatrtToString(PartOfBody part)
        {
            string result = "";
            switch (part)
            {
                case PartOfBody.Unknown:
                    break;
                case PartOfBody.Head:
                    result = "голову";
                    break;
                case PartOfBody.Tors:
                    result = "корпус";
                    break;
                case PartOfBody.Legs:
                    result = "ноги";
                    break;
                default:
                    break;
            }
            return result;
        }

        public void WinnerName()
        {
            string info;

            if (player.HP == (int)Constant.DeathHP && bot.HP == (int)Constant.DeathHP)
            {
                view.Log = info = "Бой не выявил победителя. Пали оба бойца...";
                MessageBox.Show(info, "Бой окончен", MessageBoxButtons.OK);
                numberOfTie++;
                numberOfFight++;

            }
            else if (bot.HP == (int)Constant.DeathHP)
            {
                view.Log = info = player.Name +  " победил!";
                MessageBox.Show(info, "Бой окончен", MessageBoxButtons.OK);
                numberOfWin++;
                numberOfFight++;
            }
            else
            {
                view.Log = info = "Победил Бот!";
                MessageBox.Show(info, "Бой окончен", MessageBoxButtons.OK);
                numberOfLoss++;
                numberOfFight++;
            }
        }


        private void onWound(object sender, MyEventArgs e)
        {
            view.Log =  e.Name + " неудачно защищал " + PatrtToString(e.Block) + " и получил удар в " 
                        + PatrtToString(e.Part) + ". " + e.Hp + " hp осталось.";
        }

        private void onBlock(object sender, MyEventArgs e)
        {
            view.Log = e.Name + " успешно защитил " + PatrtToString(e.Block) + ". Удар не прошел и у него по прежнему остается " + e.Hp + " hp.";
        }

        private void onDeath(object sender, MyEventArgs e)
        {
            view.Log = e.Name + " побежден, с " + e.Hp + " hp он больше не может сопротивляться.";
        }

        private void onEndRound(object sender, EventArgs e)
        {
            view.Log = "Схватка окончена.";
            WinnerName();
        }

        private void onSave(object sender, EventArgs e)
        {
            MessageBox.Show("Сохранение прошло успешно", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
