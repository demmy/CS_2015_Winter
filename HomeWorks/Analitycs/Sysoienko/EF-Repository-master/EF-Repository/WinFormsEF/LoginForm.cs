using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EF_Repository.Data;
using EF_Repository.Model;
using WinFormsEF.Classes;
using WinFormsEF.Classes.Interfaces;

namespace WinFormsEF
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
            if (radioButton1.Checked)
            {
                var myCheckingValidateUser = _service.CheckingValidateUser(textBox1.Text, textBox2.Text);
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
            if (radioButton2.Checked)
            {
                check = true;
                MessageBox.Show("Welcome Guest!");
                this.Hide();
                CombatsForm form = new CombatsForm() { MdiParent = this.MdiParent as ContainerForm };
                form.Show();
                this.Close();
            }
            if (!check)
            {

                if (_attempts == MaxLoginAttempts)
                {
                    MessageBox.Show("Invalid login. You have reached the maximum number of invalid login attempts.", string.Format("Invalid Login (attempt {0} of {1})", _attempts, MaxLoginAttempts));
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Invalid login. Try again.", string.Format("Invalid Login (attempt {0} of {1})", _attempts, MaxLoginAttempts));
                }
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                button1.PerformClick();
            }
        }

        private void radioGuestAuth_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Enabled = false;
            textBox2.Text = "";
            textBox2.Enabled = false;
            label1.Enabled = false;
            label2.Enabled = false;
        }
        private void radioUserAuth_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            label1.Enabled = true;
            label2.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }
    }
}
