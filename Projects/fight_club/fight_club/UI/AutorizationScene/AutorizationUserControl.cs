using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fight_club
{
    public partial class AutorizationUserControl : BaseUserControl
    {
        public AutorizationUserControl()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (PlaerNameTextBox.Text != "")
            {
                if (MainForm.playerRepository.IsExist(PlaerNameTextBox.Text))
                {
                    SwitchScene(Scene.Menu , MainForm.playerRepository.Get(PlaerNameTextBox.Text));
                }
                else
                {
                    MessageBox.Show("Wrong Name");
                }
            }
            else
            {
                MessageBox.Show("Input name");
            }
        }

        private void PlaerNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsLetter(e.KeyChar)) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void CreationButton_Click(object sender, EventArgs e)
        {
            SwitchScene(Scene.PlayerCreation);
        }
    }
}
