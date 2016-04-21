using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FightClubStatistics;

namespace FightClubStatistics.UI.UserScene
{
    public partial class UserUserControl : BaseUserControl , IUserUserControl
    {
        private UserPresenter presenter = null;
        

        public UserUserControl()
        {            
            InitializeComponent();
            presenter = new UserPresenter(this);
        }

        private void UserUserControl_Load(object sender, EventArgs e)
        {

        }

        public void DrawUsersTable(List<User> userList)
        {
            usersDataGrid.Update();
            usersDataGrid.DataSource = userList;
            usersDataTableCounter.Value = usersDataGrid.RowCount;
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            presenter.TurnAddUserControl();
        }

        private void editUserButton_Click(object sender, EventArgs e)
        {
            if (usersDataGrid.RowCount > 0)
            {
                int userId = int.Parse(usersDataGrid.CurrentRow.Cells[0].Value.ToString());
                presenter.TurnEditUserControl(userId);
            }           
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            if (usersDataGrid.RowCount > 0)
            {
                if (MessageBox.Show("Please, confirm deletion", "Confirm deletion", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    presenter.DeleteUser(int.Parse(usersDataGrid.CurrentRow.Cells[0].Value.ToString()));
                    usersDataGrid.Update();
                }
                else
                {

                }
            }
            else
            {

            }
            
        }

        private void usersDataTableCounter_ValueChanged(object sender, EventArgs e)
        {
            if (presenter == null)
            {
                usersDataTableCounter.Value = usersDataGrid.RowCount;
            }
            else
            {
                int showingCount = int.Parse(usersDataTableCounter.Value.ToString());
                presenter.ChangeUsersShowingCount(showingCount);
                usersDataTableCounter.Value = usersDataGrid.RowCount;
            }
            
        }

        public void ChangeCounter(int count)
        {
            usersDataTableCounter.Value = count;
        }

        private void choseAllRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (choseAllRadioButton.Checked)
            {
                presenter.ShowAllUsers();
            }
        }

        private void choseValidEmailsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (choseValidEmailsRadioButton.Checked)
            {
                presenter.ShowUsersWithValidEmails();
            }
        }

        private void choseNonValidEmailsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (choseNonValidEmailsRadioButton.Checked)
            {
                presenter.ShowUsersWithoutValidEmails();
            }
        }

        private void toMenuButton_Click(object sender, EventArgs e)
        {
            SwitchScene(Scene.MenuScene);
        }
    }
}
