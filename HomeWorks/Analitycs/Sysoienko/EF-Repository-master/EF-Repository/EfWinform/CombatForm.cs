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
    public partial class CombatForm : Form, ICombatForm
    {
        private CombatFormPresenter _presenter;
        public CombatForm()
        {
            InitializeComponent();
            _presenter = new CombatFormPresenter(this);
        }

        public event EventHandler ShowCombatGrid;


        public object CombatGrid
        {
            set { combatsDataGridView.DataSource = value; }
        }

        private void CombatForm_Load(object sender, EventArgs e)
        {
            if (ShowCombatGrid != null)
                ShowCombatGrid(this,EventArgs.Empty);
        }
    }
}
