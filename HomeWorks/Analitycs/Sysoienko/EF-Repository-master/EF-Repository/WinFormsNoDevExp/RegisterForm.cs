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
    public partial class RegisterForm : Form
    {
        private IService _service;
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _service = new Service();
            _service.CreatePlayer(textBox1.Text, textBox2.Text, textBox3.Text, checkValidEmail.Checked);
            MessageBox.Show("Registered!");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
