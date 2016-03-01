/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 12.02.2016
 * Time: 11:04
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Combats.Classes;

namespace Combats
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        Presenter presenter;
        public MainForm()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            presenter = new Presenter(this);
            
            //
            // Add constructor code after the InitializeComponent() call.
            //
        }
        void ButtonStartGameClick(object sender, EventArgs e)
        {
            if (this.textPlayerName1.Text == "")
            {
                this.textPlayerName1.BackColor = Color.IndianRed;
                return;
            }
            else
            {
                this.textPlayerName1.BackColor = Color.Empty;
            }
            presenter.StartNewGame(this.textPlayerName1.Text);
        }
        void ButtonNewGameClick(object sender, EventArgs e)
        {
            this.panelRadioButtons.Visible = true;
            this.buttonNewGame.Visible = false;
            this.richBattleLog.Clear();
            presenter.StartNewGame(this.labelPlayerName1.Text);
        }
        void ButtonRoundClick(object sender, EventArgs e)
        {
            string attackPoint = InspectRadioButtons("Attack");
            string blockPoint = InspectRadioButtons("Block");

            if (!String.IsNullOrEmpty(attackPoint) && !String.IsNullOrEmpty(blockPoint))
            {
                ResetCheckedRadioButtons();
                presenter.NextRound(attackPoint, blockPoint);
            }
        }
        string InspectRadioButtons(string action)
        {
            if (action == "Attack")
            {
                if (this.panelAttack.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked) != null)
                {
                    this.panelAttack.BackColor = Color.Empty;
                    return this.panelAttack.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text; 
                }
                else
                {
                    this.panelAttack.BackColor = Color.IndianRed;
                    return null;
                }
            }
            else if (action == "Block")
            {
                if (this.panelBlock.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked) != null)
                {
                    this.panelBlock.BackColor = Color.Empty;
                    return this.panelBlock.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
                }
                else
                {
                    this.panelBlock.BackColor = Color.IndianRed;
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
        void ResetCheckedRadioButtons()
        {
            this.panelAttack.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Checked = false;
            this.panelBlock.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Checked = false;
        }
        private void richBattleLogTextChanged(object sender, EventArgs e)
        {
            // Set the current caret position at the end
            richBattleLog.SelectionStart = richBattleLog.Text.Length;
            // Now scroll it automatically
            richBattleLog.ScrollToCaret();
        }
    }
}
