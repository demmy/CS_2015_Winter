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
        public event EventHandler AddNewPlayer;
        public event EventHandler AddNewTransaction;
        public event EventHandler AddNewCombat;
        public event EventHandler AddNewHit;
        public event EventHandler LoadAllTables;
        public event EventHandler SaveAllTables;
        public event EventHandler EditTransactionCell;
        public event EventHandler EditCombatCell;

        public MainPresenter presenter;
        private string insertPlayerLogin = string.Empty;

        public MainForm()
        {
            InitializeComponent();
            presenter = new MainPresenter(this);
        }

        public string EditPlayerLogin
        {
            get { return insertPlayerLogin; }
        }
        public int EditCombatColumn
        {
            get { return CombatDGV.CurrentCellAddress.X; }
        }
        public string SelectedTransactionId
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
                        SelectedCombatIdTxt.BackColor = Color.Yellow;
                    }
                }
            }
        }
        public string SelectedPlayerName
        {
            get { return SelectedPlayerTxt.Text; }
            set { SelectedPlayerTxt.Text = value; }
        }
        public string SelectedPlayerId
        {
            get { return PlayerDGV[0, PlayerDGV.CurrentCellAddress.Y].Value.ToString(); }
            set
            {
                for (int i = 0; i < PlayerDGV.Rows.Count; i++)
                {
                    if (PlayerDGV[1, i].Value.ToString() == value)
                    {
                        PlayerDGV.CurrentCell = PlayerDGV[0, i];
                        SelectedPlayerTxt.BackColor = Color.Yellow;
                        i = PlayerDGV.Rows.Count;
                    }
                }
            }
        }
        public bool ValidEmailCBStatus
        {
            get { return ValidEmailCB.Checked; }
        }
        public bool TopTenBySummCBStatus
        {
            get { return TopTenBySummCB.Checked; }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            PlayerDGV.DataSource = playerBindingSource;
            CombatDGV.DataSource = combatBindingSource;
            TransactionDGV.DataSource = transactionBindingSource;
            HitDGV.DataSource = hitLogBindingSource;
            if (LoadAllTables != null) { LoadAllTables(this, EventArgs.Empty); }
            SaveStatusLbl.Text = string.Empty;
        }
        private void MainTab_Click(object sender, EventArgs e)
        {
            if (LoadAllTables != null) { LoadAllTables(this, EventArgs.Empty); }
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (SaveAllTables != null) { SaveAllTables(this, EventArgs.Empty); }
            SaveStatusLbl.ForeColor = Color.Black;
            SaveStatusLbl.Text = "Changes saved";
        }
        private void resetFilterBtn_Click(object sender, EventArgs e)
        {
            SelectedCombatIdTxt.Text = string.Empty;
            SelectedPlayerTxt.Text = string.Empty;
            SelectedPlayerTxt.BackColor = Color.White;
            SelectedCombatIdTxt.BackColor = Color.White;
            if (LoadAllTables != null) { LoadAllTables(this, EventArgs.Empty); }
        }
        private void ValidEmailCB_CheckedChanged(object sender, EventArgs e)
        {
            if (LoadAllTables != null) { LoadAllTables(this, EventArgs.Empty); }
        }
        private void TopTenBySummCB_CheckedChanged(object sender, EventArgs e)
        {
            if (LoadAllTables != null) { LoadAllTables(this, EventArgs.Empty); }
        }

        private void PlayerDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedPlayerTxt.Text = (string)PlayerDGV[1, PlayerDGV.CurrentCellAddress.Y].Value;
            SelectedPlayerTxt.BackColor = Color.Yellow;
        }
        private void CombatDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedCombatIdTxt.Text = CombatDGV[0, CombatDGV.CurrentCellAddress.Y].Value.ToString();
            SelectedCombatIdTxt.BackColor = Color.Yellow;
        }
        private void CombatDGV_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if ((CombatDGV.CurrentCell == CombatDGV[2, e.RowIndex]) ||
                (CombatDGV.CurrentCell == CombatDGV[3, e.RowIndex]) ||
                (CombatDGV.CurrentCell == CombatDGV[4, e.RowIndex]))
            {
                insertPlayerLogin = CombatDGV.CurrentCell.EditedFormattedValue.ToString();
                if (EditCombatCell != null) { EditCombatCell(this, EventArgs.Empty); }
            }
        }
        private void TransactionDGV_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (TransactionDGV.CurrentCell == TransactionDGV[1, e.RowIndex])
            {
                insertPlayerLogin = TransactionDGV.CurrentCell.EditedFormattedValue.ToString();
                if (EditTransactionCell != null) { EditTransactionCell(this, EventArgs.Empty); }
            }
        }

        private void CurrentPlayerTxt_Click(object sender, EventArgs e)
        {
            SelectedPlayerTxt.BackColor = Color.White;
        }
        private void CurrentPlayerTxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectedPlayerId = SelectedPlayerName;
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
                SelectedCombatId = SelectedCombat;
                if (LoadAllTables != null) { LoadAllTables(this, EventArgs.Empty); }
            }
        }

        private void AddTransactiobBtn_Click(object sender, EventArgs e)
        {
            if (AddNewTransaction != null) { AddNewTransaction(this, EventArgs.Empty); }
            TransactionDGV.FirstDisplayedCell = TransactionDGV.Rows[TransactionDGV.Rows.Count - 1].Cells[1];
        }
        private void AddNewCombatBtn_Click(object sender, EventArgs e)
        {
            if (AddNewCombat != null) { AddNewCombat(this, EventArgs.Empty); }
            CombatDGV.FirstDisplayedCell = CombatDGV.Rows[CombatDGV.Rows.Count - 1].Cells[1];
        }
        private void AddNewHitBtn_Click(object sender, EventArgs e)
        {
            if (AddNewHit != null) { AddNewHit(this, EventArgs.Empty); }
            HitDGV.FirstDisplayedCell = HitDGV.Rows[HitDGV.Rows.Count - 1].Cells[1];
        }
        private void AddNewPlayerBtn_Click(object sender, EventArgs e)
        {
            if (AddNewPlayer != null) { AddNewPlayer(this, EventArgs.Empty); }
            PlayerDGV.FirstDisplayedCell = PlayerDGV.Rows[PlayerDGV.Rows.Count - 1].Cells[1];
        }

        private void DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }       

        private void TransactionDGV_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            {
                ComboBox c = e.Control as ComboBox;
                if (c != null)
                {
                    c.DropDownStyle = ComboBoxStyle.DropDown;
                }
            }

        }

        private void CombatDGV_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            {
                ComboBox c = e.Control as ComboBox;
                if (c != null)
                {
                    c.DropDownStyle = ComboBoxStyle.DropDown;
                }
            }
        }

        private void CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            SaveStatusLbl.ForeColor = Color.Red;
            SaveStatusLbl.Text = "You have unsaved changes";
        }

        private void RowRemoved(object sender, KeyEventArgs e)
        {
            SaveStatusLbl.ForeColor = Color.Red;
            SaveStatusLbl.Text = "You have unsaved changes";
        }
    }
}
