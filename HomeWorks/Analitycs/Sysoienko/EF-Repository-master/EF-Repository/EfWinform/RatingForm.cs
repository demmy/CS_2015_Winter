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
using EfWinform.Class.Presenters;
using EfWinform.Interface;

namespace EfWinform
{
    public partial class RatingForm : Form,IRatingForm
    {
        private RatingFormPresenter _presenter;
        public RatingForm()
        {
            InitializeComponent();
            _presenter = new RatingFormPresenter(this);
        }

        private void playersOrderDateRdBtn_CheckedChanged(object sender, EventArgs e)
        {
           if(PlayersOrderByDate!=null)
               PlayersOrderByDate(this,EventArgs.Empty);
        }

        private void playersTopLongPasswdRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (TopPlayersByLongestPassword != null)
                TopPlayersByLongestPassword(this, EventArgs.Empty);
        }

        private void playersValidEmailRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            if(PlayersWithValidEmails!=null)
                PlayersWithValidEmails(this,EventArgs.Empty);
        }

        public object PlayersGrid
        {
            set { dataPlayersGridView.DataSource = value; }
        }

        public object CombatsGrid
        {
            set { dataCombatsGridView.DataSource = value; }
        }

        public object TransactionsGrid
        {
            set { dataTransactionsGridView.DataSource = value; }
        }

        public object HitLogsGrid
        {
            set { dataHitLogsGridView.DataSource = value; }
        }
        private void showBtn_Click(object sender, EventArgs e)
        {
            if (ShowHitLogsGrid != null)
                ShowHitLogsGrid(this,EventArgs.Empty);
        }

        private void winnersRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            if(Winners!=null)
                Winners(this,EventArgs.Empty);
        }

        private void pvesRdbtn_CheckedChanged(object sender, EventArgs e)
        {
             if(Pves!=null)
                 Pves(this,EventArgs.Empty);
        }

        private void pvpsRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            if(Pvps!=null)
                Pvps(this,EventArgs.Empty);
        }

        private void transactionsTopSumRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            if(TopTransactionsBySum!=null)
                TopTransactionsBySum(this,EventArgs.Empty);
        }

        private void transactionsOrderDateRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (TransactionsOrderByDate != null)
                TransactionsOrderByDate(this, EventArgs.Empty);
        }
        public event EventHandler ShowCombatsGrid;

        public event EventHandler ShowPlayersGrid;

        public event EventHandler ShowTransactionsGrid;

        public event EventHandler ShowHitLogsGrid;

        public event EventHandler Pves;

        public event EventHandler Pvps;

        public event EventHandler Winners;

        public event EventHandler PlayersWithValidEmails;

        public event EventHandler TopPlayersByLongestPassword;

        public event EventHandler PlayersOrderByDate;

        public event EventHandler TopTransactionsBySum;

        public event EventHandler TransactionsOrderByDate;
    }
}
