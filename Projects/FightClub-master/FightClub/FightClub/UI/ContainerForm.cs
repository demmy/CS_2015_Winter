using System;
using System.Windows.Forms;

namespace FightClub.UI
{
    public partial class ContainerForm : Form
    {
        public ContainerForm()
        {
            InitializeComponent();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm {MdiParent = this};
            loginForm.Show();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformationForm informationForm = new InformationForm {MdiParent = this};
            informationForm.Show();
        }

        private void recordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveForm saving = new SaveForm {MdiParent = this};
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
