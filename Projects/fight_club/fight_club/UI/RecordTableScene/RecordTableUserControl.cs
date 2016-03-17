﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fight_club
{
    public partial class RecordTableUserControl : BaseUserControl
    {
        Player player1;
        public RecordTableUserControl()
        {
            InitializeComponent();
            RecordTable.Refresh();
        }

        public RecordTableUserControl(object par)
        {
            InitializeComponent();

            RecordTable.DataSource = MainForm.playerRepository.GetAll().
                Select(pers => new {Name = pers.Name , Exp = pers.Exp}).
                OrderByDescending(pers => pers.Exp).ToList();
            player1 = (Player)par;
        }

        private void RecordTableUserControl_Load(object sender, EventArgs e)
        {

        }

        private void ToMenu_Click(object sender, EventArgs e)
        {
            SwitchScene(Scene.Menu , player1);
        }

        private void RecordTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
