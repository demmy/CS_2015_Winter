using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsNoDevExp.Class;
using WinFormsNoDevExp.Class.Interface;

namespace WinFormsNoDevExp
{
    public partial class LoginForm : Form
    {
        private IService _service;
        private int _attempts = 0;
        private const int MaxLoginAttempts = 3;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool check = false;
            _service = new Service();
            _attempts++;
            if (radioUserAuth.Checked)
            {
                var myCheckingValidateUser = _service.CheckingValidateUser(nameTextbox.Text, passwdTextbox.Text);
                if (myCheckingValidateUser != null)
                {
                    check = true;
                    MessageBox.Show("Ok!", "Message");
                    this.Hide();
                    DataForm form = new DataForm() {MdiParent = this.MdiParent as ContainerForm};
                    form.Show();
                    this.Close();
                }

            }
            if (radioGuestAuth.Checked)
            {
                check = true;
                MessageBox.Show("Welcome Guest!");
                this.Hide();
                CombatsForm form = new CombatsForm() {MdiParent = this.MdiParent as ContainerForm};
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                enterBtn.PerformClick();
            }
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            radioUserAuth.Checked = true;
        }
        
    }
}
