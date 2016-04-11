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
    public partial class CombatsForm : Form
    {
        public CombatsForm()
        {
            InitializeComponent();
        }

        private void combatsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.combatsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.combatDbDataSet);

        }

        private void CombatsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'combatDbDataSet.Combats' table. You can move, or remove it, as needed.
            this.combatsTableAdapter.Fill(this.combatDbDataSet.Combats);

        }

      
    }
}
