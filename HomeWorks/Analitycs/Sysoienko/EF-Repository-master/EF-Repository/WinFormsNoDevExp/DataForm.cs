using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsNoDevExp
{
    public partial class DataForm : Form
    {
        public DataForm()
        {
            InitializeComponent();
        }
        private void DataForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'combatDbDataSet.HitLogs' table. You can move, or remove it, as needed.
            this.hitLogsTableAdapter.Fill(this.combatDbDataSet.HitLogs);
            // TODO: This line of code loads data into the 'combatDbDataSet.Combats' table. You can move, or remove it, as needed.
            this.combatsTableAdapter.Fill(this.combatDbDataSet.Combats);
            // TODO: This line of code loads data into the 'combatDbDataSet.Transcations' table. You can move, or remove it, as needed.
            this.transcationsTableAdapter.Fill(this.combatDbDataSet.Transcations);
            // TODO: This line of code loads data into the 'combatDbDataSet.Players' table. You can move, or remove it, as needed.
            this.playersTableAdapter.Fill(this.combatDbDataSet.Players);
          
        }

        private void playersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.playersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.combatDbDataSet);

        }
    }
}
