using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EfWinform.Class;
using EfWinform.Class.Services;
using EfWinform.Interface;

namespace EfWinform
{
    public partial class LoginForm : Form
    {
        private int _attempts = 0;
        private const int MaxLoginAttempts = 3;
        private PlayerService _service;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            var check = false;
            _service = new PlayerService();
            _attempts++;
            if (radioUserAuth.Checked)
            {
                var myCheckingValidateUser = _service.CheckingValidateUser(nameTextbox.Text, passwdTextbox.Text);
                if (myCheckingValidateUser != null)
                {
                    check = true;
                    MessageBox.Show("Ok!", "Message");
                    this.Hide();
                    DataForm form = new DataForm() { MdiParent = this.MdiParent as ContainerForm };
                    form.Show();
                    this.Close();
                }
            }
            if (radioGuestAuth.Checked)
            {
                check = true;
                MessageBox.Show("Welcome Guest!");
                this.Hide();
                CombatForm form = new CombatForm() { MdiParent = this.MdiParent as ContainerForm };
                form.Show();
                this.Close();
            }
            if (!check)
            {

                if (_attempts == MaxLoginAttempts)
                {
                    MessageBox.Show("Invalid login. You have reached the maximum number of invalid login attempts.",
                        string.Format("Invalid Login (attempt {0} of {1})", _attempts, MaxLoginAttempts));
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Invalid login. Try again.",
                        string.Format("Invalid Login (attempt {0} of {1})", _attempts, MaxLoginAttempts));
                }
            }
        }

        private void passwdTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char) Keys.Enter) return;
            e.Handled = true;
            enterBtn.PerformClick();
        }
        private void radioGuestAuth_CheckedChanged(object sender, EventArgs e)
        {
            nameTextbox.Text = "";
            nameTextbox.Enabled = false;
            passwdTextbox.Text = "";
            passwdTextbox.Enabled = false;
            nameLabel.Enabled = false;
            passwdLabel.Enabled = false;
        }
        private void radioUserAuth_CheckedChanged(object sender, EventArgs e)
        {
            nameTextbox.Enabled = true;
            passwdTextbox.Enabled = true;
            nameLabel.Enabled = true;
            passwdLabel.Enabled = true;
        }
        private void loginGroupBox_Enter(object sender, EventArgs e)
        {
            radioGuestAuth.Checked = true;
        }

    }
}
