using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FightClubApp.UI.Login;
using FightClubApp.UI.Fight;
using FightClubApp.UI.Rules;
using FightClubApp.UI.Raiting;
using System.Windows.Forms;

namespace FightClubApp
{
    public enum Scene
    {
        Login,
        Raiting,
        Fight,
        Rules
    }
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SwitchScene(Scene.Login);
        }

        public void SwitchScene(Scene scene)
        {
            UserControl ctrl = null;
            switch (scene)
            {
                case Scene.Login:
                    ctrl = new LoginUserControl();
                    break;

                case Scene.Fight:
                    ctrl = new FightUserControl();
                    break;
                case Scene.Raiting:
                    ctrl = new RaitingUserControl();
                    break;
                case Scene.Rules:
                    ctrl = new RulesUserControl();
                    break;

                default:
                    break;
            }
            if (ctrl != null)
            {
                ctrl.Dock = DockStyle.Fill;
                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(ctrl);
            }
        }
        
    }
}
