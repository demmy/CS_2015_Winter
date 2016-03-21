/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 12.02.2016
 * Time: 11:04
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Combats;

namespace Combats
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>

    public enum Scene
    {
        Main,
        Battle
    }

    public partial class MainForm : Form
    {
        public MainForm()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

            SwitchScene(Scene.Main);

//            presenter = new MainPresenter(this);
            
            //
            // Add constructor code after the InitializeComponent() call.
            //
        }

        public void SwitchScene(Scene scene)
        {
            UserControl ctrl = null;
            switch (scene)
            {
                case Scene.Main:
                    ctrl = new MainUserControl();

                    break;

                case Scene.Battle:
                    ctrl = new BattleUserControl();
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
