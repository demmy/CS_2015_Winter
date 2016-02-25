using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameCore;

namespace Combats
{
    public partial class MainForm : Form, IMainForm
    {
        MainPresenter present = null;       
        Position hit = Position.Legs;
        Position block = Position.Legs;
        public MainForm()
        {            
            InitializeComponent();           
            present = new MainPresenter(this); 
        }
        public string PlayerName
        {
            get { return playerNameLbl.Text; }
            set { playerNameLbl.Text = value; }
        }
        public int PlayerHp
        {           
            get { return playerHpProgress.Value; }
            set
            {
                playerHpLbl.Text = value.ToString();
                playerHpProgress.Value = value;
            }
        }
        public int PlayerStrengthProgress
        {
            get { return playerStrengthProgress.Value; }
            set { playerStrengthProgress.Value = value; }
        }
        public int PlayerArmorProgress
        {
            get { return playerArmorProgress.Value; }
            set { playerArmorProgress.Value = value; }
        }
        public int PlayerHpMaxProgress
        {
            get { return playerHpProgress.Maximum; }
            set { playerHpProgress.Maximum = value; }
        }
        public int PlayerStrengthMaxProgress
        {
            get { return playerStrengthProgress.Maximum; }
            set { playerStrengthProgress.Maximum = value; }
        }
        public int PlayerArmorMaxProgress
        {
            get { return playerArmorProgress.Maximum; }
            set { playerArmorProgress.Maximum = value; }
        }
        public string BotName
        {
            set { botNameLbl.Text = value; }
        }
        public int BotHp
        {
            get { return botHpProgress.Value; }
            set
            {
                botHpLbl.Text = value.ToString();
                botHpProgress.Value = value;
            }
        }
        public int BotStrengthProgress
        {
            get { return botStrengthProgress.Value; }
            set { botStrengthProgress.Value = value; }
        }
        public int BotArmorProgress
        {
            get { return botArmorProgress.Value; }
            set { botArmorProgress.Value = value; }
        }
        public int BotHpMaxProgress
        {
            get { return botHpProgress.Maximum; }
            set { botHpProgress.Maximum = value; }
        }
        public int BotStrengthMaxProgress
        {
            get { return botStrengthProgress.Maximum; }
            set { botStrengthProgress.Maximum = value; }
        }
        public int BotArmorMaxProgress
        {
            get { return botArmorProgress.Maximum; }
            set { botArmorProgress.Maximum = value; }
        }
        public Position Hit
        {
            get { return hit; }
        }
        public Position Block
        {
            get { return block; }
        }
        public string Log
        {
            set { txtLog.Text += value + Environment.NewLine; }
        }
        public string LabelStat
        {
            set { bonusStatLbl.Text = value; }
        }
        public event EventHandler Fight;
        public event EventHandler NextBatle;
        public event EventHandler PlayerStrengthAdd;
        public event EventHandler PlayerArmorAdd;
        public event EventHandler Save;
        private void FightBtn_Click(object sender, EventArgs e)
        {
            playerStrengthLbl.Text = playerStrengthProgress.Value.ToString();
            playerArmorLbl.Text = playerArmorProgress.Value.ToString();
            botStrengthLbl.Text = (botStrengthProgress.Value).ToString();
            botArmorLbl.Text = (botArmorProgress.Value).ToString();
            VisibleControl();
            CheckRadioButton();
        }
        private void PlayerStrengthBtn_Click(object sender, EventArgs e)
        {
            if (PlayerStrengthAdd != null) { PlayerStrengthAdd(this, EventArgs.Empty); }
        }
        private void PlayerArmorBtn_Click(object sender, EventArgs e)
        {
            if (PlayerArmorAdd != null) { PlayerArmorAdd(this, EventArgs.Empty); }
        }
        private void NextBatleBtn_Click(object sender, EventArgs e)
        {
            if (NextBatle != null) { NextBatle(this, EventArgs.Empty); }
            UnVisibleControl();
        }
        private void RestartBtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void VisibleControl()
        {
            playerStrengthBtn.Visible = false;
            playerArmorBtn.Visible = false;
            bonusStatLbl.Visible = false;
            playerStrengthLbl.Visible = true;
            playerArmorLbl.Visible = true;
            botStrengthLbl.Visible = true;
            botArmorLbl.Visible = true;
        }
        private void UnVisibleControl()
        {
            nextBatleBtn.Enabled = false;
            playerStrengthLbl.Visible = false;
            playerArmorLbl.Visible = false;
            botStrengthLbl.Visible = false;
            botArmorLbl.Visible = false;
            playerArmorBtn.Visible = true;
            playerStrengthBtn.Visible = true;
            bonusStatLbl.Visible = true;
        }
        private void CheckRadioButton()
        {
            if (blockHeadRadioBtn.Checked) { block = Position.Head; }
            if (blockBodyRadioBtn.Checked) { block = Position.Body; }
            if (blockLegsRadioBtn.Checked) { block = Position.Legs; }
            if (hitHeadRadioBtn.Checked) { hit = Position.Head; }
            if (hitBodyRadioBtn.Checked) { hit = Position.Body; }
            if (hitLegsRadioBtn.Checked) { hit = Position.Legs; }
            if (blockHeadRadioBtn.Checked == blockBodyRadioBtn.Checked == blockLegsRadioBtn.Checked &&
                hitHeadRadioBtn.Checked == hitBodyRadioBtn.Checked == hitLegsRadioBtn.Checked)
            {
                if (playerHpProgress.Value != 0 && botHpProgress.Value != 0)
                {
                    if (Fight != null) { Fight(this, EventArgs.Empty); }
                }
            }
            autoHitCheckBox_CheckedChanged(this, EventArgs.Empty);
            if (botHpProgress.Value == 0 || playerHpProgress.Value == 0)
            {
                nextBatleBtn.Enabled = true;
            }
        }
        private void AutoHitcheckBox_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(autoHitCheckBox, "Не сбрасывать удар.");
        }
        private void autoHitCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (autoHitCheckBox.Checked == false)
            {
                blockHeadRadioBtn.Checked = blockBodyRadioBtn.Checked = blockLegsRadioBtn.Checked = false;
                hitHeadRadioBtn.Checked = hitBodyRadioBtn.Checked = hitLegsRadioBtn.Checked = false;
            }
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (Save != null) { Save(this, EventArgs.Empty); }
            MessageBox.Show("Бой успешно сохранен.");            
        }
        private void txtLog_TextChanged(object sender, EventArgs e)
        {
            txtLog.SelectionStart = txtLog.Text.Length;            
            txtLog.ScrollToCaret();
        }        
    }
}
