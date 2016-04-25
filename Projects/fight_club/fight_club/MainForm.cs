using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fight_club
{
    public enum Scene
    {
        Autorization,
        PlayerCreation,
        Menu,
        Combat,
        RecordTable,
        SecondPlayerLoad
    }


    public interface IMainForm
    {
    }
    public partial class MainForm : Form
    {
        public static PlayerRepository playerRepository = null;  // kostyl'

        public MainForm()
        {
            InitializeComponent();

            playerRepository = new PlayerRepository();

            SwitchScene(Scene.Autorization);
        }

        public void SwitchScene(Scene scene)
        {
            BaseUserControl ctrl = null;
            switch (scene)
            {
                case Scene.Autorization:
                    {
                        ctrl = new AutorizationUserControl();
                        break;
                    }
                case Scene.Combat:
                    {
                        ctrl = new CombatUserControl();
                        break;
                    }
                case Scene.Menu:
                    {
                        ctrl = new MenuUserControl();
                        break;
                    }
                case Scene.PlayerCreation:
                    {
                        ctrl = new PlayerCreationUserControl();
                        break;
                    }
                case Scene.RecordTable:
                    {
                        ctrl = new RecordTableUserControl();
                        break;
                    }
                case Scene.SecondPlayerLoad:
                    {
                        ctrl = new SecondPlayerLoadUserControl();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }



            if (ctrl != null)
            {
                //this.Height = ctrl.Height + 20;
                //this.Width = ctrl.Width + 15;
                this.MinimumSize = new Size(ctrl.Width + 15, ctrl.Height + 20);
                this.MaximumSize = new Size(ctrl.Width + 15, ctrl.Height + 20);
                mainPanel.Height = ctrl.Height + 20;
                mainPanel.Width = ctrl.Width + 15;
                this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - this.Width / 2, Screen.PrimaryScreen.WorkingArea.Height / 2 - this.Height / 2);
                ctrl.Dock = DockStyle.Fill;                
                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(ctrl);
                
            }
        }

        public void SwitchScene(Scene scene , object par)
        {
            BaseUserControl ctrl = null;
            switch (scene)
            {
                case Scene.Autorization:
                    {
                        ctrl = new AutorizationUserControl();
                        break;
                    }
                case Scene.Combat:
                    {
                        ctrl = new CombatUserControl(par);
                        break;
                    }
                case Scene.Menu:
                    {
                        ctrl = new MenuUserControl(par);
                        break;
                    }
                case Scene.PlayerCreation:
                    {
                        ctrl = new PlayerCreationUserControl();
                        break;
                    }
                case Scene.RecordTable:
                    {
                        ctrl = new RecordTableUserControl(par);
                        break;
                    }
                case Scene.SecondPlayerLoad:
                    {
                        ctrl = new SecondPlayerLoadUserControl(par);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            if (ctrl != null)
            {
                //this.Height = ctrl.Height + 20;
                //this.Width = ctrl.Width + 15;
                this.MinimumSize = new Size(ctrl.Width + 15, ctrl.Height + 20);
                this.MaximumSize = new Size(ctrl.Width + 15, ctrl.Height + 20);
                mainPanel.Height = ctrl.Height + 20;
                mainPanel.Width = ctrl.Width + 15;
                this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - this.Width / 2, Screen.PrimaryScreen.WorkingArea.Height / 2 - this.Height / 2);
                ctrl.Dock = DockStyle.Fill;
                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(ctrl);

            }
        }

        public void SwitchScene(Scene scene, object par1 , object par2)
        {
            BaseUserControl ctrl = null;
            ctrl = new CombatUserControl(par1 , par2);
            if (ctrl != null)
            {
                this.MinimumSize = new Size(ctrl.Width + 15, ctrl.Height + 20);
                this.MaximumSize = new Size(ctrl.Width + 15, ctrl.Height + 20);
                mainPanel.Height = ctrl.Height + 20;
                mainPanel.Width = ctrl.Width + 15;
                this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - this.Width / 2, Screen.PrimaryScreen.WorkingArea.Height / 2 - this.Height / 2);
                ctrl.Dock = DockStyle.Fill;
                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(ctrl);

            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
