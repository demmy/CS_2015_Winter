using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using GameCore;

namespace Combats
{
    public partial class Score : Form, IScore
    {
        ScorePresenter present = null;               
        string name;
        bool loadStatus;
        public Score()
        {                 
            InitializeComponent();
            present = new ScorePresenter(this);
        }
        public void StartWindow()
        {
            ShowDialog();
        }
        public string NamePlayer
        {
            get { return name; }
        }
        public bool LoadStatus
        {
            get { return loadStatus; }
            set { loadStatus = value; } 
        }
        private void StartBtn_Click(object sender, EventArgs e)
        {
            name = insertNameTxt.Text;
            if (insertNameTxt.Text != "Введите ваше имя" && insertNameTxt.Text != "")
            {
                this.Hide();
            }
        }
        private void InsertNameTxt_Click(object sender, EventArgs e)
        {
            insertNameTxt.Text = "";
        }
        public void ShowTableStat(Result[] table)
        {
            for (int i = 0; i < table.Length; i++)
            {
                resultDataGtid.Rows.Add(i + 1, table[i].Name, table[i].Hp);
                resultDataGtid.Sort(resultDataGtid.Columns[2], ListSortDirection.Descending);
            }
        }
        private void loadBtn_Click(object sender, EventArgs e)
        {
            loadStatus = true;
            name = insertNameTxt.Text;
            if (insertNameTxt.Text != "Введите ваше имя" && insertNameTxt.Text != "")
            {
                this.Hide();
            }
        }
        private void insertNameTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                StartBtn_Click(this, EventArgs.Empty); 
            }
        }
    }
}
