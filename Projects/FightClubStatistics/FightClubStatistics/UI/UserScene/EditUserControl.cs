using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace FightClubStatistics.UI.UserScene
{
    public partial class EditUserControl : BaseUserControl , IUserControl
    {
        private bool editMode = false;
        private UserPresenter presenter = null;
        private User editUser = null;
        private string namepassPattern = @"^[a-zA-Z0-9]+$";
        private string emailPattern = @"^[-\w.]+@([A-z0-9][-A-z0-9]+\.)+[A-z]{2,4}$";

        public EditUserControl()
        {
            InitializeComponent();
            editMode = false;
            presenter = new UserPresenter(new UserUserControl());
        }

        public EditUserControl(Object param)
        {
            InitializeComponent();
            editMode = true;

            editUser = (User)param;
            DrawEditUserInfo();
            
            presenter = new UserPresenter(new UserUserControl());
        }

        private void DrawEditUserInfo()
        {
            userLoginTextBox.Text = editUser.Login;
            userPasswordTextBox.Text = editUser.Password;
            userEMailTextBox.Text = editUser.EMail;
            playerNameTextBox.Text = editUser.PlayerData.Name;
            playerExpTextBox.Text = editUser.PlayerData.Exp.ToString();
            validEMailChackBox.Checked = editUser.IsEmailValid;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            SwitchScene(Scene.UserScene);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (ValidateUserData())
            {
                if (editMode)
                {
                    editUser.Login = userLoginTextBox.Text;
                    editUser.Password = userPasswordTextBox.Text;
                    editUser.EMail = userEMailTextBox.Text;
                    editUser.IsEmailValid = validEMailChackBox.Checked;
                    editUser.PlayerData.Name = playerNameTextBox.Text;
                    editUser.PlayerData.Exp = int.Parse(playerExpTextBox.Text);
                    presenter.EditUser(editUser);
                    SwitchScene(Scene.UserScene);
                }
                else
                {
                    presenter.AddUser(new User
                    {
                        Login = userLoginTextBox.Text,
                        EMail = userEMailTextBox.Text,
                        CreationDate = DateTime.Now,
                        IsEmailValid = validEMailChackBox.Checked,
                        Password = userPasswordTextBox.Text,
                        PlayerData = new Player
                        {
                            Name = playerNameTextBox.Text,
                            Exp = int.Parse(playerExpTextBox.Text)
                        }
                    });
                    SwitchScene(Scene.UserScene);
                } 
            }
            else
            {
                MessageBox.Show("Wrong data");
            }
        }

        // Validation
        private bool ValidateUserData()
        {
            bool isDataValid = true;
            Regex regexName = new Regex(namepassPattern);
            Regex regexEmail = new Regex(emailPattern);

            isDataValid &= regexEmail.IsMatch(userEMailTextBox.Text);
            isDataValid &= regexName.IsMatch(userLoginTextBox.Text);
            isDataValid &= regexName.IsMatch(userPasswordTextBox.Text);
            isDataValid &= regexName.IsMatch(playerNameTextBox.Text);
            isDataValid &= (playerExpTextBox.Text != "");
            int testnum;
            isDataValid &= !(int.TryParse(playerExpTextBox.ToString() , out testnum));

            return isDataValid;
        }

        private void playerExpTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsDigit(e.KeyChar)) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
    }
}
