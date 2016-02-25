using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightClub
{
    public partial class MessageForm : Form
    {
        public MessageForm()
        {
            InitializeComponent();
            ShowMsg();
        }
        private void ShowMsg()
        {
            if (StaticValues.bot_count_win > StaticValues.player_count_win)
            {
                heroBox.Image = FightClub.Properties.Resources.bot;
                labelName.Text = StaticValues.BotName + " " + "win!";
            }
            else
            {
                heroBox.Image = FightClub.Properties.Resources.fight;
                labelName.Text = StaticValues.PlayerName +" "+ "win!";
            }
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
