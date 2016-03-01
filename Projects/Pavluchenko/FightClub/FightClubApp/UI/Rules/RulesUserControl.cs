using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightClubApp.UI.Rules
{
    public partial class RulesUserControl : BaseUserControl
    {
        public RulesUserControl()
        {
            InitializeComponent();
        }

        private void toMenu_Click(object sender, EventArgs e)
        {
            SwitchScene(Scene.Login);
        }
    }
}
