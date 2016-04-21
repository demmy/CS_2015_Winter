/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 08.04.2016
 * Time: 9:32
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using LogicLayer.DataObject;
using LogicLayer.Services;
using LogicLayer.Interfaces;

namespace CombatsDataViewer
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        string Server;
        bool AutoSearch;
        List<UserDTO> Users = new List<UserDTO>();
        List<UserTransactionDTO> UserTransactions = new List<UserTransactionDTO>();
        List<PlayerDTO> Player = new List<PlayerDTO>();
        List<BattleDTO> Battles = new List<BattleDTO>();

        public MainForm()
        {
            InitializeComponent();
            InitTables();
        }

        void AddUserClick(object sender, EventArgs e)
        {
            if (!CheckAddUserTextboxesForMinimumValidData())
                return;
            UserDTO user = new UserDTO
            {
                Login = userLogin.Text,
                Password = userPassword.Text,
                EMail = userEmail.Text,
                IsEMailValidated = isEmailValid.Checked,
                CharacterName = playerName.Text,
                RegistrationDate = DateTime.Now
            };
            new UserService(Server).AddUser(user);
            ClearUserEditForm();
        }

        void DeleteUserClick(object sender, EventArgs e)
        {
            new UserService(Server).Delete(Convert.ToInt16(userId.Text));
            ClearUserEditForm();
        }

        void EditUserClick(object sender, EventArgs e)
        {
            if (!CheckAddUserTextboxesForMinimumValidData())
                return;
            UserDTO user = new UserDTO
            {
                Id = Convert.ToInt16(userId.Text),
                Login = userLogin.Text,
                Password = userPassword.Text,
                EMail = userEmail.Text,
                IsEMailValidated = isEmailValid.Checked,
                CharacterName = playerName.Text,
                RegistrationDate = DateTime.Now
            };
            new UserService(Server).EditUser(user);
            ClearUserEditForm();
        }

        void AddUserTransaction(object sender, EventArgs e)
        {
            string login = transactionUser.Text;
            if (!CheckAddUserTransactionTextboxesForMinimumValidData())
                return;
            UserTransactionDTO ut = new UserTransactionDTO
            {
                Date = transactionDate.Value,
                Description = transactionDescription.Text,
                Sum = Convert.ToDecimal(transactionSum.Text)
            };
            new UserTransactionService(Server).AddTransaction(login, ut);
            ClearUserTransactionEditForm();
            transactionUser.Text = login;
        }

        void MainFormLoad(object sender, EventArgs e)
        {
            setLocalDB.AutoCheck = true;
            setExternalDB.AutoCheck = true;
        }
        void ConnectButtonClick(object sender, EventArgs e)
        {
            connectButton.Enabled = false;
            Server = selectDbSever.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Tag.ToString();
            Users = new UserService(Server).GetAllUsers();
            usersList.DataSource = Users;
            usersFilterTable.Enabled = true;
            userForm.Enabled = true;
            filtersTable.Enabled = true;
            AddUser.Enabled = true;
        }
        void SetLocalDBCheckedChanged(object sender, EventArgs e)
        {
            connectButton.Enabled = true;
        }
        void SetExternalDBCheckedChanged(object sender, EventArgs e)
        {
            connectButton.Enabled = true;
        }

        void InitTables()
        {
            usersList.DataSource = new BindingSource
            {
                DataSource = Users
            };
            AutoSizeCols(usersList);
            usersList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            usersList.DataSource = typeof(List<UserDTO>);

            //usersList.DataSource = Users;
            //AutoSizeCols(usersList);
            //usersList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            userTransactionList.DataSource = new BindingSource
            {
                DataSource = UserTransactions
            };
            AutoSizeCols(userTransactionList);
            userTransactionList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            userBattlesList.DataSource = new BindingSource
            {
                DataSource = Battles
            };
            AutoSizeCols(userBattlesList);
            userBattlesList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        void AutoSizeCols(DataGridView datagrid)
        {
            for (int i = 0; i < datagrid.Columns.Count - 1; i++)
            {
                datagrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            datagrid.Columns[datagrid.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            for (int i = 0; i < datagrid.Columns.Count; i++)
            {
                int colw = datagrid.Columns[i].Width;
                datagrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                datagrid.Columns[i].Width = colw;
            }
            datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        void ClearUserEditForm()
        {
            ClearEditForm(userForm);
            Users = new UserService(Server).GetAllUsers().ToList();
            usersList.DataSource = typeof(List<UserDTO>);
            usersList.DataSource = Users;
            usersList.ClearSelection();
        }

        void ClearUserTransactionEditForm()
        {
            int uId = new UserService(Server).GetUserByLogin(transactionUser.Text);
            UserTransactions = new UserTransactionService(Server).GetUserTransactions(uId);
            ClearEditForm(userTransactionForm);
            userTransactionList.DataSource = typeof(List<UserTransactionDTO>);
            userTransactionList.DataSource = UserTransactions;
        }

        void ClearEditForm(GroupBox group)
        {
            foreach (Control control in group.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    control.Text = null;
                    control.BackColor = Color.Empty;
                }
            }
        }

        private void usersList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView datagrid = sender as DataGridView;
            if (datagrid == null)
            {
                return;
            }
            if (datagrid.CurrentRow.Selected)
            {
                userId.Text = datagrid.CurrentRow.Cells["Id"].Value.ToString();
                playerName.Text = datagrid.CurrentRow.Cells["CharacterName"].Value.ToString();
                date.Text = datagrid.CurrentRow.Cells["RegistrationDate"].Value.ToString();
                userLogin.Text = datagrid.CurrentRow.Cells["Login"].Value.ToString();
                userPassword.Text = datagrid.CurrentRow.Cells["Password"].Value.ToString();
                isEmailValid.Checked = (bool)datagrid.CurrentRow.Cells["IsEMailValidated"].Value;
                userEmail.Text = datagrid.CurrentRow.Cells["EMail"].Value.ToString();
                AddUser.Enabled = false;
                EditUser.Enabled = true;
                DeleteUser.Enabled = true;
                CancelUserEdit.Enabled = true;
            }
        }

        bool CheckAddUserTextboxesForMinimumValidData()
        {
            if (String.IsNullOrWhiteSpace(userLogin.Text))
            {
                userLogin.BackColor = Color.OrangeRed;
            }
            else
            {
                userLogin.BackColor = Color.Empty;
            }
            if (String.IsNullOrWhiteSpace(userPassword.Text))
            {
                userPassword.BackColor = Color.OrangeRed;
            }
            else
            {
                userPassword.BackColor = Color.Empty;
            }
            if (String.IsNullOrWhiteSpace(playerName.Text))
            {
                playerName.BackColor = Color.OrangeRed;
            }
            else
            {
                playerName.BackColor = Color.Empty;
            }
            if (String.IsNullOrWhiteSpace(userEmail.Text))
            {
                userEmail.BackColor = Color.OrangeRed;
            }
            else
            {
                userEmail.BackColor = Color.Empty;
            }
            if (userLogin.BackColor == Color.OrangeRed
                || userPassword.BackColor == Color.OrangeRed
                || playerName.BackColor == Color.OrangeRed
                || userEmail.BackColor == Color.OrangeRed
                )
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        bool CheckAddUserTransactionTextboxesForMinimumValidData()
        {
            if (String.IsNullOrWhiteSpace(transactionSum.Text))
            {
                transactionSum.BackColor = Color.OrangeRed;
            }
            else
            {
                transactionSum.BackColor = Color.Empty;
            }
            if (transactionSum.BackColor == Color.OrangeRed)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void usersList_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView datagrid = sender as DataGridView;
            if (datagrid == null)
                return;
            if (!datagrid.CurrentRow.Selected)
                return;
            int uId = Convert.ToInt16(datagrid.CurrentRow.Cells["Id"].Value.ToString());
            UserTransactions = new UserTransactionService(Server)
                .GetUserTransactions(uId);
            addUserTransaction.Enabled = true;
            transactionUser.Text = datagrid.CurrentRow.Cells["Login"].Value.ToString();
            userTransactionList.DataSource = UserTransactions;
            charStatTable.DataSource = new List<PlayerDTO> { new UserService(Server).GetCharacterStatistic(uId) };
            //else if (!datagrid.CurrentRow.Selected)
            //    return;
            //UsersTransactions = new UserTransactionService(Server)
            //    .GetUserTransactions(Convert.ToInt16(usersList.CurrentRow.Cells["Id"].Value));
            //usersList.DataSource = Users;
            //AddUser.Enabled = true;
        }

        private void clearFilter_Click(object sender, EventArgs e)
        {
            ClearUserEditForm();
            usersList.ClearSelection();
            userTransactionList.ClearSelection();
            userBattlesList.ClearSelection();
        }

        private void userTransactionList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView datagrid = sender as DataGridView;
            if (datagrid == null)
            {
                return;
            }
            if (datagrid.CurrentRow.Selected)
            {
                transactionId.Text = datagrid.CurrentRow.Cells["Id"].Value.ToString();
                transactionDescription.Text = datagrid.CurrentRow.Cells["Description"].Value.ToString();
                transactionSum.Text = datagrid.CurrentRow.Cells["Sum"].Value.ToString();
                editUserTransaction.Enabled = true;
                deleteUserTransaction.Enabled = true;
                cancelTransactionEdit.Enabled = true;
            }

        }

        private void CancelUserEdit_Click(object sender, EventArgs e)
        {
            ClearEditForm(userForm);
            AddUser.Enabled = true;
            EditUser.Enabled = false;
            DeleteUser.Enabled = false;
            CancelUserEdit.Enabled = false;
        }

        private void CancelTransactionEdit_Click(object sender, EventArgs e)
        {
            string login = transactionUser.Text;
            ClearEditForm(userTransactionForm);
            transactionUser.Text = login;
            addUserTransaction.Enabled = true;
            editUserTransaction.Enabled = false;
            deleteUserTransaction.Enabled = false;
            cancelTransactionEdit.Enabled = false;
        }

        private void sortTransactionsByMaxSum_Click(object sender, EventArgs e)
        {
            int uId = new UserService(Server).GetUserByLogin(transactionUser.Text);
            List<UserTransactionDTO> filteredList = new UserTransactionService(Server).GetUserTransactionsDescByMaxSum(uId);
            UserTransactions = filteredList;
            userTransactionList.DataSource = UserTransactions;
        }

        private void lastFiveItems_Click(object sender, EventArgs e)
        {
            int uId = new UserService(Server).GetUserByLogin(transactionUser.Text);
            List<UserTransactionDTO> filteredList = new UserTransactionService(Server).GetLastUserTransactions(uId, 5);
            UserTransactions = filteredList;
            userTransactionList.DataSource = UserTransactions;
        }

        private void doSearch_Click(object sender, EventArgs e)
        {
            if (!AutoSearch)
            {
                AutoSearch = true;
                doAutoSearch.Font = new Font(doAutoSearch.Font, FontStyle.Bold);
            }
            else
            {
                AutoSearch = false;
                doAutoSearch.Font = new Font(doAutoSearch.Font, FontStyle.Regular);
            }
        }

        private void userSearch_TextChanged(object sender, EventArgs e)
        {
            TextBox Sender = sender as TextBox;
            if (AutoSearch && Sender.Text.Length > 2)
            {
                Users = new UserService(Server).GetUsersBySearchString(userSearch.Text);
                usersList.DataSource = Users;
            }
        }

        void EditUserTransactionClick(object sender, EventArgs e)
        {
            if (!CheckAddUserTransactionTextboxesForMinimumValidData())
                return;
            UserTransactionDTO transaction = new UserTransactionDTO
            {
                Id = Convert.ToInt16(transactionId.Text),
                Description = transactionDescription.Text,
                Sum = Convert.ToDecimal(transactionSum.Text),
            };
            new UserTransactionService(Server).EditUserTransaction(transaction);
            ClearUserTransactionEditForm();
        }

        void DeleteUserTransactionClick(object sender, EventArgs e)
        {
            UserTransactionDTO ut = new UserTransactionDTO
            {
                Id = Convert.ToInt16(transactionId.Text),
                Description = transactionDescription.Text,
                Sum = Convert.ToDecimal(transactionSum.Text)
            };
            new UserTransactionService(Server).DeleteUserTransaction(ut);
            ClearUserTransactionEditForm();
        }
    }
}
