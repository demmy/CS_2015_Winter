using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightClubStatistics
{
    public enum Scene
    {
        Autorization,
        MenuScene,
        UserScene,
        EditUserScene,
        TransactionScene,
        EditTransactionScene
    }
    public partial class BaseUserControl : UserControl , IUserControl
    {
        public void SwitchScene(Scene targetScene)
        {
            var form = this.FindForm() as MainForm;
            form.SwitchScene(targetScene);
        }

        public void SwitchScene(Scene targetScene , Object param)
        {
            var form = this.FindForm() as MainForm;
            form.SwitchScene(targetScene , param);
        }
    }
}
