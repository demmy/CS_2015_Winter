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
        public SecondPlayerLoadUserControl()
        {
            InitializeComponent();
        }

        private void LoginSecondPlayerButton_Click(object sender, EventArgs e)
        {

            if (PlaerNameTextBox.Text != "")
            {
                if (MainForm.playerRepository.IsExist(PlaerNameTextBox.Text))
                {
                    if (PlaerNameTextBox.Text != MainForm.FirstPlayer.Name)
                    {
                        // подгрузка вторго игрока в бой , проверка если != первый игрок
                        MainForm.SecondPlayer = MainForm.playerRepository.Get(PlaerNameTextBox.Text);
                        // new Game
                        SwitchScene(Scene.Combat); 
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
