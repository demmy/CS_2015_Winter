using System.Windows.Forms;

namespace fight_club
{
    public class BaseUserControl : UserControl
    {
        public void SwitchScene(Scene targetScene)
        {
            var form = this.FindForm() as MainForm;
            form.SwitchScene(targetScene);
        }

        public void SwitchScene(Scene targetScene , object par)
        {
            var form = this.FindForm() as MainForm;
            form.SwitchScene(targetScene , par);
        }

        public void SwitchScene(Scene targetScene, object par1 , object par2)
        {
            var form = this.FindForm() as MainForm;
            form.SwitchScene(targetScene, par1, par2);
        }
    }
}
