using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISD_10
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
           
            Player player = new Player();
            Bot bot = new Bot();
            MainForm form = new MainForm();
            

            Presenter present = new Presenter(player,form,bot);
            Application.Run(form);
        }
    }
}
