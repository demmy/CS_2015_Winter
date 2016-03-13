using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightClubApp.UI
{
    public partial class BaseUserControl : UserControl
    {
        public void SwitchScene(Scene targetScene)
        {
            var form = this.FindForm() as MainForm;
            form.SwitchScene(targetScene);
        }
    }
}
