using FightClubStatistics.UI.MenuScene;
using FightClubStatistics.UI.TransactionScene;
using FightClubStatistics.UI.UserScene;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightClubStatistics
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SwitchScene(Scene.MenuScene);
        }

        public void SwitchScene(Scene scene)
        {
            BaseUserControl ctrl = null;
            switch (scene)
            {
                case Scene.Autorization:
                    {
                        break;
                    }
                case Scene.MenuScene:
                    {
                        ctrl = new MenuUserControl();
                        break;
                    }
                case Scene.UserScene:
                    {
                        ctrl = new UserUserControl();
                        break;
                    }
                case Scene.EditUserScene:
                    {
                        ctrl = new EditUserControl();
                        break;
                    }
                case Scene.TransactionScene:
                    {
                        ctrl = new TransactionUserControl();
                        break;
                    }
                case Scene.EditTransactionScene:
                    {
                        ctrl = new EditTransactionUserControl();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }


            if (ctrl != null)
            {
                this.MinimumSize = new Size(ctrl.Width + 15, ctrl.Height + 20);
                this.MaximumSize = new Size(ctrl.Width + 15, ctrl.Height + 20);
                mainPanel.Height = ctrl.Height + 20;
                mainPanel.Width = ctrl.Width + 15;
                this.Text = ctrl.Name.ToString();
                this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - this.Width / 2, Screen.PrimaryScreen.WorkingArea.Height / 2 - this.Height / 2);
                ctrl.Dock = DockStyle.Fill;
                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(ctrl);

            }
        }

        public void SwitchScene(Scene scene , Object param)
        {
            BaseUserControl ctrl = null;
            switch (scene)
            {
                case Scene.Autorization:
                    {
                        break;
                    }
                case Scene.UserScene:
                    {
                        ctrl = new UserUserControl();
                        break;
                    }
                case Scene.EditUserScene:
                    {
                        ctrl = new EditUserControl(param);
                        break;
                    }
                case Scene.TransactionScene:
                    {
                        ctrl = new TransactionUserControl();
                        break;
                    }
                case Scene.EditTransactionScene:
                    {
                        ctrl = new EditTransactionUserControl(param);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }


            if (ctrl != null)
            {
                this.MinimumSize = new Size(ctrl.Width + 15, ctrl.Height + 20);
                this.MaximumSize = new Size(ctrl.Width + 15, ctrl.Height + 20);
                mainPanel.Height = ctrl.Height + 20;
                mainPanel.Width = ctrl.Width + 15;
                this.Text = ctrl.Name.ToString();
                this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - this.Width / 2, Screen.PrimaryScreen.WorkingArea.Height / 2 - this.Height / 2);
                ctrl.Dock = DockStyle.Fill;
                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(ctrl);

            }
        }
    }
}
