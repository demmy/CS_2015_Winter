using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FightClubReports.Data;

namespace FightClubReports
{
    static class Program
    {
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm mainForm = new MainForm();
            MainPresenter mainPresenter = new MainPresenter(mainForm);
            Application.Run(mainForm);
        }
    }
}
