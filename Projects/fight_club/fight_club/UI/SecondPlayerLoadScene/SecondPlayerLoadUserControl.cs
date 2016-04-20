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
    public partial class SecondPlayerLoadUserControl : BaseUserControl
    {
        Player player1;
        Player player2;
        public SecondPlayerLoadUserControl()
        {
            InitializeComponent();
        }

        public SecondPlayerLoadUserControl(object par)
        {
            InitializeComponent();
            player1 = (Player)par;
        }

        private void LoginSecondPlayerButton_Click(object sender, EventArgs e)
        {

            if (PlaerNameTextBox.Text != "")
            {
                if (MainForm.playerRepository.IsExist(PlaerNameTextBox.Text))
                {
                    if (PlaerNameTextBox.Text != player1.Name)
                    {
                        SwitchScene(Scene.Combat , player1 , MainForm.playerRepository.Get(PlaerNameTextBox.Text)); 
                    }
                    else
                    {
                        MessageBox.Show("This player is already taken");
                    }
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
    }

}
