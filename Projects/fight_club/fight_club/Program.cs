using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fight_club
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new CombatForm());
            //Application.Run(new AuthorizationForm());
            //Application.Run(new RecordTableForm()); 
            Application.Run(new MainForm());
        }
    }
}
