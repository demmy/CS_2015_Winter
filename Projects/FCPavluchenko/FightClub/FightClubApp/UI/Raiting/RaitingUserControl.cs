using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FightClubApp.Game;
using System.Windows.Forms;

namespace FightClubApp.UI.Raiting
{
    public partial class RaitingUserControl : BaseUserControl
    {
        Data[] table = null;
        public RaitingUserControl()
        {
            InitializeComponent();
            WorkWithFile file = new WorkWithFile();
            this.table = file.ReadFile();
            DrowTableStat();
        }

        public void DrowTableStat()
        {
            for (int i = 0; i < table.Length; i++)
            {
                raitingTable.ColumnCount = 6;
                raitingTable.Rows.Add(i + 1, table[i].Name, table[i].NumberOfWin, table[i].NumberOfTie, table[i].NumberOfLoss, table[i].NumberOfFight );
            }
        }
        
        private void toMenu_Click(object sender, EventArgs e)
        {
            SwitchScene(Scene.Login);
        }
    }
}
