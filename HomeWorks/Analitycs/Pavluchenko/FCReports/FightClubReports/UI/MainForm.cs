using Enums;
using FightClubReports.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FightClubReports.Properties;
using FightClubReports.Data;
using FightClubReports.Entitys;

namespace FightClubReports
{
    public partial class MainForm : Form, IView
    {
        OutputInfoType outputInfo = OutputInfoType.Unknown;
        public event EventHandler playersOkClick;
        public event EventHandler transactionsOkClick;
        public event EventHandler combatsOkClick;
        public event EventHandler playerSaveClick;
        public event EventHandler transactionSaveClick;
        
        Player selectedPlayer;
        Transaction selectedTransaction;

        public MainForm()
        {
            InitializeComponent();
            selectedPlayer = new Player();
            selectedTransaction = new Transaction();
        }

        #region Properties

        public Player SelectedPlayer
        {
            get { return selectedPlayer; }
        }

        public Transaction SelectedTransaction
        {
            get { return selectedTransaction; }
        }
        
        public OutputInfoType OutputInfo
        {
            get { return outputInfo; }
        }

        public object PlayerTable
        {
            set { playersTable.DataSource = value; }
        }

        public object TransactionsTable
        {
            set { transactionsTable.DataSource = value; }
        }

        public object CombatsTable
        {
            set { combatsTable.DataSource = value; }
        }

        public bool EmailError
        {
            set { emailValidError.Visible = value; }
        }

        public bool LoginError
        {
            set { loginValidError.Visible = value; }
        }

        public bool PasswordError
        {
            set { passwordValidError.Visible = value; }
        }

        public bool SavePlayer
        {
            set { savePlayerLb.Visible = value; }
        }
        
        public bool DateError
        {
            set { dateValidError.Visible = value; }
        }

        public bool SumError
        {
            set { sumValidError.Visible = value; }
        }

        public bool SaveTransaction
        {
            set { saveTransactionLb.Visible = value; }
        }


        #endregion

        #region Events

        private void MainForm_Load(object sender, EventArgs e)
        {
            Setup();
        }

        #region Players

        private void topPlayers_CheckedChanged(object sender, EventArgs e)
        {
            outputInfo = OutputInfoType.PTop;
            if (playersOkClick != null) { playersOkClick(this, EventArgs.Empty); }
            ResetTextBoxDataForPlayers();
        }

        private void playersByValidEmail_CheckedChanged(object sender, EventArgs e)
        {
            outputInfo = OutputInfoType.PValidEmail;
            if (playersOkClick != null) { playersOkClick(this, EventArgs.Empty); }
            ResetTextBoxDataForPlayers();
        }

        private void playersByNumberOfCombats_CheckedChanged(object sender, EventArgs e)
        {
            outputInfo = OutputInfoType.PNumOfComb;
            if (playersOkClick != null) { playersOkClick(this, EventArgs.Empty); }
            ResetTextBoxDataForPlayers();
        }

        private void playersByAlphabet_CheckedChanged(object sender, EventArgs e)
        {
            outputInfo = OutputInfoType.PAlphabet;
            if (playersOkClick != null) { playersOkClick(this, EventArgs.Empty); }
            ResetTextBoxDataForPlayers();
        }

        private void playersByDate_CheckedChanged(object sender, EventArgs e)
        {
            outputInfo = OutputInfoType.PDate;
            if (playersOkClick != null) { playersOkClick(this, EventArgs.Empty); }
            ResetTextBoxDataForPlayers();
        }

        private void playersByLogin_CheckedChanged(object sender, EventArgs e)
        {
            ResetTextBoxDataForPlayers();
            loginForPlayers.Text = string.Empty;
            if (playersByLogin.Checked == true)
            {
                loginForPlayers.Visible = true;
                playersOk.Visible = true;
                loginForPlayers.Focus();
            }
            else
            {
                loginForPlayers.Visible = false;
                playersOk.Visible = false;
            }
        }

