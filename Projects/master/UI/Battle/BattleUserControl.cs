/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 25.02.2016
 * Time: 9:59
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Combats
{
    /// <summary>
    /// Description of BattleUserControl.
    /// </summary>
    public partial class BattleUserControl : BaseUserConrol, IBattlePageView
    {
        BattlePresenter Battle;
        public BattleUserControl()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            Battle = new BattlePresenter(this);
        }
        

        void ButtonNewGameClick(object sender, EventArgs e)
        {
            RadioButtons.Visible = true;
            NewBattle.Visible = false;
            BattleLog.Clear();
            Battle = new BattlePresenter(this);
        }

        public void CreateRadioButtons()
        {
            NewRadioButtonPanel("Attack");
            NewRadioButtonPanel("Block");
        }

        void NewRadioButtonPanel(string type)
        {
            int items = Enum.GetNames(typeof(BodyPart)).Length;
            RadioButton[] newPanel = new RadioButton[items];
            for (int i = 1, point = 4; i < newPanel.Length; point += 30, i++)
            {
                newPanel[i] = new System.Windows.Forms.RadioButton();
                newPanel[i].Location = new System.Drawing.Point(4, point);
                newPanel[i].Name = "radio" + type + i;
                newPanel[i].Size = new System.Drawing.Size(107, 24);
                newPanel[i].TabIndex = 0;
                newPanel[i].TabStop = true;
                newPanel[i].Text = GetEnumDescription((BodyPart)i);
                newPanel[i].Tag = (BodyPart)i;
                newPanel[i].UseVisualStyleBackColor = true;
                if (type == "Attack")
                {
                    AttackPanel.Controls.Add(newPanel[i]);
                }
                else if (type == "Block")
                {
                    BlockPanel.Controls.Add(newPanel[i]);
                }
            }
        }
        
        public static string GetEnumDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(
                    typeof(DescriptionAttribute),
                    false);

            if (attributes != null &&
                attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();
        }
        
        public void RefreshHealthProgressBars(ProgressBar sender, EventArgs e)
        {
            Int32 currentLifePercent = sender.Value / sender.Maximum * 100;
            if (currentLifePercent < 30)
            {
                sender.ForeColor = Color.Red;
            }
            else if (currentLifePercent < 60)
            {
                sender.ForeColor = Color.Yellow;
            }
        }

        BodyPart InspectRadioButtons(string action)
        {
            if (action == "Attack")
            {
                if (AttackPanel.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked) != null)
                {
                    AttackPanel.BackColor = Color.Empty;
                    return (BodyPart)AttackPanel.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Tag;
                }
                else
                {
                    AttackPanel.BackColor = Color.IndianRed;
                    return BodyPart.None;
                }
            }
            else if (action == "Block")
            {
                if (BlockPanel.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked) != null)
                {
                    BlockPanel.BackColor = Color.Empty;
                    return (BodyPart)BlockPanel.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Tag;
                }
                else
                {
                    BlockPanel.BackColor = Color.IndianRed;
                    return BodyPart.None;
                }
            }
            else
            {
                return BodyPart.None;
            }
        }
        void ResetCheckedRadioButtons()
        {
            AttackPanel.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Checked = false;
            BlockPanel.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Checked = false;
        }
        private void BattleLogTextChanged(object sender, EventArgs e)
        {
            // Set the current caret position at the end
            BattleLog.SelectionStart = BattleLog.Text.Length;
            // Now scroll it automatically
            BattleLog.ScrollToCaret();
        }


        #region IBattlePageView implementation
        public string BattleFirstPlayerName
        {
            get
            {
                return FirstPlayerName.Text;
            }
            set
            {
                FirstPlayerName.Text = value;
            }
        }
        public int BattleFirstPlayerHP
        {
            get
            {
                return FirstPlayerHP.Value;
            }
            set
            {
                FirstPlayerHP.Value = value;
            }
        }
        public int BattleFirstPlayerHpMax
        {
            get
            {
                return FirstPlayerHP.Maximum;
            }
            set
            {
                FirstPlayerHP.Maximum = value;
            }
        }
        public string BattleSecondPlayerName
        {
            get
            {
                return SecondPlayerName.Text;
            }
            set
            {
                SecondPlayerName.Text = value;
            }
        }
        public int BattleSecondPlayerHP
        {
            get
            {
                return SecondPlayerHP.Value;
            }
            set
            {
                SecondPlayerHP.Value = value;
            }
        }
        public int BattleSecondPlayerHpMax
        {
            get
            {
                return SecondPlayerHP.Maximum;
            }
            set
            {
                SecondPlayerHP.Maximum = value;
            }
        }
        public string BattleResultMessage
        {
            get
            {
                return BattleResult.Text;
            }
            set
            {
                BattleResult.Text = value;
            }
        }
        public bool RadioButtonsVisible
        {
            get
            {
                return RadioButtons.Visible;
            }
            set
            {
                RadioButtons.Visible = value;
            }
        }
        public bool NewBattleButtonVisible
        {
            get
            {
                return NewBattle.Visible;
            }
            set
            {
                NewBattle.Visible = value;
            }
        }
        public string AddBattleLog
        {
            get
            {
                return BattleLog.Text;
            }
            set
            {
                BattleLog.Text += value;
            }
        }
        void AttackClick(object sender, EventArgs e)
        {
            BodyPart attackPoint = InspectRadioButtons("Attack");
            BodyPart blockPoint = InspectRadioButtons("Block");

            if (attackPoint != BodyPart.None && blockPoint != BodyPart.None)
            {
                ResetCheckedRadioButtons();
                Battle.NextRound(attackPoint, blockPoint);
            }
        }
        #endregion
    }
}
