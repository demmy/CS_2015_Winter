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
    public partial class LoginForm : Form
    {
        GameForm game;
        Level lvl;
        Hero hero;
        string str = "";
        public LoginForm()
        {
            InitializeComponent();
        }
        private void HeroType()
        {
            string str = "";
            if (heroBox.SelectedItem != null)
            {
                str = heroBox.SelectedItem.ToString();
            }
            Enum.TryParse(str, out hero);
        }
  
        private void enterButton_Click(object sender, EventArgs e)
        {
            HeroType();
            this.Hide();
            game = new GameForm();
            game.PlayerName = nameTextBox.Text;
            Enum.TryParse(str, out lvl);
            game.difficulty = lvl;
            game.hero = hero;
            game.MdiParent = this.MdiParent as ContainerForm;
            game.Show();
            this.Close();     
        }

        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                enterButton.PerformClick();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataColumn dc = new DataColumn("Lvl");
            DataColumn dc1 = new DataColumn("Value");

            dt.Columns.Add(dc);
            dt.Columns.Add(dc1);

            dt.Rows.Add("Easy", Level.Easy);
            dt.Rows.Add("Medium", Level.Medium);
            LvlBox.DataSource = dt;
            LvlBox.DisplayMember = "Lvl";
            LvlBox.ValueMember = "Value";
        }
        private void LvlBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            str = LvlBox.SelectedValue.ToString();
        }
      
      
    }
}
