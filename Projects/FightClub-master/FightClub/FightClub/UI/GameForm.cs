using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightClub
{
    public partial class GameForm : Form,IGame
    {
        const string fullpath = "Log.txt";
        StringBuilder fighterAction = new StringBuilder();
        Presenter presenter;
        IPlayer player = new Player();
        IPlayer npc = new NPC();
        public Level difficulty { get; set; }
        public Hero hero { get; set; }
        public string PlayerName
        {
            get { return userNameLabel.Text; }
            set { userNameLabel.Text = value; }
        }
        public int PlayerHp
        {
            get
            {
                return userProgressBar.Value;
            }
            set
            {
                userProgressBar.Value = value;
                userHpLabel.Text = value.ToString();
            }
        }
        public int BotHp
        {
            get
            {
                return botProgressBar.Value;
            }
            set
            {
                botProgressBar.Value = value;
                botHpLabel.Text = value.ToString();
            }
        }
        public string BotName
        {
            get { return botNameLabel.Text; }
            set { botNameLabel.Text = value; }
        }
        public string BotDamage
        {
            get { return botdamageLabel.Text; }
            set { botdamageLabel.Text = value; }
        }
        public string PlayerDamage
        {
            get { return userdamageLabel.Text; }
            set { userdamageLabel.Text = value; }
        }

        public GameForm()
        {
            InitializeComponent();
        }

        private void ShowActions()
        {
            playerHitLabel.Text = ((Parts)player.Hit).ToString();
            playerBlockLabel.Text = ((Parts)player.Set).ToString();
            botBlockLabel.Text = ((Parts)npc.Set).ToString();
            botHitLabel.Text = ((Parts)npc.Hit).ToString();
            fighterAction.AppendLine(string.Format("Bot Attack: {0} | Player Blocked: {1}", botHitLabel.Text, playerBlockLabel.Text));
            fighterAction.AppendLine(string.Format("Player Attack: {0} | Bot Blocked: {1}", playerHitLabel.Text, botBlockLabel.Text));
        }

        private void CheckHp()
        {
            if (player.HP == 0 || npc.HP == 0)
            {
                UncheckedRadiobuttons(AttackBox);
                UncheckedRadiobuttons(DefenseBox);
                fightButton.Visible = false;
                RestartBtn.Visible = true;
            }
        }

        private void UncheckedRadiobuttons(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radio = control as RadioButton;
                    radio.AutoCheck = false;
                    radio.Checked = false;
                }
            }
        }
        private void CheckedRadiobuttons(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radio = control as RadioButton;
                    radio.AutoCheck = true;
                }
            }
        }
        private void UpdateHP()
        {
            userHpLabel.Text = player.HP.ToString();
            botHpLabel.Text = npc.HP.ToString();
            userProgressBar.Value = player.HP;
            botProgressBar.Value = npc.HP;
        }
        private void UpdateLog()
        {
            logBox.Items.Add(player.log);
            logBox.Items.Add(npc.log);
        }
        private void ExchangePb()
        {
            if (hero == Hero.Striker)
            {
                userProgressBar.Maximum = player.Recovery(true);
                botProgressBar.Maximum = npc.Recovery(false);
            }
            else if (hero == Hero.Defender)
            {
                userProgressBar.Maximum = player.Recovery(false);
                botProgressBar.Maximum = npc.Recovery(true);
            }
            else
            {
                userProgressBar.Maximum = player.Recovery(true);
                botProgressBar.Maximum = npc.Recovery(true);
            }
        }
        private bool SetActions()
        {
            string result1 = "";
            string result2 = "";
            result1 = GetTextRdBtn(result1, AttackBox);
            result2 = GetTextRdBtn(result2, DefenseBox);

            try
            {
                player.Hit = (int)((Parts)Enum.Parse(typeof(Parts), result1));
                player.SetBlock((Parts)Enum.Parse(typeof(Parts), result2));
            }
            catch
            {
                MessageBox.Show("You must choose 2 blocks!", "Warning!");
                return false;
            }
            return true;
        }

        private string GetTextRdBtn(string result, GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radio = control as RadioButton;
                    if (radio.Checked)
                    {
                        result = radio.Text;
                    }
                }
            }
            return result;
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            modeLabel.Text = hero.ToString();
            lvlLabel.Text = difficulty.ToString();
            playerPictureBox.Image = FightClub.Properties.Resources.fight;
            botPictureBox.Image = FightClub.Properties.Resources.bot;
            presenter = new Presenter(this, player, npc);
            presenter.Difficulty();
            StaticValues.PlayerName = player.Name;
            StaticValues.BotName = npc.Name;
            RestartBtn.Visible = false;
            ExchangePb();
            UpdateHP();
        }
        private void fightButton_Click(object sender, EventArgs e)
        {
            userdamageLabel.Text = player.Damage.ToString();
            if(!SetActions())
            {
            return;
            }
            if (Battle != null)
                Battle(this, new GameEventArgs("Fight"));
            UpdateHP();
            UpdateLog();
            CheckHp();
            ShowActions();
        }  
        private void buttonSave_Click(object sender, EventArgs e)
        {
            string[] stringArray = fighterAction.ToString().Split('\n').ToArray();
            StreamWriter sw = File.CreateText(fullpath);
            sw.WriteLine(string.Format("Fight: {0} vs {1} ", PlayerName, npc.Name));
            sw.WriteLine(string.Format("Mode: {0}", hero.ToString()));
            sw.WriteLine(string.Format("Level difficulty: {0}", difficulty.ToString()));

            int count = 0;
            foreach (string s in logBox.Items)
            {
                sw.WriteLine(stringArray[count] +'\t'+ s);
                count++;
            }
            sw.WriteLine("End battle!");
            sw.Close();
            MessageBox.Show("Saved!");
        }

        private void RestartBtn_Click(object sender, EventArgs e)
        {
            fightButton.Visible = true;
            CheckedRadiobuttons(AttackBox);
            CheckedRadiobuttons(DefenseBox);
            logBox.Items.Clear();
            ExchangePb();
            UpdateHP();
            RestartBtn.Visible = false;
        }
        public event GameForceHandler Battle;
    }
}
