using FightClub.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightClub
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
            StartForm startForm = new StartForm();
            DateTime end = DateTime.Now + TimeSpan.FromSeconds(5);
            startForm.Show();
            while(end > DateTime.Now)
            {
                Application.DoEvents();
            }
            startForm.Close();
            startForm.Dispose();
            Application.Run(new ContainerForm());
        }
    }
}
