using System;
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
        public RecordTableUserControl()
        {
            InitializeComponent();
            //RecordTable.DataSource = MainForm.playerRepository.GetAll();
            RecordTable.DataSource = MainForm.playerRepository.GetAllRecords();
        }

        private void RecordTableUserControl_Load(object sender, EventArgs e)
        {

        }

        private void ToMenu_Click(object sender, EventArgs e)
        {
            SwitchScene(Scene.Menu);
        }
    }
}
