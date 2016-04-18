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
    public partial class PlayerCreationUserControl : BaseUserControl
    {
        int allstats = 8;    // продумать перенос в файл конфига
        public int freestats = 5;
        int oldstr = 1;
        int oldstm = 1;
        int oldagi = 1;
        int str = 1;
        int agi = 1;
        int stm = 1;
        public PlayerCreationUserControl()
        {
            InitializeComponent();
            DrawFreeStats();
        }

        private void ToMenuButton_Click(object sender, EventArgs e)
        {
            SwitchScene(Scene.Autorization);
        }

        private void PlayerCreateButton_Click(object sender, EventArgs e)
        {
            if (NewPlayerTextBox.Text != "")
            {
                if (freestats == 0)
                {
                    if (!MainForm.playerRepository.IsExist(NewPlayerTextBox.Text))
                    {
                        MainForm.playerRepository.Add(new Player(0, NewPlayerTextBox.Text, str, agi, stm));
                        MainForm.playerRepository.Save();
                        SwitchScene(Scene.Menu , MainForm.playerRepository.Get(NewPlayerTextBox.Text));
                    }
                    else
                    {
                        MessageBox.Show("This name is already taken");
                    }
                }
                else
                {
                    MessageBox.Show("Use all stats");
                }
            }
            else
            {
                MessageBox.Show("Input name");
            }
        }

        private void AgilityValue_ValueChanged(object sender, EventArgs e)
        {
            if ((allstats - str - (int)AgilityValue.Value - stm) < 0)
            {
                AgilityValue.Value = oldagi;
            }
            else
            {
                agi = (int)AgilityValue.Value;
                freestats = allstats - str - agi - stm;
                oldagi = agi;
            }
            DrawFreeStats();
        }

        private void StaminaValue_ValueChanged(object sender, EventArgs e)
        {
            if ((allstats - str - agi - (int)StaminaValue.Value) < 0)
            {
                StaminaValue.Value = oldstm;
            }
            else
            {
                stm = (int)StaminaValue.Value;
                freestats = allstats - str - agi - stm;
                oldstm = stm;
            }
            DrawFreeStats();
        }

        private void StraightValue_ValueChanged(object sender, EventArgs e)
        {
            if ((allstats - (int)StraightValue.Value - agi - stm) < 0)
            {
                StraightValue.Value = oldstr;
            }
            else
            {
                str = (int)StraightValue.Value;
                freestats = allstats - str - agi - stm;
                oldstr = str;
            }
            DrawFreeStats();
        }

        void DrawFreeStats()
        {
            LastStatsLabel.Text = freestats.ToString();
        }

        private void NewPlayerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsLetter(e.KeyChar)) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void PlayerCreationUserControl_Load(object sender, EventArgs e)
        {

        }

    }
}