        private void playersLoginOk_Click(object sender, EventArgs e)
        {
            if (loginForPlayers.Text == string.Empty)
            {
                MessageBox.Show(Resources.enterLoginInField, Resources.loginIsNotEntered, MessageBoxButtons.OK);
                loginForPlayers.Focus();
            }
            else
            {
                outputInfo = OutputInfoType.PLogin;
                selectedPlayer.Login = loginForPlayers.Text;
                if (playersOkClick != null) { playersOkClick(this, EventArgs.Empty); }
            }
        }

        private void playersTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PlayersErrorsUnvisible();
            selectedPlayer.Id = (int)playersTable[0, playersTable.CurrentCellAddress.Y].Value;
            loginEditTb.Text = playersTable[1, playersTable.CurrentCellAddress.Y].Value.ToString();
            passwordEditTb.Text = playersTable[2, playersTable.CurrentCellAddress.Y].Value.ToString();

            var emailVal = playersTable[3, playersTable.CurrentCellAddress.Y].Value;
            emailEditTb.Text = (null != emailVal) ? emailVal.ToString() : string.Empty;
        }

        private void savePlayers_Click(object sender, EventArgs e)
        {
            SavePlayerChanges();
            if (playerSaveClick != null) { playerSaveClick(this, EventArgs.Empty); }
        }

        private void loginEditTb_TextChanged(object sender, EventArgs e)
        {
            PlayersErrorsUnvisible();
        }

        private void passwordEditTb_TextChanged(object sender, EventArgs e)
        {
            PlayersErrorsUnvisible();
        }

        private void emailEditTb_TextChanged(object sender, EventArgs e)
        {
            PlayersErrorsUnvisible();
        }

        #endregion

        #region Transactions

        private void transactionsBySum_CheckedChanged(object sender, EventArgs e)
        {
            saveTransactionLb.Visible = false;
            ResetTextBoxDataForTransactions();
            outputInfo = OutputInfoType.TSum;
            if (transactionsOkClick != null) { transactionsOkClick(this, EventArgs.Empty); }
        }

        private void transactionsByDate_CheckedChanged(object sender, EventArgs e)
        {
            saveTransactionLb.Visible = false;
            ResetTextBoxDataForTransactions();
            outputInfo = OutputInfoType.TDate;
            if (transactionsOkClick != null) { transactionsOkClick(this, EventArgs.Empty); }
        }

        private void transactionsByLogin_CheckedChanged(object sender, EventArgs e)
        {
            saveTransactionLb.Visible = false;
            ResetTextBoxDataForTransactions();
            loginForTransactions.Text = string.Empty;

            if (transactionsByLogin.Checked == true)
            {
                loginForTransactions.Visible = true; 
                transactionsOk.Visible = true;
                loginForTransactions.Focus();
            }
            else
            {
                loginForTransactions.Visible = false;
                transactionsOk.Visible = false;
            }
        }

        private void transactionsOk_Click(object sender, EventArgs e)
        {
            if (loginForTransactions.Text == string.Empty)
            {
                MessageBox.Show(Resources.enterLoginInField, Resources.loginIsNotEntered, MessageBoxButtons.OK);
                loginForTransactions.Focus();
            }
            else
            {
                outputInfo = OutputInfoType.TLogin;
                selectedPlayer.Login = loginForTransactions.Text;
                if (transactionsOkClick != null) { transactionsOkClick(this, EventArgs.Empty); }
            }
        }

