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

namespace WinFormsEF
{
    public partial class CombatsForm : Form
    {
        public CombatsForm()
        {
            InitializeComponent();
        }
        private void PlayerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'combatDbDataSet.Combats' table. You can move, or remove it, as needed.
            this.combatsTableAdapter.Fill(this.combatDbDataSet.Combats);
        }

        private void combatsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.combatsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.combatDbDataSet);
        }
    }
}
