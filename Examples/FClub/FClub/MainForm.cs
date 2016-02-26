using System.Windows.Forms;

namespace FClub
{
    public enum Scene
    {
        Main,
        Fight
    }

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            SwitchScene(Scene.Main);
        }

        public void SwitchScene(Scene scene)
        {
            UserControl ctrl = null;
            switch (scene)
            {
                case Scene.Main:
                    ctrl = new MainUserControl();

                    break;

                case Scene.Fight:
                    ctrl = new FightUserControl();
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