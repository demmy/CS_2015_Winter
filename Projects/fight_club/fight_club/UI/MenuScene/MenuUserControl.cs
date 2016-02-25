using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fight_club
{
    public partial class MenuUserControl : BaseUserControl
    {
        //Player MainPlayer;
        public MenuUserControl()
        {
            InitializeComponent();
            DrawPlayerInfo(MainForm.FirstPlayer);  // delete or change
        }

        void DrawPlayerInfo(Player player)
        {
            PlayerNameLabel.Text = player.Name;
            PlayerExpLabel.Text = player.Exp.ToString();
        }

        private void PveEnterButton_Click(object sender, EventArgs e)
        {
            // new Game
            SwitchScene(Scene.Combat);
        }

        private void PvpEnterButton_Click(object sender, EventArgs e)
        {
            SwitchScene(Scene.SecondPlayerLoad);
            //SwitchScene(Scene.Combat);
        }

        private void RecordTableButton_Click(object sender, EventArgs e)
        {
            SwitchScene(Scene.RecordTable);
        }

        private void ChangePlayerButton_Click(object sender, EventArgs e)
        {
            MainForm.FirstPlayer = null;
            SwitchScene(Scene.Autorization);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuUserControl_Load(object sender, EventArgs e)
        {
            DrawPlayerInfo(MainForm.FirstPlayer);
        }
    }
}
