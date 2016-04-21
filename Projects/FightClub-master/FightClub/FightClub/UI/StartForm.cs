using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightClub.UI
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            timer.Start();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.logo;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.3;
            if (this.Opacity == 1) 
            {
                timer.Stop();
            }
        }
    }
}
