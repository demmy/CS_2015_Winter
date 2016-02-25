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
    }
}
