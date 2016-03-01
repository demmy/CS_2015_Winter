using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FightClubApp;
using System.Windows.Forms;

namespace FightClubApp.UI.Login
{
    public partial class LoginUserControl : BaseUserControl 
    {
        static string chooseName;

        public LoginUserControl()
        {
            InitializeComponent();
        }

        public static string ChooseName
        {

            get { return chooseName; }
        }

        public void SetName()
        {
            if (choosePlayerName.Text == string.Empty)
            {
                 chooseName = "Игрок";
            }
            else
            {
                chooseName = choosePlayerName.Text;
            }
        }

        private void toFightMenu_Click(object sender, EventArgs e)
        {
            SwitchScene(Scene.Fight);
            SetName();
        }

        private void records_Click(object sender, EventArgs e)
        {
            SwitchScene(Scene.Raiting);
        }

        private void exitGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rules_Click(object sender, EventArgs e)
        {
            SwitchScene(Scene.Rules);
        }
    }
}