        private void transactionsTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TransactionsErrorsUnvisible();
            selectedTransaction.Id = (int)transactionsTable[0, transactionsTable.CurrentCellAddress.Y].Value;
            dateEdit.Text = transactionsTable[1, transactionsTable.CurrentCellAddress.Y].Value.ToString();
            sumEdit.Text = transactionsTable[3, transactionsTable.CurrentCellAddress.Y].Value.ToString();
        }

        private void saveTransactions_Click(object sender, EventArgs e)
        {
            SaveTransactionChanges();
            if (transactionSaveClick != null) { transactionSaveClick(this, EventArgs.Empty); }
        }

        private void sumEdit_TextChanged(object sender, EventArgs e)
        {
            TransactionsErrorsUnvisible();
        }

        private void dateEdit_TextChanged(object sender, EventArgs e)
        {
            TransactionsErrorsUnvisible();
        }


        #endregion

        #region Combats
        private void combatsByType_CheckedChanged(object sender, EventArgs e)
        {
            outputInfo = OutputInfoType.CType;
            if (combatsOkClick != null) { combatsOkClick(this, EventArgs.Empty); }
        }

        private void combatsByDate_CheckedChanged(object sender, EventArgs e)
        {
            outputInfo = OutputInfoType.CDate;
            if (combatsOkClick != null) { combatsOkClick(this, EventArgs.Empty); }

        }

        private void combatsByLogin_CheckedChanged(object sender, EventArgs e)
        {
            loginForCombats.Text = string.Empty;
            if (combatsByLogin.Checked == true)
            {
                loginForCombats.Visible = true;
                combatsOk.Visible = true;
                loginForCombats.Focus();
            }
            else
            {
                loginForCombats.Visible = false;
                combatsOk.Visible = false;
            }

        }

        private void combatsLoginOk_Click(object sender, EventArgs e)
        {
            if (loginForCombats.Text == string.Empty)
            {
                MessageBox.Show(Resources.enterLoginInField, Resources.loginIsNotEntered, MessageBoxButtons.OK);
                loginForCombats.Focus();
            }
            else
            {
                outputInfo = OutputInfoType.CLogin; selectedPlayer.Login = loginForCombats.Text;
                if (combatsOkClick != null) { combatsOkClick(this, EventArgs.Empty); }
            }
        }

        private void combatsTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void saveCombats_Click(object sender, EventArgs e)
        {

        }


        #endregion

        #endregion

        #region Methods

        private void SavePlayerChanges()
        {
            selectedPlayer.Login = loginEditTb.Text;
            selectedPlayer.Password = passwordEditTb.Text;
            selectedPlayer.EMail = emailEditTb.Text;
        }

        private void SaveTransactionChanges()
        {
                DateTime date;
                DateTime.TryParse(dateEdit.Text, out date);
                selectedTransaction.Date = date;
           
                decimal sum;
                decimal.TryParse(sumEdit.Text, out sum);
                selectedTransaction.Sum = sum;
           
        }

        private void Setup()
        {
            StartInfoForTabs();
            CreateToolTips();
            DGVSelectionMode();
        }

        private void CreateToolTips()
        {
            ToolTip loginTt = new ToolTip();
            ToolTip passwordTt = new ToolTip();
            ToolTip emailTt = new ToolTip();
            loginTt.SetToolTip(loginValidError, Resources.loginValidError); 
            passwordTt.SetToolTip(passwordValidError, Resources.passwordValidError);
            emailTt.SetToolTip(emailValidError, Resources.emailValidError);
        }

        private void StartInfoForTabs()
        {
            outputInfo = OutputInfoType.PTop;
            if (playersOkClick != null) { playersOkClick(this, EventArgs.Empty); }

            outputInfo = OutputInfoType.TSum;
            if (transactionsOkClick != null) { transactionsOkClick(this, EventArgs.Empty); }

            outputInfo = OutputInfoType.CType;
            if (combatsOkClick != null) { combatsOkClick(this, EventArgs.Empty); }
        }

        private void DGVSelectionMode()
        {
            playersTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            transactionsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            combatsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            playersTable.MultiSelect = transactionsTable.MultiSelect = combatsTable.MultiSelect = false;
        }

        private void PlayersErrorsUnvisible()
        {
            savePlayerLb.Visible = false;
            emailValidError.Visible = false;
            passwordValidError.Visible = false;
            loginValidError.Visible = false;
        }

        private void TransactionsErrorsUnvisible()
        {
            saveTransactionLb.Visible = false;
            sumValidError.Visible = false;
            dateValidError.Visible = false;
        }

        private void ResetTextBoxDataForPlayers()
        {
            loginEditTb.Text = string.Empty;
            passwordEditTb.Text = string.Empty;
            emailEditTb.Text = string.Empty;
        }

        private void ResetTextBoxDataForTransactions()
        {
            sumEdit.Text = string.Empty;
            dateEdit.Text = string.Empty;
        }

        #endregion


    }
}

