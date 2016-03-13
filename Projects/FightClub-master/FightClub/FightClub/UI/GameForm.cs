using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FightClub.Game;
using FightClub.Game.Interfaces;
using FightClub.UI.Interfaces;

namespace FightClub.UI
{
    public partial class GameForm : Form, IGame
    {
        const string Fullpath = "Log.txt";
        readonly StringBuilder _fighterAction = new StringBuilder();
        Presenter _presenter;
        public Level Difficulty { get; set; }
        public Style Kind { get; set; }
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
            playerHitLabel.Text = ((Part)_presenter.PlayerHit).ToString();
            playerBlockLabel.Text = ((Part)_presenter.PlayerSet).ToString();
            botBlockLabel.Text = ((Part)_presenter.BotSet()).ToString();
            botHitLabel.Text = ((Part)_presenter.BotHit()).ToString();
            _fighterAction.AppendLine(string.Format("Bot Attack: {0} | PlayerModel Blocked: {1}", botHitLabel.Text, playerBlockLabel.Text));
            _fighterAction.AppendLine(string.Format("PlayerModel Attack: {0} | Bot Blocked: {1}", playerHitLabel.Text, botBlockLabel.Text));
        }

        private void CheckHp()
        {
            if (_presenter.PlayerHp() == 0 || _presenter.BotHp() == 0)
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
        private void UpdateHp()
        {
            userHpLabel.Text = _presenter.PlayerHp().ToString();
            botHpLabel.Text = _presenter.BotHp().ToString();
            userProgressBar.Value = _presenter.PlayerHp();
            botProgressBar.Value = _presenter.BotHp();
        }
        private void UpdateLog()
        {
            logBox.Items.Add(_presenter.PlayerLog);
            logBox.Items.Add(_presenter.BotLog);
        }
        private void ExchangePb()
        {
            if (Kind == Style.Striker)
            {
                userProgressBar.Maximum = _presenter.PlayerRecovery(true);
                botProgressBar.Maximum = _presenter.BotRecovery(false);
            }
            else if (Kind == Style.Defender)
            {
                userProgressBar.Maximum = _presenter.PlayerRecovery(false);
                botProgressBar.Maximum = _presenter.BotRecovery(true);
            }
            else
            {
                userProgressBar.Maximum = _presenter.PlayerRecovery(true);
                botProgressBar.Maximum = _presenter.BotRecovery(true);
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
                _presenter.PlayerHit = (int)((Part)Enum.Parse(typeof(Part), result1));
                _presenter.PlayerSetBlock((Part)Enum.Parse(typeof(Part), result2));
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
        private void Restart()
        {
            fightButton.Visible = true;
            CheckedRadiobuttons(AttackBox);
            CheckedRadiobuttons(DefenseBox);
            logBox.Items.Clear();
            ExchangePb();
            UpdateHp();
            RestartBtn.Visible = false;

            playerHitLabel.Text = "0";
            playerBlockLabel.Text = "0";
            botBlockLabel.Text = "0";
            botHitLabel.Text = "0";
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            modeLabel.Text = Kind.ToString();
            lvlLabel.Text = Difficulty.ToString();
            playerPictureBox.Image = FightClub.Properties.Resources.fight;
            botPictureBox.Image = FightClub.Properties.Resources.bot;
            _presenter = new Presenter(this);
            _presenter.Difficulty();
            PlayerOptions.PlayerName = _presenter.PlayerName();
            PlayerOptions.BotName = _presenter.BotName();
            RestartBtn.Visible = false;
            ExchangePb();
            UpdateHp();
        }
        private void fightButton_Click(object sender, EventArgs e)
        {
            userdamageLabel.Text = _presenter.Damage().ToString();
            if (!SetActions())
            {
                return;
            }
            if (Battle != null)
                Battle(this, new GameEventArgs("Fight"));
            UpdateHp();
            UpdateLog();
            CheckHp();
            ShowActions();
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            string[] stringArray = _fighterAction.ToString().Split('\n').ToArray();
            StreamWriter sw = File.CreateText(Fullpath);
            sw.WriteLine(string.Format("Fight: {0} vs {1} ", PlayerName, _presenter.BotName()));
            sw.WriteLine(string.Format("Mode: {0}", Kind.ToString()));
            sw.WriteLine(string.Format("Level difficulty: {0}", Difficulty.ToString()));

            int count = 0;
            foreach (string s in logBox.Items)
            {
                sw.WriteLine(stringArray[count] + '\t' + s);
                count++;
            }
            sw.WriteLine("End battle!");
            sw.Close();
            MessageBox.Show("Saved!");
        }

        private void RestartBtn_Click(object sender, EventArgs e)
        {
            Restart();
        }
        public event GameForceHandler Battle;
    }
}
