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
    public partial class RatingForm : Form
    {
        private readonly IService _service = new Service();
        public RatingForm()
        {
            InitializeComponent();
        }

        private void hitLogsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hitLogsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.combatDbDataSet);

        }

        private void RatingForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'combatDbDataSet.HitLogs' table. You can move, or remove it, as needed.
            this.hitLogsTableAdapter.Fill(this.combatDbDataSet.HitLogs);
        }

        private void playersValidEmailRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            dataPlayersGridView.DataSource = _service.PlayersWithValidEmails();
        }
        private void playersTopLongPasswdRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            dataPlayersGridView.DataSource = _service.TopPlayersByLongestPassword();   
        }

        private void playersOrderDateRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            dataPlayersGridView.DataSource = _service.PlayersOrderByDate();
        }

        private void winnersRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            dataCombatsGridView.DataSource = _service.Winners();            
        }

        private void pvesRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            dataCombatsGridView.DataSource = _service.Pves(); 
        }

        private void pvpsRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            dataCombatsGridView.DataSource = _service.Pvps();
        }

        private void transactionsTopSumRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            dataTransactionsGridView.DataSource = _service.TopTransactionsBySum();            
        }

        private void transactionsOrderDateRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            dataTransactionsGridView.DataSource = _service.TransactionsOrderByDate();
        }
    }
}
