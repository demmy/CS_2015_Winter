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
using EF_Repository.Model;
using EF_Repository.Model.Interfaces;

namespace EfWinform
{
    public partial class DataForm : Form
    {
        private PlayerService _service;
        BindingSource _playerSource = new BindingSource();
        public DataForm()
        {
            InitializeComponent();
        }
        public object DataGrid
        {
            set { playersDataGridView.DataSource = value; }
        }
        private void DataForm_Load(object sender, EventArgs e)
        {
            _service = new PlayerService();
            foreach (var item in _service.GetPlayers())
            {
                _playerSource.Add(item);
            }
            playersDataGridView.DataSource = _playerSource;
            playersDataGridView.AutoGenerateColumns = true;
            loginTextBox.DataBindings.Add("Text", _playerSource, "Login");
            loginTextBox.Enabled = false;
            passwdTextBox.Enabled = false;
            passwdTextBox.DataBindings.Add("Text", _playerSource, "Password");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginTextBox.Enabled = true;
            passwdTextBox.Enabled = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            _playerSource.EndEdit();
            _service.Save();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (playersDataGridView.CurrentRow != null)
            {
               var  userId = int.Parse(playersDataGridView.CurrentRow.Cells[0].Value.ToString());
               _service.DeleteById(userId);
                _playerSource.RemoveCurrent();
               _service.Save();  
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            playersDataGridView.DataSource = null;
            playersDataGridView.DataSource = _playerSource;
            playersDataGridView.Update();
        }
    }
}
