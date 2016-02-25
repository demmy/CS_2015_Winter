using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISD_10
{
    public interface IMainForm
    {
        string PlayerName { set; }
        int PlayerHp { set; }
        string BotName { set; }
        int BotHp { set; }
        int GetHit { get; }
        int GetBlock { get; }
        string Log { set; }
        event EventHandler FightClick;
    }
    public partial class MainForm : Form, IMainForm
    {
        public event EventHandler FightClick;
        int hit;
        int block;
        public MainForm()
        {
            InitializeComponent();
        }
        public string PlayerName
        {
            set { lblPlayer.Text = value; }
        }
        public int PlayerHp
        {
            set
            {
                lblPlayerXp.Text = value.ToString();
                pbPlayer.Value = value;
            }
        }
        public string BotName
        {
            set { lblBot.Text = value; }
        }
        public int BotHp
        {
            set
            {
                lblBotXp.Text = value.ToString();
                bpBot.Value = value;
            }
        }
        public int GetHit
        {
            get { return hit; }
        }
        public int GetBlock
        {
            get { return block; }
        }
        public string Log
        {
            set { txtLog.Text += value + Environment.NewLine; }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void butFight_Click(object sender, EventArgs e)
        {
            
            if (rbHeadBlock.Checked) { block = (int)Position.Head; }
            if (rbBodyBlock.Checked) { block = (int)Position.Body; }
            if (rbLegsBlock.Checked) { block = (int)Position.Legs; }
            if (rbHeadFight.Checked) { hit = (int)Position.Head; }
            if (rbBodyFight.Checked) { hit = (int)Position.Body; }
            if (rbLegsFight.Checked) { hit = (int)Position.Legs; }
            if (block == 0 || hit == 0)
            {
                return;
            }

            if (FightClick != null) { FightClick(this, EventArgs.Empty); }
            rbHeadBlock.Checked = rbBodyBlock.Checked = rbLegsBlock.Checked = false;
            rbHeadFight.Checked = rbBodyFight.Checked = rbLegsFight.Checked = false; 
        }
    }
}
