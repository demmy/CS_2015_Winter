using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightClubStatistics.UI.TransactionScene
{
    public partial class TransactionUserControl : BaseUserControl , ITransactionUserControl
    {
        private TransactionPresenter presenter;

        public TransactionUserControl()
        {
            InitializeComponent();
            presenter = new TransactionPresenter(this);
        }

        public void ChangeCounter(int count)
        {
            transactionsDataTableCounter.Value = count;
        }

        public void DrawTransactionsTable(List<Transaction> transactionsList)
        {
            transactionsDataGrid.Update();
            transactionsDataGrid.DataSource = transactionsList;
            transactionsDataTableCounter.Value = transactionsDataGrid.RowCount;
        }

        private void addTransactionButton_Click(object sender, EventArgs e)
        {
            presenter.TurnAddTransactionControl();
        }

        private void editTransactionButton_Click(object sender, EventArgs e)
        {
            if (transactionsDataGrid.RowCount > 0)
            {
                int transactionId = int.Parse(transactionsDataGrid.CurrentRow.Cells[0].Value.ToString());
                presenter.TurnEditTransactionControl(transactionId);
            }
        }

        private void deleteTransactionButton_Click(object sender, EventArgs e)
        {
            if (transactionsDataGrid.RowCount > 0)
            {
                if (MessageBox.Show("Please, confirm deletion", "Confirm deletion", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    presenter.DeleteTransaction(int.Parse(transactionsDataGrid.CurrentRow.Cells[0].Value.ToString()));
                    transactionsDataGrid.Update();
                }
                else
                {

                }
            }
            else
            {

            }
        }

        private void transactionsDataTableCounter_ValueChanged(object sender, EventArgs e)
        {
            if (presenter == null)
            {
                transactionsDataTableCounter.Value = transactionsDataGrid.RowCount;
            }
            else
            {
                int showingCount = int.Parse(transactionsDataTableCounter.Value.ToString());
                presenter.ChangeTransactionsShowingCount(showingCount);
                transactionsDataTableCounter.Value = transactionsDataGrid.RowCount;
            }
        }

        private void toMenuButton_Click(object sender, EventArgs e)
        {
            SwitchScene(Scene.MenuScene);
        }
    }
}
