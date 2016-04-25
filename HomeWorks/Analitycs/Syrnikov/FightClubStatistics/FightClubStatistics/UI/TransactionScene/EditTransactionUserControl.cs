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
    public partial class EditTransactionUserControl : BaseUserControl , IUserControl
    {
        private bool editMode = false;
        private TransactionPresenter presenter = null;
        private Transaction editTransaction = null;

        public EditTransactionUserControl()
        {
            InitializeComponent();
            editMode = false;
            presenter = new TransactionPresenter(new TransactionUserControl());
            transactonUserComboBox.DataSource = presenter.usersList.Select(x => x.Login).ToList();
        }
        public EditTransactionUserControl(Object param)
        {
            InitializeComponent();
            presenter = new TransactionPresenter(new TransactionUserControl());
            transactonUserComboBox.DataSource = presenter.usersList.Select(x => x.Login).ToList();
            editMode = true;

            editTransaction = (Transaction)param;            
            DrawEditTransactionInfo();
        }

        private void DrawEditTransactionInfo()
        {
            transactonUserComboBox.Text = editTransaction.User.Login;
            transactionSumTextBox.Text = editTransaction.Sum.ToString();
            transactionDateTimePicker.Text = editTransaction.Date.ToString();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            SwitchScene(Scene.TransactionScene);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (ValidateTransactionData())
            {
                if (editMode)
                {
                    editTransaction.User = presenter.usersList.Where(x => x.Login == transactonUserComboBox.Text).FirstOrDefault();
                    editTransaction.Sum = int.Parse(transactionSumTextBox.Text);
                    editTransaction.Date = DateTime.Parse(transactionDateTimePicker.Text);
                    presenter.EditTransaction(editTransaction);
                }
                else
                {
                    presenter.AddTransaction(new Transaction
                    {
                        User = presenter.usersList.Where(x => x.Login == transactonUserComboBox.Text).FirstOrDefault(),
                        Sum = int.Parse(transactionSumTextBox.Text),
                        Date = DateTime.Parse(transactionDateTimePicker.Text)
                    });
                }
                SwitchScene(Scene.TransactionScene);
            }
            else
            {
                MessageBox.Show("Wrong data");
            }
        }

        private bool ValidateTransactionData()
        {
            bool isDataValid = true;
            return isDataValid;
        }

        private void transactionSumTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsDigit(e.KeyChar)) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
    }
}
