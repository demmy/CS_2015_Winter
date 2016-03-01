using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightClub
{
    public partial class ContainerForm : Form
    {
        public ContainerForm()
        {
            InitializeComponent();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm mainf = new LoginForm();
            mainf.MdiParent = this;
            mainf.Show();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformationForm informationForm = new InformationForm();
            informationForm.MdiParent = this;
            informationForm.Show();
        }

        private void recordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveForm saving = new SaveForm();
            saving.MdiParent = this;
            saving.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in MdiChildren)
            {
                item.Close();
            }
        }

        private void vToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
