using ISD_13.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISD_13
{
    public partial class MainForm : Form, IMainForm
    {
        public event EventHandler LoadAllTables;
        public event EventHandler SaveInfo;
        public event EventHandler FindUserByLogin;
        public event EventHandler FindHitLogsByCombatId;
        public event EventHandler EditTransactionCell;
        public MainPresenter presenter;
        public string transactionPlayerLogin = string.Empty;
        public MainForm()
        {
            InitializeComponent();
            presenter = new MainPresenter(this);
        }
        public string TransactiomPlayerLogin
        {
            get { return transactionPlayerLogin; }
        }
        public string TransactionId
        {
            get { return TransactionDGV[0, TransactionDGV.CurrentCellAddress.Y].Value.ToString(); }
        }
        public object PlayerBindingSource
        {
            set { playerBindingSource.DataSource = value; }
        }
        public object CombatBindingSource
        {
            set { combatBindingSource.DataSource = value; }
        }
        public object TransactionBindingSource
        {
            set { transactionBindingSource.DataSource = value; }
        }
        public object HitLogBindingSource
        {
            set { hitLogBindingSource.DataSource = value; }
        }
        public string SelectedCombat
        {
            get { return SelectedCombatIdTxt.Text; }
            set { SelectedCombatIdTxt.Text = value; }
        }
        public string SelectedCombatId
        {
            get { return CombatDGV[0, CombatDGV.CurrentCellAddress.Y].Value.ToString(); }
            set
            {
                for (int i = 0; i < CombatDGV.Rows.Count; i++)
                {
                    if (CombatDGV[0, i].Value.ToString() == value.ToString())
                    {
                        CombatDGV.CurrentCell = CombatDGV[0, i];
                        SelectedCombatIdTxt.BackColor = Color.Red;
                    }
                }
            }
        }
        public string SelectedPlayerName
        {
            get { return SelectedPlayerTxt.Text; }
            set { SelectedPlayerTxt.Text = value; }
        }
        public int SelectedPlayerId
        {
            get { return (int)PlayerDGV[0, PlayerDGV.CurrentCellAddress.Y].Value; }
            set 
            {
                for (int i = 0; i < PlayerDGV.Rows.Count; i++)
                {
                    if (PlayerDGV[0, i].Value.ToString() == value.ToString())
                    {
                        PlayerDGV.CurrentCell = PlayerDGV[0, i];
                        SelectedPlayerTxt.BackColor = Color.Red;
                    }
                }                
            }
        }
        public int SelectedTabIndex
        {
            get { return MainTab.SelectedIndex; }
        }
        public bool ValidEmailCBStatus
        {
            get { return ValidEmailCB.Checked; }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            PlayerDGV.DataSource = playerBindingSource;
            CombatDGV.DataSource = combatBindingSource;
            TransactionDGV.DataSource = transactionBindingSource;
            HitDGV.DataSource = hitLogBindingSource;
            if (LoadAllTables != null) { LoadAllTables(this, EventArgs.Empty); }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (SaveInfo != null) { SaveInfo(this, EventArgs.Empty); }
            MessageBox.Show("Changes saved");           
        }

        private void ValidEmailCB_CheckedChanged(object sender, EventArgs e)
        {
            if (LoadAllTables != null) { LoadAllTables(this, EventArgs.Empty); }
        }

        private void PlayerDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedPlayerTxt.Text = (string)PlayerDGV[1, PlayerDGV.CurrentCellAddress.Y].Value;
            SelectedPlayerTxt.BackColor = Color.Red;
        }

        private void CombatDGV_Click(object sender, EventArgs e)
        {
            if (LoadAllTables != null) { LoadAllTables(this, EventArgs.Empty); }
        }

        private void MainTab_Click(object sender, EventArgs e)
        {
            if (LoadAllTables != null) { LoadAllTables(this, EventArgs.Empty); }
        }

        private void CombatDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedCombatIdTxt.Text = CombatDGV[0, CombatDGV.CurrentCellAddress.Y].Value.ToString();
            SelectedCombatIdTxt.BackColor = Color.Red;
        }

        private void TransactionDGV_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void HitDGV_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void CurrentPlayerTxt_Click(object sender, EventArgs e)
        {
            SelectedPlayerTxt.BackColor = Color.White;
        }               
        
        private void CurrentPlayerTxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {                
                if (FindUserByLogin != null) { FindUserByLogin(this, EventArgs.Empty); }              
                if (LoadAllTables != null) { LoadAllTables(this, EventArgs.Empty); }                
            }
        }

        private void CurrentCombatIdTxt_Click(object sender, EventArgs e)
        {
            SelectedCombatIdTxt.BackColor = Color.White;            
        }

        private void CurrentCombatIdTxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (FindHitLogsByCombatId != null) { FindHitLogsByCombatId(this, EventArgs.Empty); }
                if (LoadAllTables != null) { LoadAllTables(this, EventArgs.Empty); }
            }
        }

        private void resetFilterBtn_Click(object sender, EventArgs e)
        {
            SelectedCombatIdTxt.Text = string.Empty;
            SelectedPlayerTxt.Text = string.Empty;
            SelectedPlayerTxt.BackColor = Color.White;
            SelectedCombatIdTxt.BackColor = Color.White;
            PlayerDGV.CurrentCell = PlayerDGV[0, 0];
            CombatDGV.CurrentCell = CombatDGV[0, 0];
            if (LoadAllTables != null) { LoadAllTables(this, EventArgs.Empty); }
        }

        private void TransactionDGV_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            if (TransactionDGV.CurrentCell == TransactionDGV[1, e.RowIndex])
            {
                transactionPlayerLogin = TransactionDGV.CurrentCell.EditedFormattedValue.ToString();
                if (EditTransactionCell != null) { EditTransactionCell(this, EventArgs.Empty); }                
                if (LoadAllTables != null) { LoadAllTables(this, EventArgs.Empty); }    
            }
        }        
    }
}
