using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightClubStatistics.UI.MenuScene
{
    public partial class MenuUserControl : BaseUserControl
    {
        public MenuUserControl()
        {
            InitializeComponent();
        }

        private void toUsersControl_Click(object sender, EventArgs e)
        {
            SwitchScene(Scene.UserScene);
        }

        private void toTransactionsControl_Click(object sender, EventArgs e)
        {
            SwitchScene(Scene.TransactionScene);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toCombatLogControl_Click(object sender, EventArgs e)
        {
            
        }
    }
}
