using System.Windows.Forms;

namespace FClub
{
    public class BaseUserConrol : UserControl
    {
        public void SwitchScene(Scene targetScene)
        {
            var form = this.FindForm() as MainForm;
            form.SwitchScene(targetScene);
        }
    }
}