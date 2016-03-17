using System;
using System.Data;
using System.Windows.Forms;
using FightClub.Game;

namespace FightClub.UI
{
    public partial class LoginForm : Form
    {
        GameForm _game;
        Level _lvl;
        Style _style;
        string _str = "";
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
            Enum.TryParse(str, out _style);
        }
  
        private void enterButton_Click(object sender, EventArgs e)
        {
            HeroType();
            this.Hide();
            _game = new GameForm();
            _game.PlayerName = nameTextBox.Text;
            Enum.TryParse(_str, out _lvl);
            _game.Difficulty = _lvl;
            _game.Kind = _style;
            _game.MdiParent = this.MdiParent as ContainerForm;
            _game.Show();
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
            _str = LvlBox.SelectedValue.ToString();
        }
    }
}
