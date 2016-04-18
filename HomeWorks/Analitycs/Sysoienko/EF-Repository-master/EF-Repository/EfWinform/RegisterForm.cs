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

namespace EfWinform
{
    public partial class RegisterForm : Form
    {
        PlayerService _service;
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            _service = new PlayerService();
            _service.CreatePlayer(loginTextBox.Text, passwdTextBox.Text, emailTextBox.Text, checkValidEmail.Checked);
            _service.Save();
            MessageBox.Show("Registered!");
            this.Close();
        }
    }
}
