using System;
using System.Windows.Forms;

namespace FightClub.UI
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
            if (PlayerOptions.BotCountWin > PlayerOptions.PlayerCountWin)
            {
                heroBox.Image = FightClub.Properties.Resources.bot;
                labelName.Text = PlayerOptions.BotName + " " + "win!";
            }
            else
            {
                heroBox.Image = FightClub.Properties.Resources.fight;
                labelName.Text = PlayerOptions.PlayerName +" "+ "win!";
            }
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
